using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        private double n1 = 0;
        private double n2 = 0;
        private double resultado = 0;
        private int sinal = 0;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "9";
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if(resultado == 0)
            {
                n1 = double.Parse(lblDisplay.Text.Trim());
                lblResultado.Text = lblDisplay.Text + " + ";
                lblDisplay.Text = string.Empty;
                sinal = 1;
            }
            else
            {
                n1 = double.Parse(lblResultado.Text.Replace("= ", ""));
                lblResultado.Text = lblResultado.Text.Replace("= ", "") + " + ";
                lblDisplay.Text = string.Empty;
                sinal = 1;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(lblDisplay.Text.Trim());

            if (sinal == 1)
            {
                resultado = n1 + n2;
                lblResultado.Text = "= " + resultado.ToString();
                lblDisplay.Text = string.Empty;
            }
            n1 = 0;
            n2 = 0;
            sinal = 0;
            
        }
    }
}
