using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using System.Data;
namespace capa_negocio
{
    //atributos
     public class clsInsumos: ClsConexion
    {
        private string id_medicamento;
        private string nombre_medicamento;
        private string presentacion;
        private string concentracion;
        private string stock;
        private string tipo_diagnostico;
        private string id_farmacia;


        //constructor

        public clsInsumos()
        {

            id_medicamento = "";
            nombre_medicamento = "";
            presentacion = "";
            concentracion = "";
            stock = "";
            tipo_diagnostico = "";
            id_farmacia = "";

        }




        public string id_Medicamento { get => id_medicamento; set => id_medicamento = value; }
        public string Nombre_medicamento { get => nombre_medicamento; set => nombre_medicamento = value; }
        public string Presentacion { get => presentacion; set => presentacion = value; }
        public string Concentracion{ get => concentracion; set => concentracion = value; }
        public string Stock { get => stock; set => stock = value; }
        public string Tipo_diagnostico { get => tipo_diagnostico; set => tipo_diagnostico = value; }
        public string id_Farmacia { get => id_farmacia; set => id_Farmacia = value; }


        //Procedimientos del Crud

        public void Guardar_Registros()
        {
            string id_farmacia = "1";
            IniciarSP("insertar_medicamento");
            AddParametro("@nombre_Medicamento", nombre_medicamento);
            AddParametro("@presentacion",presentacion);
            AddParametro("@concentracion", concentracion);
            AddParametro("@stock", Stock);
            AddParametro("@tipo_diagnostico", tipo_diagnostico);
            AddParametro("@id_farmacia", id_farmacia);

            ejecutarSP();
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select id_medicamento,nombre_Medicamento,presentacion,concentracion,stock, tipo_diagnostico from Medicamento";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
        public void Modificar_Registros()
        {
            IniciarSP("modificar_Medicamento");
            AddParametro("@nombre_Medicamento", nombre_medicamento);
            AddParametro("@presentacion", presentacion);
            AddParametro("@concentracion", concentracion);
            AddParametro("@stock", Stock);
            AddParametro("@tipo_diagnostico", tipo_diagnostico);
            ejecutarSP();
        }


    }


}
