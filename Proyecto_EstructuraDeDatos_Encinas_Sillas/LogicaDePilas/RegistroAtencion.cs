using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDePilas
{
    public class RegistroAtencion
    {

        private RegistroMascota[] arregloMascotas;
        private int indice;

        public RegistroAtencion(int capacidadMaxima)
        {
            arregloMascotas = new RegistroMascota[capacidadMaxima];
            indice = -1;
        }

        public void AgregarMascota(string nombre, DateTime horaLlegada, DateTime horaAtencion, string notas)
        {
            if (indice < arregloMascotas.Length - 1)
            {
                indice++;
                arregloMascotas[indice] = new RegistroMascota
                {
                    Nombre = nombre,
                    HoraLlegada = horaLlegada,
                    HoraAtencion = horaAtencion,
                    Notas = notas
                };
            }
            else
            {
                MessageBox.Show("El registro está lleno. No se puede agregar más mascotas.");
            }
        }

        public void ModificarMascota(int index, string nombre, DateTime horaLlegada, DateTime horaAtencion, string notas)
        {
            if (indice >= 0 && index <= indice)
            {
                RegistroMascota mascotaActual = arregloMascotas[index];
                mascotaActual.Nombre = nombre;
                mascotaActual.HoraLlegada = horaLlegada;
                mascotaActual.HoraAtencion = horaAtencion;
                mascotaActual.Notas = notas;
            }
            else
            {
                MessageBox.Show("Índice fuera de rango. No se puede modificar la mascota.");
            }
        }

        public void EliminarMascota(int index)
        {
            if (index >= 0 && index <= indice)
            {
                for (int i = index; i < indice; i++)
                {
                    arregloMascotas[i] = arregloMascotas[i + 1];
                }

                arregloMascotas[indice] = null;
                indice--;
            }
            else
            {
                // Manejar el caso de índice fuera de rango
                MessageBox.Show("Índice fuera de rango. No se puede eliminar la mascota.");
            }
        }

        public void ListarMascotas(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            for (int i = 0; i <= indice; i++)
            {
                var mascota = arregloMascotas[i];
                if (mascota != null)
                {
                    dataGridView.Rows.Add(mascota.Nombre, mascota.HoraLlegada, mascota.HoraAtencion, mascota.Notas);
                }
            }
        }
    }
}