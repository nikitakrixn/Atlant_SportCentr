using System;
using System.Drawing;
using System.Windows.Forms;

namespace PopupEffect
{
    public partial class transparentBg : Form
    {
        Form _child = null;

        public transparentBg(UserControl parent, Form child)
        {
            InitializeComponent();
            _child = child;

            this.Location = parent.Location;
            this.Size = parent.Size = new Size(1296, 655);
            this.ShowDialog();
        }
        public transparentBg(Form child)
        {
            InitializeComponent();
            _child = child;
            this.WindowState = FormWindowState.Maximized;
            this.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            formLauncher.Stop();
            _child.ShowDialog();
            this.Close();
        }
    }
}
