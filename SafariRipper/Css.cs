using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariRipper
{
    class Css
    {
        public static string GetCssText()
        {
            return @"
                <style>		
                    body {
						font-family: Georgia, Palatino, serif;
						font-size: 18pt;
						background-color: white;
						color: black;
						padding: 0;
						margin: 0;
					}

                    #cover-image img, #Cover~img, .cover img, img[alt=cover] { 
						width: 100% 
					}
					
					a {
                      color: #2a6496;
                      text-decoration: underline;
                    }
					
					.bullet img, .bullet1 img {
						display: inline;
					}
					
                    h1, .h1, .Heading1, .ChapterNumber,
                    h2, .h2, .Heading2, .ChapterTitle,
                    h3, .h3, .Heading3,
                    h4, .h4, .Heading4,
                    h5, .h5, .Heading5,
                    h6, .h6, .Heading6,
					.chaptertitle,
					.chapterobjectivetitle {
                      font-family: Helvetica,Arial,sans-serif;
					  padding-top: 1em;
					  font-weight: bold;
                    }
					
                    h1, .h1, .chaptertitle, .Heading1, .ChapterNumber {
                      font-size: 150%;
                    }
					h2, .h2, .chapterobjectivetitle, .Heading2, .ChapterTitle {
						font-size: 120%;
					}
					
					#sbo-rt-content {
						border-top: 2px solid gainsboro;
					}
					
                    blockquote, .note {
					  margin: 2em;
					  padding: 0.5em;
                      border-left: 5px solid gainsboro;
					  background-color: #f5f5f5;
                    }
                    code,
                    kbd,
                    pre,
                    samp,
					.inlinecode,
					.FontName1 {
                      font-family: Consolas, Menlo, Monaco, Courier New, monospace;
                    }
                    code,
					.inlinecode,
					p .FontName1 {
                      padding: 2px 4px;
                      font-size: 90%;
                      background-color: rgba(0,0,0,0.08);
                      border-radius: 4px;
                    }
                    kbd {
                      padding: 2px 4px;
                      font-size: 90%;
                      color: #ffffff;
                      background-color: #333333;
                      border-radius: 3px;
                      box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.25);
                    }
                    pre {
                      display: block;
                      padding: 1em;
                      margin: 0 0 10px;
                      font-size: 90%;
                      line-height: 1.42857143;
                      word-break: break-all;
                      color: #333333;
                      background-color: #f5f5f5;
                      border: 1px solid #cccccc;
                      border-radius: 0.4em;
                      overflow: auto;
                      word-wrap: normal;
                        white-space: pre-wrap;       /* CSS 3 */
                        white-space: -moz-pre-wrap;  /* Mozilla, since 1999 */
                        white-space: -pre-wrap;      /* Opera 4-6 */
                        white-space: -o-pre-wrap;    /* Opera 7 */
                        word-wrap: break-word;       /* Internet Explorer 5.5+ */
                    }
                    pre code
                    {
                        padding: 0;
                        font-size: inherit;
                        color: inherit;
                        white-space: pre-wrap;
                        background-color: transparent;
                        border-radius: 0;
                    }
					
					.codenote {
						font-size: 60%;
						text-align: right;
						font-weight: bold;
					}
					
                    table {
                      width: 100%;
                      margin-bottom: 2em;
                      border-collapse: collapse;
                      border-spacing: 0;
					  border-radius: 0.4em;
                    }
                    table th, table td {
                      padding: 0.5em;
                      line-height: 1.42857143;
                      vertical-align: top;
                      border: 1px solid gainsboro;
                    }
                    table th, table .tabularhead {
                      vertical-align: bottom;
                      border-bottom: 2px solid black;
                      text-align: left;
                    }
                    table tr:nth-child(odd) > td {
                      background-color: #f9f9f9;
                    }
                </style>";
        }
    }
}
