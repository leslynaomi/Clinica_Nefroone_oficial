using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using capa_datos;

namespace capa_negocio
{
    public class ClsEmpleado:ClsConexion
    {
        private string id_empleado;
        private string nombre;
        private string paterno;
        private string materno;
        private string ci;
        private string fecha_Nac;
        private string nro_Celular;
        private string tipo;

        public ClsEmpleado()
        {
            id_empleado = "";
            nombre = "";
            paterno = "";
            materno = "";
            ci = "";
            fecha_Nac = "";
            nro_Celular = "";
            tipo = "";
        }

        public string Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Paterno
        {
            get { return paterno; }
            set { paterno = value; }
        }

        public string Materno
        {
            get { return materno; }
            set { materno = value; }
        }

        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        public string Fecha_Nac
        {
            get { return fecha_Nac; }
            set { fecha_Nac = value; }
        }

        public string Nro_Celular
        {
            get { return nro_Celular; }
            set { nro_Celular = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
