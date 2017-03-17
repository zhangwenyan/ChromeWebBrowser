using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xilium.CefGlue.WindowsForms;

namespace ChromeWebBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CefWebBrowser cb = new CefWebBrowser();
            cb.StartUrl = "http://hao123.com";
            this.Controls.Add(cb);
            cb.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
