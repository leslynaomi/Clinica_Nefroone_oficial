using capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace capa_negocio
{
   public class clsRecetario:ClsConexion
    {

        public DataSet Mostrar_RegistrosP()
        {
            string s;
            s = "ListarMedicP";
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
            s = "ListarMedicP";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

    }
}
