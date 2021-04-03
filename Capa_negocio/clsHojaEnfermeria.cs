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
        private string nro_registro;
        private string id_empleado;

        //Constructor
        public ClsHojaEnfermeria()
        {
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
            nro_registro = "";
            id_empleado = "";
        }

        //Getters y Setters        
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
        public string Nro_registro { get => nro_registro; set => nro_registro = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }

        //Procedimientos del Crud
        public void Guardar_Registros()
        {
            IniciarSP("insertar_control_enfermeria");
            AddParametro("@ci", ci);
            AddParametro("@nombre", nombre);
            AddParametro("@paterno", paterno);
            AddParametro("@materno", materno);
            AddParametro("@fecha_Nac", fecha_Nac);
            AddParametro("@edad", edad);
            AddParametro("@sexo", sexo);
            AddParametro("@direccion", direccion);
            ejecutarSP();
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select *from Paciente";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Registros()
        {
            IniciarSP("modificar_paciente");
            AddParametro("@ci", ci);
            AddParametro("@nombre", nombre);
            AddParametro("@paterno", paterno);
            AddParametro("@materno", materno);
            AddParametro("@fecha_Nac", fecha_Nac);
            AddParametro("@edad", edad);
            AddParametro("@sexo", sexo);
            AddParametro("@direccion", direccion);
            ejecutarSP();
        }

        public void Eliminar_Registros()
        {
            IniciarSP("eliminar_paciente");
            AddParametro("@ci", ci);
            ejecutarSP();
        }
        //Busca en los registros a un paciente por Nombre o por CI
        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from paciente where ci like '" + dato + "%' or nombre like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
