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
    public partial class frmperimetros : Form
    {
        public frmperimetros()
        {
            InitializeComponent();
        }

        private void pcbcuadro_Click(object sender, EventArgs e)
        {
            //mostrar cuadro
           panelcuadro.Visible = true;
            
        }

        private void btnregresar1_Click(object sender, EventArgs e)
        { 
            //ocultar cuadro
            panelcuadro.Visible = false; 
        }

        private void pcbcirculo_Click(object sender, EventArgs e)
        {
            //mostrar circulo
            panelcirculo.Visible = true;
        }

        private void pcbtriangulo_Click(object sender, EventArgs e)
        {
            //mostrar triangulo
            paneltroangulo.Visible = true;
        }

        private void pcbrectangulo_Click(object sender, EventArgs e)
        {
            //mostrar rectangulo
            panelrectangulo.Visible = true;
        }

        private void pcbtrianguloisoceles_Click(object sender, EventArgs e)
        {
            //mostrar triangulo isoceles
            paneltriisoceles.Visible = true;
        }

        private void pcbtrianguloescaleno_Click(object sender, EventArgs e)
        {
            //mostrar triangulo escaleno
            paneltriescaleno.Visible = true;
        }

        private void pcbpentagono_Click(object sender, EventArgs e)
        {
            //mostar pentagono
            panelpentagono.Visible = true;
        }

        private void pcboctagono_Click(object sender, EventArgs e)
        {
            //mostrar octagono
            paneloctagono.Visible = true;
        }

        private void pcbtrapecio_Click(object sender, EventArgs e)
        {
            //mostrar trapecio
            paneltrapecio.Visible = true;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            //ocultar triangulo
            paneltroangulo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //perimetro del cuadro
            lblcuadro.Text = (Convert.ToDouble(txtcuadro.Text) * 4 + "cm").ToString();
        }

        private void btncirculo_Click(object sender, EventArgs e)
        {
            //perimetro circulo
            lblcirculo.Text = (Convert.ToDouble(txtcirculo.Text) * 3.14 + "cm").ToString();
        }

        private void btntriangulo_Click(object sender, EventArgs e)
        {
            //perimetro triangulo
            lbltriangulo.Text = (Convert.ToDouble(txttriangulo.Text) * 3 + "cm").ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //ocultar circulo
            panelcirculo.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //perimetro del rectangulo
            lblrectangulo.Text = (2*(Convert.ToDouble(txtalturarectangulo.Text)+ Convert.ToDouble(txtbaserectangulo.Text))+ "cm").ToString();

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            //ocultar rectangulo
            panelrectangulo.Visible = false;
        }

        private void btntriescaleno_Click(object sender, EventArgs e)
        {
            //perimetro de triangulo escaleno

            lbltriescaleno.Text = (Convert.ToDouble(txttriangulo_a.Text) + Convert.ToDouble(txttriangulo_b.Text) + Convert.ToDouble(txttriangulo_c.Text)+"cm").ToString();
        }

        private void btnregresar3_Click_1(object sender, EventArgs e)
        {
            //ocultar triangulo escaleno
            paneltriescaleno.Visible = false;
        }

        private void btnregresar4_Click(object sender, EventArgs e)
        {
            //ocultar triangulo isoceles
            paneltriisoceles.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //perimetro triangulo isoceles
            lbltriisoceles.Text = (Convert.ToDouble(txttriisoceles.Text) * 3 + "cm").ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // ocultar pentagono
            panelpentagono.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //perimetro del pentagono
            lblpentagono.Text = (Convert.ToDouble(txtpentagono_l.Text) * 5 + "cm").ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //oculta octagono
            paneloctagono.Visible = false;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //perimetro de octagono
            lbloctanogo.Text = (Convert.ToDouble(txtoctagono.Text) * 8 + "cm").ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ocultar trapecio
            paneltrapecio.Visible = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //perimetro trapecio
            lbltrapecio.Text = (Convert.ToDouble(txttra_a.Text) + Convert.ToDouble(txttra_b.Text) + Convert.ToDouble(txttra_b.Text) + Convert.ToDouble(txttra_c.Text)+"cm").ToString();
        }

        private void paneloctagono_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void frmperimetros_Load(object sender, EventArgs e)
        {

        }

      

      
    }
}
