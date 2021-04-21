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
        private string id_hoja_enfermeria;
        private string fecha_Sesion;
        private string nro_Sesion_HD;
        private string hora_Inicio;
        private string hora_Salida;
        private string peso_Inicial;
        private string peso_Final;
        private string U_F_Programada;
        private string heparina;
        private string flujo_Efectivo;
        private string presion_Arterial;
        private string temperatura;
        private string pulso;
        private string saturacion;
        private string id_hojaS;
        private string id_empleado;

        //Constructor
        public ClsHojaEnfermeria()
        {
            id_hoja_enfermeria = "";
            fecha_Sesion = "";
            nro_Sesion_HD = "";
            hora_Inicio = "";
            hora_Salida = "";
            peso_Inicial = "";
            peso_Final = "";
            U_F_Programada = "";
            heparina = "";
            flujo_Efectivo = "";
            presion_Arterial = "";
            temperatura = "";
            pulso = "";
            saturacion = "";
            id_hojaS = "";
            id_empleado = "";
        }

        //Getters y Setters
        public string Id_hoja_enfermeria { get => id_hoja_enfermeria; set => id_hoja_enfermeria = value; }        
        public string Fecha_Sesion { get => fecha_Sesion; set => fecha_Sesion = value; }
        public string Nro_Sesion_HD { get => nro_Sesion_HD; set => nro_Sesion_HD = value; }
        public string Hora_Inicio { get => hora_Inicio; set => hora_Inicio = value; }
        public string Hora_Salida { get => hora_Salida; set => hora_Salida = value; }
        public string Peso_Inicial { get => peso_Inicial; set => peso_Inicial = value; }
        public string Peso_Final { get => peso_Final; set => peso_Final = value; }
        public string U_F_Programada1 { get => U_F_Programada; set => U_F_Programada = value; }
        public string Heparina { get => heparina; set => heparina = value; }
        public string Flujo_Efectivo { get => flujo_Efectivo; set => flujo_Efectivo = value; }
        public string Presion_Arterial { get => presion_Arterial; set => presion_Arterial = value; }
        public string Temperatura { get => temperatura; set => temperatura = value; }
        public string Pulso { get => pulso; set => pulso = value; }
        public string Saturacion { get => saturacion; set => saturacion = value; }
        public string Id_hojaS { get => id_hojaS; set => id_hojaS = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }

        //Procedimientos del Crud
        public void Guardar_Registros()
        {
            IniciarSP("insertar_control_enfermeria");
            AddParametro("@fecha_Sesion", fecha_Sesion);
            AddParametro("@nro_Sesion_HD", nro_Sesion_HD);
            AddParametro("@hora_Inicio", hora_Inicio);
            AddParametro("@hora_Salida", hora_Salida);
            AddParametro("@peso_Inicial", peso_Inicial);
            AddParametro("@peso_Final", peso_Final);
            AddParametro("@U_F_Programada", U_F_Programada);
            AddParametro("@heparina", heparina);
            AddParametro("@flujo_Efectivo", flujo_Efectivo);
            AddParametro("@presion_Arterial", presion_Arterial);
            AddParametro("@temperatura", temperatura);
            AddParametro("@pulso", pulso);
            AddParametro("@saturacion", saturacion);
            AddParametro("@id_hojaS", id_hojaS);
            AddParametro("@id_empleado", id_empleado);
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

        public void Modificar_Registros()
        {
            IniciarSP("modificar_control_enfermeria");
            AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            AddParametro("@fecha_Sesion", fecha_Sesion);
            AddParametro("@nro_Sesion_HD", nro_Sesion_HD);
            AddParametro("@hora_Inicio", hora_Inicio);
            AddParametro("@hora_Salida", hora_Salida);
            AddParametro("@peso_Inicial", peso_Inicial);
            AddParametro("@peso_Final", peso_Final);
            AddParametro("@U_F_Programada", U_F_Programada);
            AddParametro("@heparina", heparina);
            AddParametro("@flujo_Efectivo", flujo_Efectivo);
            AddParametro("@presion_Arterial", presion_Arterial);
            AddParametro("@temperatura", temperatura);
            AddParametro("@pulso", pulso);
            AddParametro("@saturacion", saturacion);
            AddParametro("@id_hojaS", id_hojaS);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }

        public void Eliminar_Registros()
        {
            IniciarSP("eliminar_control_enfermeria");
            AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            AddParametro("@id_hojaS", id_hojaS);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }
        //Busca en los registros a un paciente por Nombre o por CI
        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from Control_Enfermeria where id_hoja_enfermeria like '" + dato + "%' or id_hojaS like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
