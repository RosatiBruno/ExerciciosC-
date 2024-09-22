using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, resultado;
            
            bool alturaValida = double.TryParse(txtAltura.Text, out altura);
            bool pesoValido = double.TryParse(txtPeso.Text, out peso);

            resultado = peso / (altura * altura);

            if (resultado < 18.5)
            {
                txtResultado.Text = "Abaixo do peso";
                txtSeuIMC.Text = resultado.ToString("F2");
            }
            else if (resultado >= 18.5 && resultado <= 24.9)
            {
                txtResultado.Text = ("Peso ideal");
                txtSeuIMC.Text = resultado.ToString("F2");
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                txtResultado.Text = ("Levemente acima do peso");
                txtSeuIMC.Text = resultado.ToString("F2");
            }
            else if (resultado >= 30 && resultado <= 34.9)
            {
                txtResultado.Text = ("Obesidade grau I");
                txtSeuIMC.Text = resultado.ToString("F2");
            }
            else if (resultado >= 35 && resultado <= 39.9)
            {
                txtResultado.Text = ("Obesidade grau II (Severa)");
                txtSeuIMC.Text = resultado.ToString("F2");
            }
            else if (resultado >= 40)
            {
                txtResultado.Text = ("Obesidade grau III (Mórbida)");
                txtSeuIMC.Text = resultado.ToString("F2");
            }
        }
    }
}