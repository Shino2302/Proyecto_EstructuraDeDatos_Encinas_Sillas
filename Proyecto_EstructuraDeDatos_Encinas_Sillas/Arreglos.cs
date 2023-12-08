using Proyecto_EstructuraDeDatos_Encinas_Sillas.Formularios;
using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeArreglos;
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
    public partial class Arreglos : Form
    {
        public ManejadorArreglos arreglo1;
        public Arreglos()
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
            FormularioArreglo formulario = new FormularioArreglo();

            DialogResult resultado = formulario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                string nombre = formulario.Nombre;
                double precio = Convert.ToDouble(formulario.Precios);

                arreglo1.AgregarProducto(nombre, precio);

                //Reload();
            }
            //public void Reload()
            //{
            //    arreglo1.ListarProductos(gridContendor);
            //}
        }
    }
}
