using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculosGeometricos
{
    public partial class frmcalculos : Form
    {
        public frmcalculos()
        {
            InitializeComponent();
        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            Form fr1 = new frmperimetros();

            fr1.Show();


        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            Form fr2 = new frmArea();

            fr2.Show();

        }

        private void btnvolumen_Click(object sender, EventArgs e)
        {

            Form fr3 = new frmvolumen();

            fr3.Show();
        }

        private void btnperimetro_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
