using Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeListas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_EstructuraDeDatos_Encinas_Sillas.LogicaDeColas
{
    public class ColaDeEspera
    {
        private NodoColas _primero;
        private NodoColas _ultimo;

        public bool ColaVacia()
        {
            return _primero == null ? true : false;    
        }
        public bool IngresarEnCola(MascotasEnEspera mascotaIngresada)
        {
            try
            {
                NodoColas Nuevo = new NodoColas();
                Nuevo.Mascota = mascotaIngresada;
                if (ColaVacia())
                {
                    _primero = Nuevo;
                    _ultimo = Nuevo;
                    return true;                
                }
                else
                {
                    Nuevo.Siguiente = _ultimo;
                    _ultimo = Nuevo;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public MascotasEnEspera Pop()
        {
            try
            {
                if (ColaVacia())
                {
                    return null;
                }
                else if (_ultimo.Siguiente == null)
                {
                    MascotasEnEspera mascota = _primero.Mascota;
                    _primero = null;
                    _ultimo = null;
                    return mascota;
                }
                else
                {
                    MascotasEnEspera mascota = _primero.Mascota;
                    NodoColas Auxiliar = _ultimo;
                    while(Auxiliar.Siguiente != _primero)
                    {
                        Auxiliar = Auxiliar.Siguiente;
                    }
                    Auxiliar.Siguiente = null;
                    _primero = Auxiliar;
                    if (Auxiliar == _ultimo)
                        _ultimo = Auxiliar;
                    return mascota;
                }
            }
            catch
            {
                return null;
            }
        }
        public MascotasEnEspera Pop(int idParaEliminar)
        {
            try
            {
                ColaDeEspera colaAuxiliar = new ColaDeEspera();
                NodoColas Auxiliar = _ultimo;
                MascotasEnEspera mascotaLiberada = new MascotasEnEspera();
                while (Auxiliar.Siguiente != null)
                {
                    if (Auxiliar.Mascota.ID == idParaEliminar)
                        mascotaLiberada = Pop();
                    else
                    {
                        colaAuxiliar.IngresarEnCola(Pop());
                    }
                }
                colaAuxiliar.IngresarEnCola(Pop());
                while (!colaAuxiliar.ColaVacia())
                {
                    IngresarEnCola(colaAuxiliar.Pop());
                }
                return mascotaLiberada;
            }
            catch
            {
                return null;
            }
        }
        public int MascotasEnCola()
        {
            if (ColaVacia())
                return -1;
            else
            {
                NodoColas Auxiliar = _ultimo;
                int contador = 1;
                while (Auxiliar.Siguiente != null)
                {
                    contador++;
                    Auxiliar = Auxiliar.Siguiente;
                }
                return contador;
            }
        }
        public MascotasEnEspera[] Listar()
        {
            if (ColaVacia())
                return null;
            else
            {
                int cantidadDeElementos = MascotasEnCola();
                MascotasEnEspera[] lista = new MascotasEnEspera[cantidadDeElementos];
                NodoColas Auxiliar = _ultimo;
                for (int i = 0; i < cantidadDeElementos; i++)
                {
                    lista[i] = Auxiliar.Mascota;
                    Auxiliar = Auxiliar.Siguiente;
                }
                return lista;
            }
        }
        public void OrdenarDeMayorAMenor()
        {
            if (!ColaVacia())
            {
                int enCola = MascotasEnCola();
                if(enCola > 1)
                {
                    NodoColas Auxiliar = _ultimo;
                    MascotasEnEspera[] arregloTemporal = new MascotasEnEspera[enCola];
                    MascotasEnEspera temporal = new MascotasEnEspera();
                    for (int i = 0; i < enCola; i++)
                    {
                        arregloTemporal[i] = Auxiliar.Mascota;
                        Auxiliar = Auxiliar.Siguiente;
                    }
                    for (int i = 0; i < enCola - 1; i++)
                    {
                        for (int j = 0; j < enCola - i - 1; j++)
                        {
                            if (arregloTemporal[j].ID < arregloTemporal[j + 1].ID)
                            {
                                temporal = arregloTemporal[j];
                                arregloTemporal[j] = arregloTemporal[j + 1];
                                arregloTemporal[j + 1] = temporal;
                            }
                        }
                    }
                    _primero = null;
                    _ultimo = null;
                    for (int i = 0; i < enCola; i++)
                    {
                        IngresarEnCola(arregloTemporal[i]);
                    }
                }
            }
        }
        public void OrdenarDeMenorAMayor()
        {
            if (!ColaVacia())
            {
                int enCola = MascotasEnCola();
                if (enCola > 1)
                {
                    NodoColas Auxiliar = _ultimo;
                    MascotasEnEspera[] arregloTemporal = new MascotasEnEspera[enCola];
                    MascotasEnEspera temporal = new MascotasEnEspera();
                    for (int i = 0; i < enCola; i++)
                    {
                        arregloTemporal[i] = Auxiliar.Mascota;
                        Auxiliar = Auxiliar.Siguiente;
                    }
                    for (int i = 0; i < enCola - 1; i++)
                    {
                        for (int j = 0; j < enCola - i - 1; j++)
                        {
                            if (arregloTemporal[j].ID > arregloTemporal[j + 1].ID)
                            {
                                temporal = arregloTemporal[j];
                                arregloTemporal[j] = arregloTemporal[j + 1];
                                arregloTemporal[j + 1] = temporal;
                            }
                        }
                    }
                    _primero = null;
                    _ultimo = null;
                    for (int i = 0; i < enCola; i++)
                    {
                        IngresarEnCola(arregloTemporal[i]);
                    }
                }
            }
        }
    }
}
