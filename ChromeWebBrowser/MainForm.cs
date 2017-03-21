using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xilium.CefGlue.WindowsForms;
using CCWin;

namespace ChromeWebBrowser
{
    public partial class MainForm : CCSkinMain
    {
        public MainForm()
        {
            InitializeComponent();
            CefWebBrowser cb = new CefWebBrowser();
            cb.StartUrl = "http://localhost:1795/index.html";
            this.Controls.Add(cb);
            cb.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
