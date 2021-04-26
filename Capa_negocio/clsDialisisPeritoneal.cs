using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capa_datos;

namespace capa_negocio
{
    public class ClsDialisisPeritoneal : ClsConexion
    {
        //Atributos
        private string id_hojaDP;
        private string nro_Dialisis;
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
        private string total_Dialisis;
        private string variedad_De_Peso;
        private string id_sesion;
        
        //Constructor
        public ClsDialisisPeritoneal()
        {
             id_hojaDP = "";
             nro_Dialisis = "";
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
             total_Dialisis = "";
             variedad_De_Peso = "";
             id_sesion = "";        
        }

        //Getters y Setters
        public string Id_hojaDP { get => id_hojaDP; set => id_hojaDP = value; }
        public string Nro_Dialisis { get => nro_Dialisis; set => nro_Dialisis = value; }
        public string Infucion_Inicio { get => infucion_Inicio; set => infucion_Inicio = value; }
        public string Infucion_Final { get => infucion_Final; set => infucion_Final = value; }
        public string Infucion_Volumen { get => infucion_Volumen; set => infucion_Volumen = value; }
        public string Drenaje_Inicio { get => drenaje_Inicio; set => drenaje_Inicio = value; }
        public string Drenaje_Volumen { get => drenaje_Volumen; set => drenaje_Volumen = value; }
        public string Balance_Parcial { get => balance_Parcial; set => balance_Parcial = value; }
        public string Balance_Total { get => balance_Total; set => balance_Total = value; }
        public string Solucion_Usada1 { get => solucion_Usada1; set => solucion_Usada1 = value; }
        public string Solucion_Usada2 { get => solucion_Usada2; set => solucion_Usada2 = value; }
        public string Observacion_Balance { get => observacion_Balance; set => observacion_Balance = value; }
        public string Total_Dialisis { get => total_Dialisis; set => total_Dialisis = value; }
        public string Variedad_De_Peso { get => variedad_De_Peso; set => variedad_De_Peso = value; }
        public string Id_sesion { get => id_sesion; set => id_sesion = value; }

        //Procedimientos del Crud

        public void Guardar_Registros()
        {
            IniciarSP("insertar_dialisis_peritoneal");
            AddParametro("@nro_Dialisis", nro_Dialisis);
            AddParametro("@infucion_Inicio", infucion_Inicio);
            AddParametro("@infucion_Final", infucion_Final);
            AddParametro("@infucion_Volumen", infucion_Volumen);
            AddParametro("@drenaje_Inicio", drenaje_Inicio);
            AddParametro("@drenaje_Volumen", drenaje_Volumen);
            AddParametro("@balance_Parcial", balance_Parcial);
            AddParametro("@balance_Total", balance_Total);
            AddParametro("@solucion_Usada1", solucion_Usada1);
            AddParametro("@solucion_Usada2", solucion_Usada2);
            AddParametro("@observacion_Balance", observacion_Balance);
            AddParametro("@total_Dialisis", total_Dialisis);
            AddParametro("@variedad_De_Peso", variedad_De_Peso);
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
        
        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from Dialisis_Peritoneal where id_sesion like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}

