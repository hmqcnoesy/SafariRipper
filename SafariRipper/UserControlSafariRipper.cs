using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SafariRipper
{
    public partial class UserControlSafariRipper : UserControl
    {
        private SafariRipperStartup _extension;

        public UserControlSafariRipper(SafariRipperStartup safariRipperStartup)
        {
            InitializeComponent();
            this._extension = safariRipperStartup;
        }

        private void UserControlSafariRipper_Load(object sender, EventArgs e)
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtSaveLocation.Text = Path.Combine(desktopPath, "SafariRipper\\");
            txtSaveLocation.Select();
        }


        private void OnClickSaveButton(object sender, EventArgs e)
        {
            var saveLocation = txtSaveLocation.Text;
            try
            {
                if (!Directory.Exists(saveLocation)) Directory.CreateDirectory(saveLocation);
            }
            catch
            {
                MessageBox.Show("Couldn't find or create a directory at the specified location");
                return;
            }

            var urls = txtUrls.Lines;
            var nodesToRemove = txtXpathNodesToRemove.Lines;

            _extension.RipSessions(saveLocation, urls, nodesToRemove, chkClearSessions.Checked);
        }
    }
}
