using Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeColas;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas
{
    public partial class Colas : Form
    {
        ColaDeEspera cola = new ColaDeEspera();
        int idExponencial = 0;
        public Colas()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void CerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            FormularioColas formulario = new FormularioColas();
            MascotasEnEspera mascota = new MascotasEnEspera();
            DialogResult resultado = formulario.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                idExponencial++;
                mascota = formulario.AgregarEnCola();
                mascota.ID = idExponencial;
                cola.IngresarEnCola(mascota);
                formulario.Close();
                Reload();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reload()
        {
            gridContendor.Columns.Clear();
            gridContendor.ColumnCount = 4;
            gridContendor.Columns[0].Name = "ID";
            gridContendor.Columns[1].Name = "Nombre";
            gridContendor.Columns[2].Name = "Raza";
            gridContendor.Columns[3].Name = "Encargo";
            int cantidad = cola.MascotasEnCola();
            MascotasEnEspera[] arreglo = cola.Listar();
            for (int i = 0; i < cantidad; i++)
            {
                gridContendor.Rows.Add(arreglo[i].ID.ToString(), arreglo[i].Nombre, arreglo[i].Raza, arreglo[i].Encargo);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            MascotasEnEspera mascotaLiberada = cola.Pop();
            MessageBox.Show($"Raza: {mascotaLiberada.Raza}, Nombre: {mascotaLiberada.Nombre} Liberado", "Eliminado De Cola", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Reload();
        }

        private void OrdenarAscendente_Click(object sender, EventArgs e)
        {
            if (cola.ColaVacia())
            {
                MessageBox.Show("La Cola Se Encuentra Vacía!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cola.OrdenarDeMenorAMayor();
                Refresh();
                MessageBox.Show("Cola re-organizada, por el precio más bajo al más alto",
                    "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OrdenarDescendente_Click(object sender, EventArgs e)
        {
            if (cola.ColaVacia())
            {
                MessageBox.Show("La Cola Se Encuentra Vacía!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cola.OrdenarDeMayorAMenor();
                Refresh();
                MessageBox.Show("Cola re-organizada, por el precio más alto al más bajo",
                    "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

        }

        private void gridContendor_SelectionChanged(object sender, EventArgs e)
        {
            if (gridContendor.Rows.Count > 0)
            {
                Eliminar.Enabled = true;
            }
        }
    }
}
