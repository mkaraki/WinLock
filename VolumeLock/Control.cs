using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace VolumeLock
{
    public partial class Control : Form
    {
        private MMDevice AudioDevice;

        private bool Locked = false;

        public Control()
        {
            InitializeComponent();

            var mme = new MMDeviceEnumerator();
            AudioDevice = mme.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            volumeBar.Value = (int)(AudioDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0f);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AudioDevice.AudioEndpointVolume.MasterVolumeLevelScalar = ((float)volumeBar.Value / 100.0f);
        }

        private void btn_lock_unlock_Click(object sender, EventArgs e)
        {
            WinLockPasswordUtils.AskPassword apass = new WinLockPasswordUtils.AskPassword("VolumeLock");
            apass.ShowDialog();

            if (!apass.Result)
            {
                MessageBox.Show("Access Denied");
                return;
            }

            if (Locked)
            {
                btn_lock_unlock.Text = "Lock";
                volumeBar.Enabled = true;
                btn_exit.Enabled = true;
                Locked = false;
            }
            else
            { 
                btn_lock_unlock.Text = "Unlock";
                volumeBar.Enabled = false;
                btn_exit.Enabled = false;
                Locked = true;
            }
        }

        private void Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Locked)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Control_Load(object sender, EventArgs e)
        {

        }
    }
}
