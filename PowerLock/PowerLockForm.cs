using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLock
{
    public partial class PowerLockForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ShutdownBlockReasonCreate(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] string reason);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ShutdownBlockReasonDestroy(IntPtr hWnd);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int SetProcessShutdownParameters(int dwLevel, int dwFlags);

        private bool ForceQuit = false;

        public PowerLockForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinLockPasswordUtils.AskPassword apass = new WinLockPasswordUtils.AskPassword("PowerLock");
            apass.ShowDialog();

            if (!apass.Result)
            {
                MessageBox.Show("Access Denied");
                ForceQuit = true;
                Close();
                return;
            }

            SetProcessShutdownParameters(0x4FF, 0);
            ShutdownBlockReasonCreate(this.Handle, "Shutdown is Blocked by Owner");
            SystemEvents.SessionEnding += SystemEvents_SessionEnding;
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShutdownBlockReasonDestroy(this.Handle);
            SystemEvents.SessionEnding -= SystemEvents_SessionEnding;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PowerLockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ForceQuit) return;

            WinLockPasswordUtils.AskPassword apass = new WinLockPasswordUtils.AskPassword("PowerLock");
            apass.ShowDialog();

            if (!apass.Result)
            {
                MessageBox.Show("Access Denied");
                e.Cancel = true;
            }
        }
    }
}
