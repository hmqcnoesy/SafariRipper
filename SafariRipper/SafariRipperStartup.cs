using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fiddler;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace SafariRipper
{
    public class SafariRipperStartup : Fiddler.IFiddlerExtension
    {
        private UserControlSafariRipper _userControl;
        private string _saveDirectory;
        private HtmlAgilityPack.HtmlDocument _htmlDoc;
        private Dictionary<string, string> _oldAndNewImageUrls;
        private string _nodesToRemove;
        private int _imageCount = 0;


        void IFiddlerExtension.OnLoad()
        {
            var tabPage = new TabPage("Safari Ripper");
            tabPage.ImageIndex = (int)Fiddler.SessionIcons.HTML;
            _userControl = new UserControlSafariRipper(this);
            tabPage.Controls.Add(_userControl);
            tabPage.Controls[0].Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            Fiddler.FiddlerApplication.UI.tabsViews.TabPages.Add(tabPage);
        }


        void IFiddlerExtension.OnBeforeUnload()
        {
        }


        internal void RipSessions(string saveLocation, IEnumerable<string> urls, IEnumerable<string> nodesToRemove, bool clearSessions)
        {
            _saveDirectory = saveLocation;
            _oldAndNewImageUrls = new Dictionary<string, string>();
            _nodesToRemove = string.Join("|", nodesToRemove);
            InitializeHtmlFile();

            var allSessions = Fiddler.FiddlerApplication.UI.GetAllSessions().OrderBy(s => s.id).ToList();

            foreach (var session in allSessions)
            {
                if (!urls.Any(u => session.uriContains(u))) continue;

                if (session.oResponse.MIMEType.StartsWith("image/"))
                {
                    SaveImageFile(session.responseBodyBytes, session.url);
                }

                if (session.oResponse.MIMEType == "application/json")
                {
                    try
                    {
                        session.utilDecodeResponse();
                    }
                    finally
                    {
                        var html = GetHtmlFromJson(Encoding.UTF8.GetString(session.responseBodyBytes));
                        AppendToHtml(html);
                    }
                }
            }

            FinalizeHtml();

            if (clearSessions) Fiddler.FiddlerApplication.UI.actRemoveAllSessions();
        }


        private string GetHtmlFromJson(string json)
        {
            var anonType = new { content = "" };
            var chapter = JsonConvert.DeserializeAnonymousType(json.Substring(1, json.Length - 2), anonType);
            var html = chapter.content.Replace(@"\u00a", string.Empty);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            RemoveUnwantedElements(doc);
            UpdateImageSrcAttributes(doc);

            return doc.DocumentNode.OuterHtml;
        }


        private void RemoveUnwantedElements(HtmlAgilityPack.HtmlDocument doc)
        {
            var elementsToRemove = doc.DocumentNode.SelectNodes(_nodesToRemove);

            if (elementsToRemove == null) return;

            foreach (var elem in elementsToRemove)
            {
                elem.Remove();
            }
        }


        private void UpdateImageSrcAttributes(HtmlAgilityPack.HtmlDocument doc)
        {
            var imageTags = doc.DocumentNode.SelectNodes("//img");
            if (imageTags == null) return;

            foreach (var img in imageTags)
            {
                var src = img.Attributes["src"];
                if (src == null) continue;

                if (!_oldAndNewImageUrls.ContainsKey(src.Value))
                {
                    var ext = src.Value.Substring(src.Value.LastIndexOf('.'));
                    ++_imageCount;
                    var imgName = _imageCount.ToString().PadLeft(3, '0') + ext;
                    _oldAndNewImageUrls.Add(src.Value, imgName);
                }

                src.Value = _oldAndNewImageUrls[src.Value];
            }
        }


        private void SaveImageFile(byte[] responseBodyBytes, string url)
        {
            url = url.Replace("www.safaribooksonline.com", string.Empty);
            if (!_oldAndNewImageUrls.ContainsKey(url)) return;

            var saveLocation = Path.Combine(_saveDirectory, _oldAndNewImageUrls[url]);
            File.WriteAllBytes(saveLocation, responseBodyBytes);
        }


        private void InitializeHtmlFile()
        {
            _htmlDoc = new HtmlAgilityPack.HtmlDocument();
            var html = "<!doctype html><html><head><title></title>{0}</head><body></body></html>";
            html = string.Format(html, Css.GetCssText());
            _htmlDoc.LoadHtml(html);
        }


        private void AppendToHtml(string html)
        {
            var htmlToAppend = html + "\r\n\r\n<div style=\"page-break-after: always\"></div>\r\n\r\n";
            _htmlDoc.DocumentNode.SelectSingleNode("//body").InnerHtml += htmlToAppend;
        }


        private void FinalizeHtml()
        {
            var htmlFile = Path.Combine(_saveDirectory, "index.html");
            File.WriteAllText(htmlFile, _htmlDoc.DocumentNode.OuterHtml);
            System.Diagnostics.Process.Start("iexplore", "file://" + htmlFile);
        }
    }
}
