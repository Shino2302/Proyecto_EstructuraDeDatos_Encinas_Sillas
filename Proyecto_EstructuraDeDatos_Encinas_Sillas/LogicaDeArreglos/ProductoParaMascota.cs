using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeArreglos
{
    public class ProductoParaMascota
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public ProductoParaMascota(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
