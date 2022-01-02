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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void pcbcuadroarea_Click(object sender, EventArgs e)
        {
            //mostrar cuadro
            panelcuadroarea.Visible = true;


        }

        private void pcbcirculoarea_Click(object sender, EventArgs e)
        {
            //mostrar circulo
            panelcirculo.Visible = true;
        }

        private void pcbtrianguloarea_Click(object sender, EventArgs e)
        {
            //mostrar triangulo
            paneltrianguloarea.Visible = true;
        }

        private void pcbrectanguloarea_Click(object sender, EventArgs e)
        {
            //mostrar rectangulo
            panelrectanguloarea1.Visible = true;

        }

        private void pcbpentagonoarea_Click(object sender, EventArgs e)
        {
            //mostrar pentagono
            panelpentagonoarea.Visible = true;
            

        }

        private void pcbtrapecioarea_Click(object sender, EventArgs e)
        {
            //mostrar trapecio
            paneltrapecioarea.Visible = true;

        }

        private void pcbromboarea_Click(object sender, EventArgs e)
        {
            //mostrar rombo
            panelromboarea.Visible = true;

        }

        private void btnarea1_Click(object sender, EventArgs e)
        {
            //area de rectangulo
            lblrectanguloarea.Text = (Convert.ToDouble(txtalturarectanguloarea.Text) * Convert.ToDouble(txtbaserectanguloarea.Text) + "cm²").ToString();
        }

        private void btnregresar1_Click(object sender, EventArgs e)
        {
            //ocultar rectangulo
            panelrectanguloarea1.Visible = false;
           
        }

        private void btncirculoarea_Click(object sender, EventArgs e)
        {
            //area de circulo
            lblcirculoarea.Text = ( 3.14 * (Convert.ToDouble(txtradio.Text)*Convert.ToDouble(txtradio.Text)) + "cm²").ToString();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ocultar circulo
            panelcirculo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //area del cuadro
            lblcuadrarea.Text = (Convert.ToDouble(txtcuadroarea.Text) * Convert.ToDouble(txtcuadroarea.Text) + "cm²").ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //area triangulo
            lbltrianguloarea.Text = (0.433* (Convert.ToDouble(txttrianguloarea.Text) * Convert.ToDouble(txttrianguloarea.Text)) + "cm²").ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ocultar triangulo
            paneltrianguloarea.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
             //ocultar trapecio
            paneltrapecioarea.Visible = false;

        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            //area trapecio
            lbltrapecioarea.Text = ((Convert.ToDouble(txttrapecioa.Text) + Convert.ToDouble(txttrapecioc.Text) / 2) * Convert.ToDouble(txttrapecioh.Text) + "cm²").ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ocultar rombo
            panelromboarea.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // area rombo
            lblromboarea.Text = ((Convert.ToDouble(txtromboD.Text) * Convert.ToDouble(txtromboareab.Text)) / 2 + "cm²").ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ocultar pentagono
            panelpentagonoarea.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //area pentagogono
            lblpentagonoarea.Text = (1.721 * (Convert.ToDouble(txtpentagonoarea.Text) * Convert.ToDouble(txtpentagonoarea.Text))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ocultar cuadro
            panelcuadroarea.Visible = false;
        }





     
    }
}
