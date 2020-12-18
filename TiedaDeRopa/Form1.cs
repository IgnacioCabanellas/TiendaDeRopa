using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiedaDeRopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.panelLeft.Width == 250)
            {
                this.panelLeft.Width = 70;
            }
            else
            {
                this.panelLeft.Width = 250;
                //250; 603
            }
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picAgrandar_Click(object sender, EventArgs e)
        {
            this.picAgrandar.Visible = false;
            this.picAchicar.Visible = true;

            this.WindowState = FormWindowState.Maximized;
        }

        private void picAchicar_Click(object sender, EventArgs e)
        {
            this.picAchicar.Visible = false;
            this.picAgrandar.Visible = true;

            this.WindowState = FormWindowState.Normal;
        }
    }
}
