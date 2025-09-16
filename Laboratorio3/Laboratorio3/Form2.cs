using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            btnMostrarPalindromos.Enabled = false;
        }
        private bool EsPalindromo(int numero)
        {
            // Los números negativos no son palíndromos
            if (numero < 0)
            {
                return false;
            }

            string s = numero.ToString();
            string reverso = new string(s.Reverse().ToArray());
            return s.Equals(reverso);
        }
        private void btnMostrarPalindromos_Click(object sender, EventArgs e)
        {
          

            if (int.TryParse(txtInicioRango.Text, out int inicio) && int.TryParse(txtFinRango.Text, out int fin))
            {
                if (inicio >= 0 && fin >= inicio)
                {
                    lbPalindromos.Items.Clear();
                    for (int i = inicio; i <= fin; i++)
                    {
                        if (EsPalindromo(i))
                        {
                            lbPalindromos.Items.Add(i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El rango debe ser válido y no contener números negativos.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos en el rango.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Formulario 2
            Form3 form3 = new Form3();
            // Mostrar el Formulario 2
            form3.Show();
            // Ocultar el Formulario 1
            this.Hide();
        }

        private void btnAnterior3_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Formulario 2
            Form1 form1 = new Form1();
            // Mostrar el Formulario 2
            form1.Show();
            // Ocultar el Formulario 3
            this.Hide();
        }

       // metodo para 
        private void VerificarCampos()
        {
         
            btnMostrarPalindromos.Enabled = !string.IsNullOrWhiteSpace(txtInicioRango.Text) && !string.IsNullOrWhiteSpace(txtFinRango.Text);
        
        }
        
        private void txtInicioRango_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void txtFinRango_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

       
    }
}
