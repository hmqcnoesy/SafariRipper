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
                    html {
                      font-family: sans-serif;
                    }
                    article,
                    aside,
                    details,
                    figcaption,
                    figure,
                    footer,
                    header,
                    hgroup,
                    main,
                    nav,
                    section,
                    summary {
                      display: block;
                    }
                    audio,
                    canvas,
                    progress,
                    video {
                      display: inline-block;
                      vertical-align: baseline;
                    }
                    audio:not([controls]) {
                      display: none;
                      height: 0;
                    }
                    [hidden],
                    template {
                      display: none;
                    }
                    a {
                      background: transparent;
                    }
                    a:active,
                    a:hover {
                      outline: 0;
                    }
                    abbr[title] {
                      border-bottom: 1px dotted;
                    }
                    b,
                    strong {
                      font-weight: bold;
                    }
                    dfn {
                      font-style: italic;
                    }
                    h1 {
                      font-size: 120%;
                      margin: 0.67em 0;
                    }
                    mark {
                      background: #ff0;
                      color: #000;
                    }
                    small {
                      font-size: 80%;
                    }
                    sub,
                    sup {
                      font-size: 75%;
                      line-height: 0;
                      position: relative;
                      vertical-align: baseline;
                    }
                    sup {
                      top: -0.5em;
                    }
                    sub {
                      bottom: -0.25em;
                    }
                    img {
                      border: 0;
                    }
                    svg:not(:root) {
                      overflow: hidden;
                    }
                    figure {
                      margin: 1em 40px;
                    }
                    hr {
                      -moz-box-sizing: content-box;
                      box-sizing: content-box;
                      height: 0;
                    }
                    pre {
                      overflow: auto;
                    }
                    code,
                    kbd,
                    pre,
                    samp {
                      font-family: monospace, monospace;
                      font-size: 100%;
                    }
                    table {
                      border-collapse: collapse;
                      border-spacing: 0;
                    }
                    td,
                    th {
                      padding: 0;
                    }
                    * {
                      -webkit-box-sizing: border-box;
                      -moz-box-sizing: border-box;
                      box-sizing: border-box;
                    }
                    *:before,
                    *:after {
                      -webkit-box-sizing: border-box;
                      -moz-box-sizing: border-box;
                      box-sizing: border-box;
                    }
                    body {
                      font-family: Georgia, Helvetica Neue, Helvetica, Arial, sans-serif;
                      font - size: 24pt;
                                background - color: white;
                                color: black;
                                padding - left: 5mm;
                                padding - right: 5mm;
                            }
                            input,
                    button,
                    select,
                    textarea {
                      font-family: inherit;
                      font-size: inherit;
                      line-height: inherit;
                    }
                        a {
                      color: #428bca;
                      text-decoration: none;
                    }
                    a:hover,
                    a:focus {
                      color: #2a6496;
                      text-decoration: underline;
                    }
                    a:focus {
                      outline: thin dotted;
                    outline: 5px auto -webkit-focus-ring-color;
                      outline-offset: -2px;
                    }
                    figure {
                      margin: 0;
                    }
                    img {
                      vertical-align: middle;
                    }
                    .img-responsive {
                      display: block;
                      width: 100% \9;
                      max-width: 100%;
                      height: auto;
                    }
                    hr {
                      margin-top: 20px;
                      margin-bottom: 20px;
                      border: 0;
                      border-top: 1px solid #eeeeee;
                    }
                    h1,
                    h2,
                    h3,
                    h4,
                    h5,
                    h6 {
                      font-family: AvenirNextCondensed-Medium,HelveticaNeue-CondensedBold,Droid Sans,Helvetica,Arial,sans-serif;
                      font-weight: 500;
                      line-height: 1.1;
                      color: inherit;
                    }
                    h1,
                    h2,
                    h3 {
                      margin-top: 2em;
                      margin-bottom: 10px;
                    }
                    h4,
                    h5,
                    h6 {
                      margin-top: 1em;
                      margin-bottom: 10px;
                    }
                    h1 {
                      font-size: 200%;
                    }
                    h2 {
                      font-size: 180%;
                    }
                    h3 {
                      font-size: 160%;
                    }
                    h4 {
                      font-size: 140%;
                    }
                    h5 {
                      font-size: 120%;
                    }
                    h6 {
                      font-size: 110%;
                    }
                    p {
                      margin: 1em 0 1em 0;
                    }
                    small {
                      font-size: 85%;
                    }
                    cite {
                      font-style: normal;
                    }
                    mark {
                      background-color: #fcf8e3;
                      padding: .2em;
                    }
                    ul,
                    ol {
                      margin-top: 0;
                      margin-bottom: 10px;
                    }
                    ul ul,
                    ol ul,
                    ul ol,
                    ol ol {
                      margin-bottom: 0;
                    }
                    dl {
                      margin-top: 0;
                      margin-bottom: 20px;
                    }
                    dt,
                    dd {
                      line-height: 1.42857143;
                    }
                    dt {
                      font-weight: bold;
                    }
                    dd {
                      margin-left: 0;
                    }
                    abbr[title],
                    abbr[data - original - title] {
                      cursor: help;
                      border-bottom: 1px dotted #777777;
                    }
                    blockquote {
                      padding: 10px 20px;
                      margin: 0 0 20px;
                      border-left: 5px solid #eeeeee;
                    }
                    blockquote:before,
                    blockquote:after {
                      content: """";
                    }
                    address {
                      margin-bottom: 20px;
                      font-style: normal;
                      line-height: 1.42857143;
                    }
                    code,
                    kbd,
                    pre,
                    samp {
                      font-family: Menlo, Monaco, Consolas, Courier New, monospace;
                    }
                    code {
                      padding: 2px 4px;
                      font-size: 90%;
                      color: #c7254e;
                      background-color: gainsboro;
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
                    kbd kbd
                    {
                        padding: 0;
                        font-size: 100%;
                        box-shadow: none;
                    }
                    pre {
                      display: block;
                      padding: 1em;
                      margin: 0 0 10px;
                      font-size: 90%;
                      line-height: 1.42857143;
                      word-break: break-all;
                      word-wrap: break-word;
                      color: #333333;
                      background-color: #f5f5f5;
                      border: 1px solid #cccccc;
                      border-radius: 4px;
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
                    table {
                      background-color: transparent;
                      width: 100%;
                      max-width: 100%;
                      margin-bottom: 20px;
                    }
                    th {
                      text-align: left;
                    }
                    table > thead > tr > th,
                    table > tbody > tr > th,
                    table > tfoot > tr > th,
                    table > thead > tr > td,
                    table > tbody > tr > td,
                    table > tfoot > tr > td {
                      padding: 8px;
                      line-height: 1.42857143;
                      vertical-align: top;
                      border-top: 1px solid #dddddd;
                    }
                    table > thead > tr > th {
                      vertical-align: bottom;
                      border-bottom: 2px solid #dddddd;
                    }
                    table > caption + thead > tr:first-child > th,
                    table > colgroup + thead > tr:first-child > th,
                    table > thead:first-child > tr:first-child > th,
                    table > caption + thead > tr:first-child > td,
                    table > colgroup + thead > tr:first-child > td,
                    table > thead:first-child > tr:first-child > td {
                      border-top: 0;
                    }
                    table > tbody + tbody {
                      border-top: 2px solid #dddddd;
                    }
                    table table
                    {
                        background-color: #ffffff;
                    }
                    table {
                      border: 1px solid #dddddd;
                    }
                    table > thead > tr > th,
                    table > tbody > tr > th,
                    table > tfoot > tr > th,
                    table > thead > tr > td,
                    table > tbody > tr > td,
                    table > tfoot > tr > td {
                      border: 1px solid #dddddd;
                    }
                    table > thead > tr > th,
                    table > thead > tr > td {
                      border-bottom-width: 2px;
                    }
                    table > tbody > tr:nth-child(odd) > td,
                    table > tbody > tr:nth-child(odd) > th {
                      background-color: #f9f9f9;
                    }
                    table col[class*=""col-""] {
                      position: static;
                      float: none;
                      display: table-column;
                    }
                    table td[class*=""col-""],
                    table th[class*=""col-""] {
                      position: static;
                      float: none;
                      display: table-cell;
                    }
                    @media screen and(max-width: 767px)
                    {
                      .table - responsive {
                            width: 100 %;
                            margin - bottom: 15px;
                            overflow - y: hidden;
                            overflow - x: auto;
                            -ms - overflow - style: -ms - autohiding - scrollbar;
                            border: 1px solid #dddddd;
                        -webkit - overflow - scrolling: touch;
                        }
                      .table - responsive > .table {
                            margin - bottom: 0;
                        }
                      .table - responsive > .table > thead > tr > th,
                      .table - responsive > .table > tbody > tr > th,
                      .table - responsive > .table > tfoot > tr > th,
                      .table - responsive > .table > thead > tr > td,
                      .table - responsive > .table > tbody > tr > td,
                      .table - responsive > .table > tfoot > tr > td {
                            white - space: nowrap;
                        }
                      .table - responsive > .table - bordered {
                            border: 0;
                        }
                      .table - responsive > .table - bordered > thead > tr > th:first - child,
                      .table - responsive > .table - bordered > tbody > tr > th:first - child,
                      .table - responsive > .table - bordered > tfoot > tr > th:first - child,
                      .table - responsive > .table - bordered > thead > tr > td:first - child,
                      .table - responsive > .table - bordered > tbody > tr > td:first - child,
                      .table - responsive > .table - bordered > tfoot > tr > td:first - child {
                            border - left: 0;
                        }
                      .table - responsive > .table - bordered > thead > tr > th:last - child,
                      .table - responsive > .table - bordered > tbody > tr > th:last - child,
                      .table - responsive > .table - bordered > tfoot > tr > th:last - child,
                      .table - responsive > .table - bordered > thead > tr > td:last - child,
                      .table - responsive > .table - bordered > tbody > tr > td:last - child,
                      .table - responsive > .table - bordered > tfoot > tr > td:last - child {
                            border - right: 0;
                        }
                      .table - responsive > .table - bordered > tbody > tr:last - child > th,
                      .table - responsive > .table - bordered > tfoot > tr:last - child > th,
                      .table - responsive > .table - bordered > tbody > tr:last - child > td,
                      .table - responsive > .table - bordered > tfoot > tr:last - child > td {
                            border - bottom: 0;
                        }
                    }
                    @-ms-viewport {
                      width: device-width;
                    }


                    pre {
                      overflow: auto;
                      word-wrap: normal;
                        white-space: pre-wrap;       /* CSS 3 */
                        white-space: -moz-pre-wrap;  /* Mozilla, since 1999 */
                        white-space: -pre-wrap;      /* Opera 4-6 */
                        white-space: -o-pre-wrap;    /* Opera 7 */
                        word-wrap: break-word;       /* Internet Explorer 5.5+ */
                    }

                    a.leftnav {
	                    width: 50%;
	                    padding: 0.5em;
	                    margin: 0;
	                    text-align: left;
	                    white-space: nowrap;
	                    overflow: hidden;
	                    text-overflow: ellipsis;
	                    border: none;
	                    display: inline-block;
	                    background-color: #dcdcdc;
                    }

                    a.centernav {
	                    width: 100%;
	                    padding: 0.5em;
	                    margin: 0;
	                    text-align: center;
	                    white-space: nowrap;
	                    overflow: hidden;
	                    text-overflow: ellipsis;
	                    border: none;
	                    display: block;
	                    background-color: #dcdcdc;
                    }

                    a.rightnav {
	                    width: 50%;
	                    padding: 0.5em;
	                    margin: 0;
	                    text-align: right;
	                    white-space: nowrap;
	                    overflow: hidden;
	                    text-overflow: ellipsis;
	                    border: none;
	                    display: inline-block;
	                    background-color: #dcdcdc;
                    }

                    .FontName1 { font-family: Consolas; }

                    #cover-image img { width: 100% }
                </style>";
        }
    }
}
