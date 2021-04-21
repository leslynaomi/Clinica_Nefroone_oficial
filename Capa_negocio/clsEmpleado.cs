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
        private string usuario;
        private string passwd;

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
            usuario = "";
            passwd = "";
        }

        public string Id_empleado1 { get => id_empleado; set => id_empleado = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Paterno1 { get => paterno; set => paterno = value; }
        public string Materno1 { get => materno; set => materno = value; }
        public string Ci1 { get => ci; set => ci = value; }
        public string Fecha_Nac1 { get => fecha_Nac; set => fecha_Nac = value; }
        public string Nro_Celular1 { get => nro_Celular; set => nro_Celular = value; }
        public string Tipo1 { get => tipo; set => tipo = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Passwd { get => passwd; set => passwd = value; }

        public void Guardar_Registros()
        {
            IniciarSP("insertar_empleado");
            AddParametro("@nombre", nombre);
            AddParametro("@paterno", paterno);
            AddParametro("@materno", materno);
            AddParametro("@ci", ci);
            AddParametro("@fecha_Nac", fecha_Nac);
            AddParametro("@nro_Celular", nro_Celular);
            AddParametro("@tipo", tipo);
            AddParametro("@usuario", usuario);
            AddParametro("@passwd", passwd);
            ejecutarSP();
        }
    }
}
