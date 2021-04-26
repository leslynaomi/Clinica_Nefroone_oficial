using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;

namespace capa_negocio
{
    public class ClsSesion : ClsConexion
    {
        //atributos        
        private string id_sesion;
        private string fecha_Sesion;
        private string peso_Inicial;
        private string peso_Final;
        private string id_empleado;
        private string id_nota;
        private string id_hojaS;
       
        //constructor
        public ClsSesion()
        {
             id_sesion = "";
             fecha_Sesion = "";
             peso_Inicial = "";
             peso_Final = "";
             id_empleado = "";
             id_nota = "";
             id_hojaS = "";
        }

        //Getters y Setters
        public string Id_sesion { get => id_sesion; set => id_sesion = value; }
        public string Fecha_Sesion { get => fecha_Sesion; set => fecha_Sesion = value; }
        public string Peso_Inicial { get => peso_Inicial; set => peso_Inicial = value; }
        public string Peso_Final { get => peso_Final; set => peso_Final = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Id_nota { get => id_nota; set => id_nota = value; }
        public string Id_hojaS { get => id_hojaS; set => id_hojaS = value; }


        public void Guardar_Registros()
        {
            IniciarSP("insertar_sesion");
            AddParametro("@fecha_Sesion", fecha_Sesion);
            AddParametro("@peso_Inicial", peso_Inicial);
            AddParametro("@peso_Final", peso_Final);
            AddParametro("@@id_empleado", @id_empleado);
            AddParametro("@id_nota", id_nota);
            AddParametro("@id_hojaS", id_hojaS);
            ejecutarSP();
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select id_sesion,fecha_Sesion,pac.ci,nombre,materno,materno,edad,sexo,seguro,acceso_Vascular,seguro,nro_familiar_Contacto from Sesion as ses,Paciente as pac,Hoja_Secretaria as sec where sec.ci = pac.ci and sec.id_hojaS = ses.id_hojaS";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }        

        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from sesion where fecha_Sesion like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

    }
}
