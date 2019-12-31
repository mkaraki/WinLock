using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Misuzilla.Security;

namespace WinLockPasswordUtils
{
    public partial class AskPassword : Form
    {
        public bool Result { get; set; } = false;

        private bool SkipAuth = false;

        private int TryCount = 0;

        private readonly bool UseLegacy = false;

        public AskPassword(string ApplicationName, bool UseLegacy = false)
        {
            InitializeComponent();
            ApplicationName = '"' + ApplicationName + '"';
            this.UseLegacy = UseLegacy;
            lbl_appdata.Text = ApplicationName + " wanted to access WinLock Service";
        }

        private void AskPassword_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string uid = "OneTimeUser" + rnd.Next(0, int.MaxValue).ToString().PadLeft(10, '0');

            if (!PasswordTools.IsPasswordSet())
            {
                Result = true;
                label1.Visible = false;
                tbox_pass.Visible = false;

                SkipAuth = true;
            }

            tbox_uid.Text = uid;
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (SkipAuth)
            { 
                Result = true;
                Close();
            }

            bool res = PasswordTools.Check(tbox_pass.Text);
            if (res)
            {
                Result = true;
                Close();
            }
            else
            {
                Result = false;
                TryCount++;

                label1.Text = "WRONG PASSWORD";
                label1.ForeColor = Color.Red;
                tbox_pass.Text = "";
            }

            if (TryCount > 3)
            {
                label1.Text = "ACCESS DENIED";
                tbox_pass.ReadOnly = true;
                btn_accept.Enabled = false;
                Result = false;
            }
        }

        private void AskPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_deny_Click(object sender, EventArgs e)
        {
            Result = false;
            Close();
        }

        private void AskPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void tbox_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
