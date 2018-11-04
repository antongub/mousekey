using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mousekey
{
    public partial class FmMain : Form
    {

        public Point moveMouseLocation;


        public FmMain()
        {
            InitializeComponent();
        }

        private void BtnCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            moveMouseLocation = new Point(-e.X, -e.Y);
        }

        private void PnTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(moveMouseLocation.X, moveMouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
