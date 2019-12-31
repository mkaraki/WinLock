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
    public partial class ScrLock : Form
    {
        private int OX;
        private int OY;
        private int OW;
        private int OH;

        public ScrLock(int X, int Y, int Width, int Height)
        {
            InitializeComponent();

            this.Left = X;
            this.Top = Y;

            this.Width = Width;
            this.Height = Height;

            OX = X;
            OY = Y;
            OW = Width;
            OH = Height;
        }

        private void ScrLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!InternalShared.IsClosable)
                e.Cancel = true;
        }

        private void ScrLock_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = OX;
            this.Top = OY;

            this.Width = OW;
            this.Height = OH;
         
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
