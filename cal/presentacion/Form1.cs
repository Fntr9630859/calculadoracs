using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejecuta_Click_1(object sender, EventArgs e)
        {
            double res = 0;
            if (double.TryParse(dato1.Text, out double d1) && double.TryParse(dato2.Text, out double d2))
            {
                char op = operacion.Text[0];

                switch (op)
                {
                    case '+':
                        // Sumar los valores
                        res = d1 + d2;
                        break;
                    case '-':
                        // Sumar los valores
                        res = d1 - d2;
                        break;
                    case '*':
                        // Sumar los valores
                        res = d1 * d2;
                        break;
                    case '/':
                        // Sumar los valores
                        if (d1 !=0 && d2 != 0)
                        {
                        res = d1 / d2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir entre 0");
                        }
                        break;
                    default:
                        MessageBox.Show("Ingrese una operación valida");
                        break;
                }
                // Mostrar el resultado en el TextBox correspondiente
                resultado.Text = res.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese números válidos en los TextBox.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operacion.SelectedIndex = 0;
        }
    }
}
