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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private double CalcularMontoAcumulado(double depositoInicial, int meses)
        {
            double tasaAnual;
            int anios = meses / 12;

            switch (meses)
            {
                case 12:
                    tasaAnual = 0.04;
                    break;
                case 24:
                    tasaAnual = 0.045;
                    break;
                case 36:
                    tasaAnual = 0.0455;
                    break;
                case 48:
                    tasaAnual = 0.0475;
                    break;
                case 60:
                    tasaAnual = 0.05;
                    break;
                default:
                    return 0;
            }

            return depositoInicial * Math.Pow(1 + tasaAnual, anios);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double montoInicial) && !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtCedula.Text) && cmbPlazo.SelectedItem != null)
            {
                if (montoInicial >= 2000.00)
                {
                    int meses = int.Parse(cmbPlazo.SelectedItem.ToString());
                    double montoAcumulado = CalcularMontoAcumulado(montoInicial, meses);
                    // Reemplaza lblResultado con el nombre de tu control para mostrar el resultado
                    lblResultado.Text = $"Hola {txtNombre.Text}, el monto acumulado al final del plazo será de B/{montoAcumulado:N2}";
                }
                else
                {
                    MessageBox.Show("El depósito mínimo para abrir la cuenta es de B/2000.00", "Monto Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos para el cálculo.", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ValidarCampos()
        {
            bool camposLlenos = !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                                !string.IsNullOrWhiteSpace(txtCedula.Text) &&
                                !string.IsNullOrWhiteSpace(txtMonto.Text) &&
                                cmbPlazo.SelectedItem != null;

            btnCalcular.Enabled = camposLlenos;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void cmbPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnterior3_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Formulario 2
            Form2 form2 = new Form2();
            // Mostrar el Formulario 2
            form2.Show();
            // Ocultar el Formulario 3
            this.Hide();
        }

        private void cmbPlazo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
