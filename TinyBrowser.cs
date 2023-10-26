using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
namespace 쇼핑_검색
{
    public partial class TinyBrowser : Form
    {
        public ChromiumWebBrowser _chrome = null;
        public TinyBrowser(string url)
        {
            InitializeComponent();
            InitBrowser(url);
        }
        public void InitBrowser(string url)
        {
            //CefSettings settings = new CefSettings();
            //settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            //Cef.Initialize(settings);

            //웹 사이트 이동
            _chrome = new ChromiumWebBrowser(url);
            //한국어 설정
            _chrome.BrowserSettings.AcceptLanguageList = "ko-KR";
            //Main Form에 CefSharp컨트롤 추가
            this.Controls.Add(_chrome);
            //Main Form 전체 영역에 붙이기
            _chrome.Dock = DockStyle.Fill;
        }

        private void TinyBrowser_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
