using System;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Figuras : Form
    {
        public Figuras()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnCCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadio.Text, out double radio))
            {
                Circulo oCirculo = new Circulo();
                oCirculo.Radio = Convert.ToDouble(txtRadio.Text.Trim());

                lblCArea.Text = "Área del Círculo: " + oCirculo.area().ToString("F2");
                lblCPerimetro.Text = "Perímetro del Círculo: " + oCirculo.perimetro().ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el radio del círculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out double altura) &&
                double.TryParse(txtBase.Text, out double bases))
            {
                
                Rectangulo oRectangulo = new Rectangulo();
                oRectangulo.Altura = altura;
                oRectangulo.Bases = bases;

                
                double area = oRectangulo.area();
                double perimetro = oRectangulo.perimetro();

                //JAREDBASTARRACHEA
                lblRArea.Text = "Área: " + area.ToString("F2");
                lblRPerimetro.Text = "Perímetro: " + perimetro.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para la altura y la base del rectángulo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseTriangulo) &&
                double.TryParse(txtAltura.Text, out double altura) &&
                double.TryParse(txtLado1.Text, out double lado1) &&
                double.TryParse(txtLado2.Text, out double lado2) &&
                double.TryParse(txtLado3.Text, out double lado3))
            {
                Triangulo oTriangulo = new Triangulo();
                oTriangulo.BaseTriangulo = baseTriangulo;
                oTriangulo.Altura = altura;
                oTriangulo.Lado1 = lado1;
                oTriangulo.Lado2 = lado2;
                oTriangulo.Lado3 = lado3;

                double area = oTriangulo.area();
                double perimetro = oTriangulo.perimetro();

                lblTArea.Text = "Área: " + area.ToString("F2");
                lblTPerimetro.Text = "Perímetro: " + perimetro.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para la base, altura y lados del triángulo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCUCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLado.Text, out double ladoCuadrado))
            {
                Cuadrado oCuadrado = new Cuadrado();
                oCuadrado.Lado = ladoCuadrado;

                double area = oCuadrado.area();
                double perimetro = oCuadrado.perimetro();

                lblCUArea.Text = "Área: " + area.ToString("F2");
                lblCUPerimetro.Text = "Perímetro: " + perimetro.ToString("F2");
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el lado del cuadrado.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void Figuras_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.AccessibleName = "btnCuadrado";
            button2.AccessibleName = "btnRectangulo";
            button3.AccessibleName = "btnTriangulo";
            button4.AccessibleName = "btnCirculo";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

