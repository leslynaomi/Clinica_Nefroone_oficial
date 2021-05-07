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
        private string ci;
        private string id_empleado;
        private string id_evolucion_tratamiento;

        public clsRecetario()
        {

            fecha = "";
            ci = "";
            id_empleado = "";
            id_evolucion_tratamiento = "";
        }

        ///get y setter
        public string Fecha { get => fecha; set => fecha = value; }
        public string Ci { get => ci; set => ci = value; }
        public string Id_Empleado { get => id_empleado; set => id_empleado = value; }
        public string Id_Evolucion { get => id_evolucion_tratamiento; set => id_evolucion_tratamiento = value; }
        
        public void Guardar_Registros()
        {
            IniciarSP("insertar");

            AddParametro("@fecha", Fecha);

            AddParametro("@ci", Ci);
            AddParametro("@id_empleado", Id_Empleado);
            AddParametro("@id_evolucion_tratamiento", Id_Evolucion);
            ejecutarSP();
        }
       
        public DataSet idEvolucion(string id_paciente, string fecha)
        {
            string s;
            s = "select id_hojaEvolT from Hoja_Secretaria, Sesion, Evolucion_Tratamiento where Hoja_Secretaria.id_hojaS = Sesion.id_hojaS and Sesion.id_sesion = Evolucion_Tratamiento.id_sesion and Hoja_Secretaria.CI ='" + id_paciente + "' and Sesion.fecha_Sesion = '" + fecha + " ";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        
        public DataSet idReceta(string id_paciente, string fecha)
        {
            string s;
            s = "select id_hojaEvolT from Hoja_Secretaria, Sesion, Evolucion_Tratamiento where Hoja_Secretaria.id_hojaS = Sesion.id_hojaS and Sesion.id_sesion = Evolucion_Tratamiento.id_sesion and Hoja_Secretaria.CI ='" + id_paciente + "' and Sesion.fecha_Sesion = '" + fecha + " ";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        
        public DataSet Mostrar_Registros(string fecharec, string id_pac)
        {
            string s;
            s = "select Medicamento.id_medicamento,nombre_Medicamento,cantidad_Recetada from Medicamento, Receta where Medicamento.id_medicamento = Detalle_Receta.id_medicamento and Receta.id_receta=Detalle_Receta.id_receta and fecha = '" + fecharec + "' and ci = '" + id_pac + "'";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public DataSet Mostrar_RegistrosT(string tipo_medicamento)
        {
            string s;
            s = "select  nombre_Medicamento, presentacion, concentracion from Medicamento where tipo_acceso = '" + tipo_medicamento + "'";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
