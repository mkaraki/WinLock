using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLockPasswordUtils
{
    public partial class PassMan : Form
    {
        private int Try = 0;

        public PassMan()
        {
            InitializeComponent();
        }

        private void PassMan_Load(object sender, EventArgs e)
        {
            AskPassword apass = new AskPassword("WinLock Password Manager");
            apass.ShowDialog();

            if (!apass.Result)
            {
                MessageBox.Show("Access Denied", "WinLock Password Manager");
                Close();
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (tbox_pass.Text != tbox_rpass.Text)
            {
                MessageBox.Show("Password didn't match");
                return;
            }

            PasswordTools.SetPassword(tbox_pass.Text);

            var v =  PasswordTools.Check(tbox_pass.Text);

            if (v)
            {
                MessageBox.Show("Complete");
                Close();
            }
            else if (Try > 5)
            { 
                MessageBox.Show("ERROR: CRITICAL ERROR FOUND. USE PASSWORD RESCUE TOOL.");
                return;
            }
            else
            {
                btn_change_Click(null, null);
            }
        }
    }
}
