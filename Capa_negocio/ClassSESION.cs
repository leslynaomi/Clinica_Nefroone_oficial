using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;

namespace capa_negocio
{
    public class ClassSESION : ClsConexion

    {   //atributos
        private string fecha_sesion;
        private string peso_final;
        private string peso_inicial;
        private string id_sesion;
        private string id_empleado;
        private string id_nota;
        private string id_hojaS;


        //constructor
        public ClassSESION()
        {


            fecha_sesion = "";
            peso_final = "";
            peso_inicial = "";
            id_sesion = "";
            id_empleado = "";
            id_nota= "";
            id_hojaS= "";
        }
        //Getters y Setters
        public string Afecha_sesion { get => fecha_sesion; set => fecha_sesion = value; }
        public string Apeso_final { get => peso_final; set => peso_final = value; }
        public string Apeso_inicial { get => peso_inicial; set => peso_inicial = value; }
        public string Aid_sesion { get => id_sesion; set => id_sesion = value; }
        public string Aid_empleado { get => id_empleado; set => id_empleado = value; }
        public string Aid_nota { get => id_nota; set => id_nota = value; }
        public string Aid_hojaS { get => id_hojaS; set => id_hojaS = value; }


        public void Guardar_Registros()
        {
            IniciarSP("insertar_sesion");
            AddParametro("@fecha_sesion", fecha_sesion);
            AddParametro("@peso_final", peso_final);
            AddParametro("@peso_inicial", peso_inicial);
            AddParametro("@id_sesion", id_sesion);
            AddParametro("@@id_empleado", @id_empleado);
            AddParametro("@id_nota", id_nota);
            AddParametro("@id_hojaS", id_hojaS);
            ejecutarSP();

        }


        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select *from insertar_sesion";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public DataSet insertar_sesion()
        {
            string s;
            s = "select *from insertar_sesion";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        public void Modificar_Registros()
        {
            IniciarSP("modificar_sesion");
            AddParametro("@fecha_sesion", fecha_sesion);
            AddParametro("@peso_final", peso_final);
            AddParametro("@peso_inicial", peso_inicial);
            AddParametro("@id_sesion", id_sesion);
            AddParametro("@@id_empleado", @id_empleado);
            AddParametro("@id_nota", id_nota);
            AddParametro("@id_hojaS", id_hojaS);
            ejecutarSP();

        }


        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from sesion where  like '" + dato + "%' or nombre like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

    }
}
