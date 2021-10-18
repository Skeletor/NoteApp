using System.Windows.Forms;
using System.Diagnostics;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public static bool isShown
        {
            get; private set;
        }

        public AboutForm()
        {
            InitializeComponent();
            isShown = true;
        }

        private void GitHubLinkLabel__LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("https://github.com/Skeletor/NoteApp/");
        

        private void LinkLabel__LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("https://mail.ru/");

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e) => isShown = false;
    }
}
