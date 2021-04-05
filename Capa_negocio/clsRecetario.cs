using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using System.Data;
namespace capa_negocio
{
    
    public class clsRecetario : ClsConexion
    {

    
       // private string cantidad_Recetada;
        ///private string id_medicamento;
  



        public clsRecetario()
        {
          //  cantidad_Recetada = "";
           

        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "ListarMedic";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public DataSet Mostrar_RegistrosF()
        {
            string s;
            s = "ListarMedicF";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        public DataSet Mostrar_RegistrosC()
        {
            string s;
            s = "ListarMedicC";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        public DataSet Mostrar_RegistrosP()
        {
            string s;
            s = "ListarMedicD";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }



    }
}
