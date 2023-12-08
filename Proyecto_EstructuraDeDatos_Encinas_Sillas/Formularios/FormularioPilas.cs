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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios
{
    public partial class FormularioPilas : Form
    {
        private RegistroAtencion registroAtencion;

        private string nombreActual;
        private string notasActual;

        public int indice = -1;
        public FormularioPilas(RegistroAtencion registro)
        {
            InitializeComponent();
            registroAtencion = registro;
            InicializarDataGridView();
        }

        public FormularioPilas(RegistroAtencion registro, string nombreActual, string notasActual) : this(registro)
        {
            InitializeComponent();

            this.nombreActual = nombreActual;
            this.notasActual = notasActual;

            txtBoxNombre.Text = nombreActual;
            txtBoxNotas.Text = notasActual;
        }

        public string ObtenerNombre()
        {
            return txtBoxNombre.Text;
        }

        public string ObtenerNotas()
        {
            return txtBoxNotas.Text;
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            this.nombreActual = ObtenerNombre();
            this.notasActual = ObtenerNotas();
            DialogResult = DialogResult.OK;
            Close();
        }
        private void InicializarDataGridView()
        {
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            var evento = MessageBox.Show("¿Esta seguro que desea cancelar el agregado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (evento == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
