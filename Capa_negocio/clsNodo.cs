using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    class Nodo
    {
        private string nombre;
        private Nodo siguiente;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
