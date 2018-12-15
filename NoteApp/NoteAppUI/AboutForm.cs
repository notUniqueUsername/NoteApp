using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ссылка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/notUniqueUsername/NoteApp");

        }
        /// <summary>
        /// Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Mailto:muternatallia@gmail.com");
        }
    }
}
