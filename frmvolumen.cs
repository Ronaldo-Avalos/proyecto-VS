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
    public partial class frmvolumen : Form
    {
        public frmvolumen()
        {
            InitializeComponent();
        }

     

        private void pcbcubo_Click(object sender, EventArgs e)
        {
            panelcubo.Visible = true;

        }

        private void btntriescaleno_Click(object sender, EventArgs e)
        {
            //volumen cubo
            lblcubo.Text = (Math.Pow(Convert.ToDouble(txtcubo.Text), 3) + "cm³").ToString();

        }

        private void pcbesfera_Click(object sender, EventArgs e)
        {
            //mostrar esfera
            panelesfera.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //volumen esfera
            lblesfera.Text = ((0.75) * (3.14) * (Math.Pow(Convert.ToDouble(txtesfera.Text), 3)) + "cm³").ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ocultar esfera
            panelesfera.Visible = false;

        }

        private void btnregresar3_Click(object sender, EventArgs e)
        {
            //ocultar cubo
            panelcubo.Visible = false;
        }

  

        private void pcbpentagonoarea_Click(object sender, EventArgs e)
        {
            //mostrar cilindro
            panelcilindro.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ocultar cilindro
            panelcilindro.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            lblcilindro.Text = ((3.14) * (Math.Pow(Convert.ToDouble(txtradioc.Text), 2) * Convert.ToDouble(txtalturac.Text)) + "cm³").ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ocultar piramide
            panelpiramide.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //volumen piramide
            lblpiramide.Text = ((0.33) * Convert.ToDouble(txtbase.Text) * Convert.ToDouble(txtaltura.Text) + "cm³").ToString();
        }

        private void pcpbpiramide_Click_1(object sender, EventArgs e)
        {
            //mostrar piramide
            panelpiramide.Visible = true;

        }

  
    }
}
