using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BrowserLock
{
    public partial class Watcher : Form
    {
        private new bool Enabled = false;

        private List<string> DeniedApplications = new List<string>() { 
            "iexplore", 
            "MicrosoftEdge",
            "MicrosoftEdgeCP",
            "chrome",
            "firefox",
        };

        public Watcher()
        {
            InitializeComponent();
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            WinLockPasswordUtils.AskPassword apass = new WinLockPasswordUtils.AskPassword("PowerLock");
            apass.ShowDialog();

            if (!apass.Result)
            {
                MessageBox.Show("Access Denied");
                return;
            }

            if (!Enabled)
            {
                Enabled = true;
                timer1.Enabled = true;
                btn_setting.Enabled = false;
                btn_enable.Text = "Disable";
            }
            else
            {
                Enabled = false;
                timer1.Enabled = false;
                btn_setting.Enabled = true;
                btn_enable.Text = "Enable";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcesses();
            var tokill = procs.Where(v => DeniedApplications.Contains(v.ProcessName));
            foreach (var proc in tokill)
            {
                try
                {
                    proc.Kill();
                }
                catch { }

                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void Watcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Enabled)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings(DeniedApplications);
            setting.ShowDialog();
        }

        private void Watcher_Load(object sender, EventArgs e)
        {

        }
    }
}
