using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using System.Data;

namespace capa_negocio
{
    public class ClsHojaEnfermeria : ClsConexion
    {
        //Atributos        
        private string id_HojaE;
        private string nro_Sesion_HD;
        private string hora_Inicio;
        private string hora_Salida;
        private string U_F_Programada;
        private string heparina;
        private string flujo_Efectivo;
        private string presion_Arterial;
        private string temperatura;
        private string pulso;
        private string saturacion;
        private string id_sesion;        

        //Constructor
        public ClsHojaEnfermeria()
        {
            id_HojaE = "";
            nro_Sesion_HD = "";
            hora_Inicio = "";
            hora_Salida = "";
            U_F_Programada = "";
            heparina = "";
            flujo_Efectivo = "";
            presion_Arterial = "";
            temperatura = "";
            pulso = "";
            saturacion = "";
            id_sesion = "";        
        }

        //Getters y Setters
        public string Id_HojaE { get => id_HojaE; set => id_HojaE = value; }
        public string Nro_Sesion_HD { get => nro_Sesion_HD; set => nro_Sesion_HD = value; }
        public string Hora_Inicio { get => hora_Inicio; set => hora_Inicio = value; }
        public string Hora_Salida { get => hora_Salida; set => hora_Salida = value; }
        public string U_F_Programada1 { get => U_F_Programada; set => U_F_Programada = value; }
        public string Heparina { get => heparina; set => heparina = value; }
        public string Flujo_Efectivo { get => flujo_Efectivo; set => flujo_Efectivo = value; }
        public string Presion_Arterial { get => presion_Arterial; set => presion_Arterial = value; }
        public string Temperatura { get => temperatura; set => temperatura = value; }
        public string Pulso { get => pulso; set => pulso = value; }
        public string Saturacion { get => saturacion; set => saturacion = value; }
        public string Id_sesion { get => id_sesion; set => id_sesion = value; }

        //Procedimientos del Crud
        public void Guardar_Registros()
        {
            IniciarSP("insertar_control_enfermeria");
            AddParametro("@nro_Sesion_HD", nro_Sesion_HD);
            AddParametro("@hora_Inicio", hora_Inicio);
            AddParametro("@hora_Salida", hora_Salida);
            AddParametro("@U_F_Programada", U_F_Programada);
            AddParametro("@heparina", heparina);
            AddParametro("@flujo_Efectivo", flujo_Efectivo);
            AddParametro("@presion_Arterial", presion_Arterial);
            AddParametro("@temperatura", temperatura);
            AddParametro("@pulso", pulso);
            AddParametro("@saturacion", saturacion);
            AddParametro("@id_sesion", id_sesion);
            ejecutarSP();
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select *from Control_Enfermeria";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
