using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    public partial class FormularioArreglo : Form
    {
        public string Nombre { get; set; }
        public string Precios { get; set; }
        public FormularioArreglo()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxNombre.Text) && double.TryParse(txtBoxPrecio.Text, out double precios))
            {
                Nombre = txtBoxNombre.Text;
                Precios = precios.ToString();

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido y un precio numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var evento = MessageBox.Show("¿Estás seguro que desea cancelar el agregado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (evento == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
                e.Handled = true;
            string newText =
                textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength)
                .Insert(textBox.SelectionStart, e.KeyChar.ToString());
            if (!Regex.IsMatch(newText, @"^\d{0,4}(\.\d{0,2})?$"))
                e.Handled = true;
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Focus();
        }

        private void NombreProducto_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Focus();
        }
    }
}
