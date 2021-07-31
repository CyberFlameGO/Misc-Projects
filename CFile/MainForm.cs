using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace CFile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BROWSE_BUTTON_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FBD = new FolderBrowserDialog() { Description = "Select a folder." })
            {
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    FILE_BROWSER.Url = new Uri(FBD.SelectedPath);
                    ADDRESS_BAR.Text = FBD.SelectedPath;
                }
            }
        }

        private void BACK_BUTTON_Click(object sender, EventArgs e)
        {
            if (FILE_BROWSER.CanGoBack)
            {
                FILE_BROWSER.GoBack();
                ADDRESS_BAR.Text = FILE_BROWSER.Url.ToString();
            }

            if (!FILE_BROWSER.CanGoBack)
                BACK_BUTTON.Enabled = false;
            else BACK_BUTTON.Enabled = true;

            if (!FILE_BROWSER.CanGoForward)
                FORWARD_BUTTON.Enabled = false;
            else FORWARD_BUTTON.Enabled = true;
        }

        private void FORWARD_BUTTON_Click(object sender, EventArgs e)
        {
            if (FILE_BROWSER.CanGoForward)
            {
                FILE_BROWSER.GoForward();
                ADDRESS_BAR.Text = FILE_BROWSER.Url.ToString();
            }


            if (!FILE_BROWSER.CanGoBack)
                BACK_BUTTON.Enabled = false;
            else BACK_BUTTON.Enabled = true;

            if (!FILE_BROWSER.CanGoForward)
                FORWARD_BUTTON.Enabled = false;
            else FORWARD_BUTTON.Enabled = true;
        }

        private void FILE_BROWSER_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ADDRESS_BAR.Text = FILE_BROWSER.Url.ToString().Replace("file:///", "");


            if (!FILE_BROWSER.CanGoBack)
                BACK_BUTTON.Enabled = false;
            else BACK_BUTTON.Enabled = true;

            if (!FILE_BROWSER.CanGoForward)
                FORWARD_BUTTON.Enabled = false;
            else FORWARD_BUTTON.Enabled = true;
        }
    }
}
