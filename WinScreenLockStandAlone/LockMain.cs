using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinLockStandAlone
{
    public partial class LockMain : Form
    {
        private Rectangle ScreenRect = Screen.PrimaryScreen.Bounds;

        private string LockPassword { get; set; }

        public LockMain()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!InternalShared.IsClosable)
                e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = ScreenRect.X;
            this.Top = ScreenRect.Y;

            this.Width = ScreenRect.Width;
            this.Height = ScreenRect.Height;

            this.WindowState = FormWindowState.Maximized;
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void Main_Leave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            foreach (var scr in Screen.AllScreens)
            {
                if (scr.Primary) continue;

                var rect = scr.Bounds;

                ScrLock lockscr = new ScrLock(rect.X, rect.Y, rect.Width, rect.Height);

                lockscr.Show();
            }
        }

        /// <summary>
        /// Unlock Process
        /// </summary>
        private void btn_unlock_Click(object sender, EventArgs e)
        {
            PasswordPrompt passf = new PasswordPrompt("What is your password?");
            passf.ShowDialog();

            if (passf.ResultPassword != LockPassword)
            {
                MessageBox.Show("Access Denied", "WinLock");
                return;
            }
            InternalShared.IsClosable = true;
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Hide();

            PasswordPrompt passf = new PasswordPrompt("Set your password.");
            passf.ShowDialog();

            if (passf.ResultPassword == null)
            {
                MessageBox.Show("Password is required.", "WinLock");
                InternalShared.IsClosable = true;
                Close();
            }
            else
            {
                LockPassword = passf.ResultPassword;
                Show();
            }
        }
    }
}