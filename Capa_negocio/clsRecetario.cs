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

        //atributos
        private string fecha;
        private string cantidad_Recetada;
        private string id_medicamento;
        private string ci;
        private string id_empleado;



        public clsRecetario()
        {

            fecha = "";

          cantidad_Recetada = "";
            id_medicamento = "";
            ci = "";
            id_empleado = "";

        }


        ///get y setter

        public string Fecha { get => fecha; set => fecha = value; }
        public string Cantida_Recetada { get => cantidad_Recetada; set => cantidad_Recetada = value; }
        public string Id_medicamento { get => id_medicamento; set => id_medicamento = value; }
        public string Ci { get => ci; set => ci = value; }
        public string Id_Empleado { get => id_empleado; set => id_empleado = value; }





        public void Guardar_Registros()
        {
            IniciarSP("insertar_receta");

            AddParametro("@fecha", Fecha);
            AddParametro("@cantidad_Recetada",Cantida_Recetada);
            AddParametro("@id_medicamento", Id_medicamento);

            AddParametro("@ci", ci);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }


















        public DataSet Mostrar_Registros(string fecharec, string id_pac)
        {
            string s;
            s = "select Medicamento.id_medicamento,nombre_Medicamento,cantidad_Recetada from Medicamento, Receta where Medicamento.id_medicamento = Receta.id_medicamento and fecha = '"+fecharec+"' and ci = '"+id_pac+"'";
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
            s = "ListarMedicP";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }



    }
}
