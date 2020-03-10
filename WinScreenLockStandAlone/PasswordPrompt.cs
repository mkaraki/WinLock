using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLockStandAlone
{
    public partial class PasswordPrompt : Form
    {
        public PasswordPrompt(string Text = "Password")
        {
            InitializeComponent();
            lbl_pwask.Text = Text;
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            ResultPassword = tbox_pass.Text;
            if (ResultPassword == string.Empty)
                ResultPassword = null;
            Close();
        }

        public string ResultPassword { get; private set; } = null;
    }
}
