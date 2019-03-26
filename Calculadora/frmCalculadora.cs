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
            if (lblDisplay.Text == string.Empty)
            {
                lblDisplay.Text += btn0.Text;
                if (lblDisplay.Text.Substring(0, 1) != "0")
                {
                    lblDisplay.Text = btn0.Text;
                }
                else
                {
                    lblDisplay.Text = btn0.Text;
                }
            }
            else if(lblDisplay.Text.Contains("1") || lblDisplay.Text.Contains("2") || lblDisplay.Text.Contains("3") || lblDisplay.Text.Contains("4") || lblDisplay.Text.Contains("5") ||
                lblDisplay.Text.Contains("6") || lblDisplay.Text.Contains("7") || lblDisplay.Text.Contains("8") || lblDisplay.Text.Contains("9") || lblDisplay.Text.Contains(","))
            {
                lblDisplay.Text += btn0.Text;
            }
            else
            {
                lblDisplay.Text = string.Empty;
                lblDisplay.Text += btn0.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn1.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn1.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn1.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn2.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn2.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn2.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn3.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn3.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn3.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn4.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn4.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn4.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn5.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn5.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn5.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn6.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn6.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn6.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn7.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn7.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn7.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn8.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn8.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn8.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn8.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != string.Empty)
            {
                if (lblDisplay.Text.Substring(0, 1) == "0")
                {
                    if (lblDisplay.Text.Contains(","))
                    {
                        lblDisplay.Text += btn9.Text;
                    }
                    else
                    {
                        lblDisplay.Text = btn9.Text;
                    }
                }
                else
                {
                    lblDisplay.Text += btn9.Text;
                }
            }
            else
            {
                lblDisplay.Text += btn9.Text;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            int x = lblDisplay.Text.IndexOf(",");

            if (x >= 0) return;
            else lblDisplay.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = string.Empty;
            lblResultado.Text = string.Empty;
            n1 = 0;
            n2 = 0;
            resultado = 0;
            sinal = 0;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int x = lblDisplay.Text.Length - 1;
            if (x >= 0)
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, x);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if(resultado == 0)
            {
                try
                {
                    n1 = Convert.ToDouble(lblDisplay.Text);
                    lblResultado.Text = lblDisplay.Text + " + ";
                    lblDisplay.Text = string.Empty;
                    sinal = 1;
                }
                catch (Exception ex)
                {
                    n1 = 0;
                    lblResultado.Text = n1.ToString() + " + ";
                    lblDisplay.Text = string.Empty;
                    sinal = 1;
                }   
            }
            else
            {
                n1 = Convert.ToDouble(lblResultado.Text.Remove(0, 2));
                lblResultado.Text = lblResultado.Text.Replace("= ", "") + " + ";
                lblDisplay.Text = string.Empty;
                sinal = 1;
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                try
                {
                    n1 = Convert.ToDouble(lblDisplay.Text);
                    lblResultado.Text = lblDisplay.Text + " - ";
                    lblDisplay.Text = string.Empty;
                    sinal = 2;
                }
                catch (Exception ex)
                {
                    n1 = 0;
                    lblResultado.Text = n1.ToString() + " - ";
                    lblDisplay.Text = string.Empty;
                    sinal = 2;
                }
            }
            else
            {
                n1 = Convert.ToDouble(lblResultado.Text.Remove(0, 2));
                lblResultado.Text = lblResultado.Text.Replace("= ", "") + " - ";
                lblDisplay.Text = string.Empty;
                sinal = 2;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                try
                {
                    n1 = Convert.ToDouble(lblDisplay.Text);
                    lblResultado.Text = lblDisplay.Text + " x ";
                    lblDisplay.Text = string.Empty;
                    sinal = 3;
                }
                catch (Exception ex)
                {
                    n1 = 0;
                    lblResultado.Text = n1.ToString() + " x ";
                    lblDisplay.Text = string.Empty;
                    sinal = 3;
                }
            }
            else
            {
                n1 = Convert.ToDouble(lblResultado.Text.Remove(0, 2));
                lblResultado.Text = lblResultado.Text.Replace("= ", "") + " x ";
                lblDisplay.Text = string.Empty;
                sinal = 3;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (resultado == 0)
            {
                try
                {
                    n1 = Convert.ToDouble(lblDisplay.Text);
                    lblResultado.Text = lblDisplay.Text + " / ";
                    lblDisplay.Text = string.Empty;
                    sinal = 4;
                }
                catch (Exception ex)
                {
                    n1 = 0;
                    lblResultado.Text = n1.ToString() + " / ";
                    lblDisplay.Text = string.Empty;
                    sinal = 4;
                }
            }
            else
            {
                n1 = Convert.ToDouble(lblResultado.Text.Remove(0, 2));
                lblResultado.Text = lblResultado.Text.Replace("= ", "") + " x ";
                lblDisplay.Text = string.Empty;
                sinal = 4;
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(lblDisplay.Text.Trim());
            if (sinal == 1)
            {
                resultado = n1 + (n1 * n2 / 100);
                positivoNegativo();
                lblResultado.Text = "= " + resultado.ToString("N2");
                lblDisplay.Text = string.Empty;
            }
            else if(sinal == 2)
            {
                resultado = n1 - (n1 * n2 / 100);
                positivoNegativo();
                lblResultado.Text = "= " + resultado.ToString("N2");
                lblDisplay.Text = string.Empty;
            }
            else if (sinal == 3)
            {
                resultado = n1 * (n2 / 100);
                positivoNegativo();
                lblResultado.Text = "= " + resultado.ToString("N2");
                lblDisplay.Text = string.Empty;
            }
            else if (sinal == 4)
            {
                resultado = n1 / (n2 / 100);
                positivoNegativo();
                lblResultado.Text = "= " + resultado.ToString("N2");
                lblDisplay.Text = string.Empty;
            }
            n1 = 0;
            n2 = 0;
            sinal = 0;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = double.Parse(lblDisplay.Text.Trim());

                if (sinal == 1)
                {
                    resultado = n1 + n2;
                    positivoNegativo();
                    n1 = 0;
                    n2 = 0;
                    sinal = 0;
                }

                else if (sinal == 2)
                {
                    resultado = n1 - n2;
                    positivoNegativo();
                    n1 = 0;
                    n2 = 0;
                    sinal = 0;
                }
                else if (sinal == 3)
                {
                    resultado = n1 * n2;
                    positivoNegativo();
                    n1 = 0;
                    n2 = 0;
                    sinal = 0;
                }
                else if (sinal == 4)
                {
                    if(n2 != 0)
                    {
                        resultado = n1 / n2;
                        positivoNegativo();
                        n1 = 0;
                        n2 = 0;
                        sinal = 0;
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel dividir por 0!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblResultado.Text = n1.ToString() + " / ";
                        lblDisplay.Text = string.Empty;
                        sinal = 4;
                    } 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operção inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblDisplay_TextChanged(object sender, EventArgs e)
        {
            int x = lblDisplay.Text.Length-1;
            if (x >= 12)
            {
                MessageBox.Show("Número máximo de digitos atingido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDisplay.Text = lblDisplay.Text.Substring(0, x);
            }
        }

        private void positivoNegativo()
        {
            if (resultado == 0)
            {
                lblResultado.ForeColor = Color.Black;
                contemDecimal();
                lblDisplay.Text = string.Empty;
            }
            else if (resultado > 0)
            {
                lblResultado.ForeColor = Color.Green;
                contemDecimal();
                lblDisplay.Text = string.Empty;
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                contemDecimal();
                lblDisplay.Text = string.Empty;
            }
        }

        private void contemDecimal()
        {
            if (lblDisplay.Text.Contains(",") || resultado.ToString().Contains(","))
            {
                lblResultado.Text = "= " + resultado.ToString("N2");
            }
            else
            {
                lblResultado.Text = "= " + resultado.ToString("N0");
            }
        }
    }
}
