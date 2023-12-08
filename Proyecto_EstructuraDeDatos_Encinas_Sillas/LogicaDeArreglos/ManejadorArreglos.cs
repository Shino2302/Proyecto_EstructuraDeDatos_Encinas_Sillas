using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeArreglos
{
    public class ManejadorArreglos
    {
        private ProductoParaMascota[] productos;
        public int tamañoMaximo;
        private int actual;

        public ManejadorArreglos(int capacidadMaxima)
        {
            tamañoMaximo = capacidadMaxima;
            productos = new ProductoParaMascota[capacidadMaxima];
            actual = 0;
        }

        public ProductoParaMascota[] Productos
        {
            get { return productos; }
        }

        public bool EstaVacio()
        {
            return actual == 0;
        }

        public void AgregarProducto(string nombre, double precio)
        {
            if (actual < tamañoMaximo)
            {
                productos[actual] = new ProductoParaMascota(nombre, precio);
                actual++;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModificarProducto(string nombre, double precio, int indice)
        {
            if (indice >= 0 && indice < tamañoMaximo)
            {
                productos[indice] = new ProductoParaMascota(nombre, precio);
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarProducto(int Id)
        {
            if (Id >= 0 && Id < tamañoMaximo)
            {
                productos[Id] = null;
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarProductos(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < actual; i++)
            {
                var producto = productos[i];
                if (producto != null)
                {
                    dataGridView.Rows.Add(i, producto.Nombre, producto.Precio);
                }
            }
        }
        public void InsertarAlFinal(string nombre, double precio)
        {
            if (actual < tamañoMaximo)
            {
                productos[actual] = new ProductoParaMascota(nombre, precio);
                actual++;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertarEnMedio(string nombre, double precio, int indice)
        {
            if (indice >= 0 && indice < tamañoMaximo && actual < tamañoMaximo)
            {
                // Desplazar los elementos hacia la derecha para hacer espacio en la posición indicada
                for (int i = actual; i > indice; i--)
                {
                    productos[i] = productos[i - 1];
                }

                // Insertar el nuevo producto en la posición indicada
                productos[indice] = new ProductoParaMascota(nombre, precio);
                actual++;
            }
            else
            {
                MessageBox.Show("Error al insertar en el medio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void OrdenarPorPrecioAscendente()
        {
            for (int i = 0; i < actual - 1; i++)
            {
                for (int j = 0; j < actual - i - 1; j++)
                {
                    if (productos[j].Precio > productos[j + 1].Precio)
                    {
                        ProductoParaMascota temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }
        }
        public void OrdenarPorPrecioDescendente()
        {
            for (int i = 0; i < actual - 1; i++)
            {
                for (int j = 0; j < actual - i - 1; j++)
                {
                    if (productos[j].Precio < productos[j + 1].Precio)
                    {
                        ProductoParaMascota temp = productos[j];
                        productos[j] = productos[j + 1];
                        productos[j + 1] = temp;
                    }
                }
            }
        }

    }
}
