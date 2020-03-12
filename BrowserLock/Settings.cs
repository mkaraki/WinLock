using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserLock
{
    public partial class Settings : Form
    {
        private List<string> DeniedApps;

        public Settings(List<string> DA)
        {
            InitializeComponent();

            DeniedApps = DA;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbox_appname.Text != "")
                lbox_apps.Items.Add(tbox_appname.Text);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lbox_apps.SelectedItem != null)
                lbox_apps.Items.RemoveAt(lbox_apps.SelectedIndex);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeniedApps.Clear();
            foreach (string v in lbox_apps.Items)
            {
                if (DeniedApps.Contains(v)) continue;
                DeniedApps.Add(v);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (string v in DeniedApps)
            {
                lbox_apps.Items.Add(v);
            }
        }

        private void lbox_apps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
