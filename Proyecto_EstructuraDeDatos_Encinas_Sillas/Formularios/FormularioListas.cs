using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    public partial class FormularioListas : Form
    {
        AlimentoParaMascotas Alimento = new AlimentoParaMascotas();
        public FormularioListas()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            comboBoxRazas.Focus();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var evento = MessageBox.Show("¿Esta seguro que desea cancelar el agregado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (evento == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void RazaDeMascota_Click(object sender, EventArgs e)
        {
            comboBoxRazas.Focus();
        }

        private void NombreAlimento_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Focus();
        }

        private void PrecioAlimento_Click(object sender, EventArgs e)
        {
            txtBoxPrecio.Focus();
        }

        private void Existencia_Click(object sender, EventArgs e)
        {
            radioBtnSi.Select();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text == string.Empty || comboBoxRazas.Text == string.Empty || txtBoxPrecio.Text == string.Empty)
            {
                MessageBox.Show("Necesitas Ingresar todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    double validacionPrecio = double.Parse(txtBoxPrecio.Text);
                    if (radioBtnSi.Checked)
                    {
                        Alimento.Existencia = true;
                        Alimento.Precio = validacionPrecio;
                        Alimento.NombreAlimento = txtBoxNombre.Text;
                        Alimento.RazaMascota = comboBoxRazas.Text;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Alimento.Existencia = false;
                        Alimento.Precio = validacionPrecio;
                        Alimento.NombreAlimento = txtBoxNombre.Text;
                        Alimento.RazaMascota = comboBoxRazas.Text;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch
                {
                    MessageBox.Show("Solo se aceptan datos númericos en el precio", "Error De Dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public AlimentoParaMascotas AgregarAlimento()
        {
            return Alimento;
        }

        private void txtBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Metodo para permitir teclas de control
            // como borrar
            if (char.IsControl(e.KeyChar))
                e.Handled = false;

            // Permitir solo dígitos y un separador decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // Asegurarse de que solo haya un separador decimal
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
                e.Handled = true;

            // Obtener el texto después de insertar el carácter
            string newText = 
                textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength)
                .Insert(textBox.SelectionStart, e.KeyChar.ToString());

            /* Expresión regular que nos limita solo a poder teclear:
             * de 0 a 4 Dígitos
             * y opcionalmente 
             * 1 Punto seguido de 0 a 2 Dígitos 
             */
            if (!Regex.IsMatch(newText, @"^\d{0,4}(\.\d{0,2})?$"))
                e.Handled = true;

        }
    }
}
