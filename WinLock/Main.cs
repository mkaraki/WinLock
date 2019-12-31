using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLock
{
    public partial class Main : Form
    {
        Rectangle ScreenRect = Screen.PrimaryScreen.Bounds;

        public Main()
        {
            InitializeComponent();
        }

        public Main(string Message)
        { 
            InitializeComponent();
            MessageLabel.Text = Message;
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

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            WinLockPasswordUtils.AskPassword apass = new WinLockPasswordUtils.AskPassword("WinLock (ControlLock)", true);
            apass.ShowDialog();

            if (!apass.Result)
            {
                MessageBox.Show("Access Denied");
                return;
            }
            InternalShared.IsClosable = true;
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Hide();

            WinLockPasswordUtils.AskPassword apass = new WinLockPasswordUtils.AskPassword("WinLock (ControlLock)", false);
            apass.ShowDialog();

            if (!apass.Result)
            {
                MessageBox.Show("Access Denied");
                InternalShared.IsClosable = true;
                Close();
            }
            else
            {
                Show();
            }
        }
    }
}
