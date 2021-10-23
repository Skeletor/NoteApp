using System.Windows.Forms;
using System.Diagnostics;

namespace NoteAppUI
{
    /// <summary>
    /// Форма, отображающая информацию о программе, создателе и пр.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Переменная, показывающая, отображена ли форма
        /// </summary>
        public static bool IsShown { get; private set; }

        /// <summary>
        /// Происходит при создании нового экземпляра формы
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
            IsShown = true;
        }

        /// <summary>
        /// При клике переводит на репозиторий кода в гит хабе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("https://github.com/Skeletor/NoteApp/");
        
        /// <summary>
        /// При клике переводит на домашнюю страницу mail.ru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("https://mail.ru/");

        /// <summary>
        /// Происходит при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e) => IsShown = false;
    }
}
