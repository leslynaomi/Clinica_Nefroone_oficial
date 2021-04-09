using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;

namespace capa_negocio
{
     public class ClassDialisisPeritonea : ClsConexion
    {

        //Atributos
        private string precio_Sesion_D_Peritoneal;
        private string infucion_Inicio;
        private string infucion_Final;
        private string infucion_Volumen;
        private string drenaje_Inicio;
        private string drenaje_Volumen;
        private string balance_Parcial;
        private string balance_Total;
        private string solucion_Usada1;
        private string solucion_Usada2;
        private string observacion_Balance;
        private string id_hoja_enfermeria;
        private string id_sesion;




        //Constructor
        public ClassDialisisPeritonea()
        {
            precio_Sesion_D_Peritoneal = "";
            infucion_Inicio = "";
            infucion_Final = "";
            infucion_Volumen = "";
            drenaje_Inicio = "";
            drenaje_Volumen = "";
            balance_Parcial = "";
            balance_Total = "";
            solucion_Usada1 = "";
            solucion_Usada2 = "";
            observacion_Balance = "";
            id_hoja_enfermeria = "";
            id_sesion = "";


        }

        //Getters y Setters
        public string Aprecio_Sesion_D_Peritoneal { get => precio_Sesion_D_Peritoneal; set => precio_Sesion_D_Peritoneal = value; }
        public string Ainfucion_Inicio { get => infucion_Inicio; set => infucion_Inicio = value; }
        public string Ainfucion_Final { get => infucion_Final; set => infucion_Final = value; }
        public string Ainfucion_Volumen { get => infucion_Volumen; set => infucion_Volumen = value; }
        public string Adrenaje_Inicio { get => drenaje_Inicio; set => drenaje_Inicio = value; }
        public string Adrenaje_Volumen { get => drenaje_Volumen; set => drenaje_Volumen = value; }
        public string Abalance_Parcial { get => balance_Parcial; set => balance_Parcial = value; }
        public string Abalance_Total { get => balance_Total; set => balance_Total = value; }
        public string Asolucion_Usada1 { get => solucion_Usada1; set => solucion_Usada1 = value; }
        public string Asolucion_Usada2 { get => solucion_Usada2; set => solucion_Usada2 = value; }
        public string Aobservacion_Balance { get => observacion_Balance; set => observacion_Balance = value; }
        public string Aid_hoja_enfermeria { get => id_hoja_enfermeria; set => id_hoja_enfermeria = value; }
        public string Aid_sesion { get => id_sesion; set => id_sesion = value; }
        //Procedimientos del Crud

        public void Guardar_Registros()
        {
            IniciarSP("insertar_dialisis_peritoneal");
            AddParametro("@precio_Sesion_D_Peritoneal", precio_Sesion_D_Peritoneal);
            AddParametro("@infucion_Inicio", infucion_Inicio);
            AddParametro("@infucion_Final", infucion_Final);
            AddParametro("@infucion_Volumen", infucion_Volumen);
            AddParametro("@drenaje_Inicio", drenaje_Inicio);
            AddParametro("@drenaje_Volumen", drenaje_Volumen);
            AddParametro("@balance_Parcial", balance_Parcial);
            AddParametro("@balance_total", balance_Total);
            AddParametro("@solucion_Usada1", solucion_Usada1);
            AddParametro("@solucion_Usada2", solucion_Usada2);
            AddParametro("@observacion_Balance", observacion_Balance);
            AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            AddParametro("@id_sesion", id_sesion);
            ejecutarSP();

        }


        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select *from Dialisis_Peritoneal";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Registros()
        {
            IniciarSP("modificar_dialisis_peritoneal");
            AddParametro("@precio_Sesion_D_Peritoneal", precio_Sesion_D_Peritoneal);
            AddParametro("@infucion_Inicio", infucion_Inicio);
            AddParametro("@infucion_Final", infucion_Final);
            AddParametro("@infucion_Volumen", infucion_Volumen);
            AddParametro("@drenaje_Inicio", drenaje_Inicio);
            AddParametro("@drenaje_Volumen", drenaje_Volumen);
            AddParametro("@balance_Parcial", balance_Parcial);
            AddParametro("@solucion_Usada1", solucion_Usada1);
            AddParametro("@solucion_Usada2", solucion_Usada2);
            AddParametro("@observacion_Balance", observacion_Balance);
            AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            AddParametro("@id_sesion", id_sesion);
            ejecutarSP();
        }

        //public void Eliminar_Registros()
        //{
           // IniciarSP("eliminar_");
            //AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            //AddParametro("@id_sesion", id_sesion);

            //ejecutarSP();
        //}
        //Busca en los registros a un paciente por Nombre o por CI
        //public DataSet Buscar_Registros(string dato)
        //{
          //  string s;
            //DataSet ds = new DataSet();
            ///s = "select *from Dialisis_Peritoneal where  like '" + dato + "%' or nombre like '" + dato + "%'";
            //ejecutarSQL(s, "tac", ds);
            //return ds;
        //}
    }
}

