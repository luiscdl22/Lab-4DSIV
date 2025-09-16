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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ContarVocales(string palabra)
        {
            // Limpiar el ListView antes de agregar nuevos resultados
            lvVocales.Items.Clear();

            // Convertir la palabra a minúsculas para un conteo no sensible a mayúsculas
            palabra = palabra.ToLowerInvariant();

            // Definir las vocales, incluyendo tildes y diéresis
            char[] vocales = { 'a', 'á', 'ä', 'e', 'é', 'ë', 'i', 'í', 'ï', 'o', 'ó', 'ö', 'u', 'ú', 'ü' };

            // Crear un diccionario para almacenar el conteo de cada vocal
            var conteoVocales = new Dictionary<char, int>();
            foreach (char vocal in vocales)
            {
                conteoVocales[vocal] = 0;
            }

            // Recorrer la palabra y contar las vocales
            foreach (char c in palabra)
            {
                if (conteoVocales.ContainsKey(c))
                {
                    conteoVocales[c]++;
                }
            }

            // Llenar el ListView con los resultados
            foreach (var item in conteoVocales)
            {
                if (item.Value > 0)
                {
                    var listViewItem = new ListViewItem(item.Key.ToString());
                    listViewItem.SubItems.Add(item.Value.ToString());
                    lvVocales.Items.Add(listViewItem);
                }
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            
            string palabraIngresada = txtPalabra.Text;
            if (!string.IsNullOrWhiteSpace(palabraIngresada))
            {
                ContarVocales(palabraIngresada);
            }
        
    }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {
           
            btnContar.Enabled = !string.IsNullOrWhiteSpace(txtPalabra.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Formulario 2
            Form2 form2 = new Form2();
            // Mostrar el Formulario 2
            form2.Show();
            // Ocultar el Formulario 1
            this.Hide();
        }

        private void lvVocales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
