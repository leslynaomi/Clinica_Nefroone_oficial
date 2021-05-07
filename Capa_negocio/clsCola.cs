using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_negocio
{
    public class Cola
    {
        Nodo primero = new Nodo();
        Nodo ultimo = new Nodo();

        public Cola()
        {
            primero = null;
            ultimo = null;
        }

        public void IngresarNodo(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;
            nuevo.Siguiente = null;
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                MessageBox.Show("Primer Nodo Insertado");
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
                MessageBox.Show("paciente añadido");
            }
        }

        public string MostrarNodo()
        {
            string cadena = "";

            if (primero == null)
            {
                cadena = "la cola esta vacia";
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    cadena = cadena + " / " + actual.Nombre;
                    actual = actual.Siguiente;


                }
            }

            return cadena;
        }

        public void EliminarNodo()
        {
            if (primero == null)
            {
                MessageBox.Show("no hay pacientes registrados");
            }
            else
            {
                MessageBox.Show("Le toca  el turno a" + primero.Nombre);
                primero = primero.Siguiente;
            }
        }
    }
}
