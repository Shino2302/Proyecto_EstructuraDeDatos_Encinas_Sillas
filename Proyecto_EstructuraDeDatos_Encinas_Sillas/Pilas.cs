using Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDePilas;
using System;
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
    public partial class Pilas : Form
    {
        public RegistroAtencion registroAtencion;

        public string Nombre { get; set; }
        public string Nota { get; set; }
        public Pilas()
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
            using (FormularioPilas formulario = new FormularioPilas(registroAtencion))
            {
                // Mostrar el formulario de entrada
                DialogResult resultado = formulario.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // Aqui obtenemos los datos ingresados por el usuario desde el formulario
                    string nombre = formulario.ObtenerNombre();
                    string notas = formulario.ObtenerNotas();

                    registroAtencion.AgregarMascota(nombre, DateTime.Now, DateTime.Now, notas);

                    registroAtencion.ListarMascotas(gridContenedor);
                }
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (gridContenedor.SelectedRows.Count > 0)
            {
                int rowIndex = gridContenedor.SelectedRows[0].Index;
                string nombreActual = gridContenedor.Rows[rowIndex].Cells["Nombre"].Value.ToString();
                string notasActual = gridContenedor.Rows[rowIndex].Cells["Notas"].Value.ToString();

                using (FormularioPilas formulario = new FormularioPilas(registroAtencion, nombreActual, notasActual))
                {
                    DialogResult result = formulario.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        registroAtencion.ModificarMascota(rowIndex, formulario.ObtenerNombre(), DateTime.Now, DateTime.Now, formulario.ObtenerNotas());

                        // Actualizar el DataGridView en el formulario Pilas
                        registroAtencion.ListarMascotas(gridContenedor);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (gridContenedor.SelectedRows.Count > 0)
            {
                int Indicio = gridContenedor.SelectedRows[0].Index;

                string nombreMascotaEliminar = gridContenedor.Rows[Indicio].Cells["Nombre"].Value.ToString();

                DialogResult confirmacion = MessageBox.Show($"¿Seguro que quieres eliminar la mascota '{nombreMascotaEliminar}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    registroAtencion.EliminarMascota(Indicio);

                    // Actualizar el DataGridView en el formulario Pilas
                    registroAtencion.ListarMascotas(gridContenedor);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
