using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using System.Data;

namespace capa_negocio
{
    public class ClsEvoloucionYTratamiento:ClsConexion
    {
        //Atributos
        private string id_evolucion_tratamiento;
        private string nro_Seguro;
        private string ultra_Filtracion;
        private string duracion;
        private string flujo_Dialisis;
        private string evolucion_Clinica;
        private string detalles_Medicacion;
        private string tipo_Tratamiento;
        private string id_hoja_enfermeria;
        private string id_empleado;        

        //Constructor     
        public ClsEvoloucionYTratamiento()
        {
             id_evolucion_tratamiento = "";
             nro_Seguro = "";
             ultra_Filtracion = "";
             duracion = "";
             flujo_Dialisis = "";
             evolucion_Clinica = "";
             detalles_Medicacion = "";
             tipo_Tratamiento = "";
             id_hoja_enfermeria = "";
             id_empleado = "";
        }

        //Getters y Setters       
        public string Id_evolucion_tratamiento { get => id_evolucion_tratamiento; set => id_evolucion_tratamiento = value; }
        public string Nro_Seguro { get => nro_Seguro; set => nro_Seguro = value; }
        public string Ultra_Filtracion { get => ultra_Filtracion; set => ultra_Filtracion = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Flujo_Dialisis { get => flujo_Dialisis; set => flujo_Dialisis = value; }
        public string Evolucion_Clinica { get => evolucion_Clinica; set => evolucion_Clinica = value; }
        public string Detalles_Medicacion { get => detalles_Medicacion; set => detalles_Medicacion = value; }
        public string Tipo_Tratamiento { get => tipo_Tratamiento; set => tipo_Tratamiento = value; }
        public string Id_hoja_enfermeria { get => id_hoja_enfermeria; set => id_hoja_enfermeria = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }

        //Procedimientos del Crud
        public void Guardar_Registros()
        {
            IniciarSP("insertar_evolucion_y_tratamiento");
            AddParametro("@nro_Seguro", nro_Seguro);
            AddParametro("@ultra_Filtracion", ultra_Filtracion);
            AddParametro("@duracion", duracion);
            AddParametro("@flujo_Dialisis", flujo_Dialisis);
            AddParametro("@evolucion_Clinica", evolucion_Clinica);
            AddParametro("@detalles_Medicacion", detalles_Medicacion);
            AddParametro("@tipo_Tratamiento", tipo_Tratamiento);
            AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();            
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select *from Evolucion_Tratamiento";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Registros()
        {
            IniciarSP("modificar_evolucion_y_tratamiento");
            AddParametro("@id_evolucion_tratamiento", id_evolucion_tratamiento);
            AddParametro("@nro_Seguro", nro_Seguro);
            AddParametro("@ultra_Filtracion", ultra_Filtracion);
            AddParametro("@duracion", duracion);
            AddParametro("@flujo_Dialisis", flujo_Dialisis);
            AddParametro("@evolucion_Clinica", evolucion_Clinica);
            AddParametro("@detalles_Medicacion", detalles_Medicacion);
            AddParametro("@tipo_Tratamiento", tipo_Tratamiento);
            AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }

        public void Eliminar_Registros()
        {
            IniciarSP("eliminar_evolucion_y_tratamiento");
            AddParametro("@id_evolucion_tratamiento", id_evolucion_tratamiento);
            AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }
        //Busca en los registros a un paciente por Nombre o por CI
        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from Evolucion_Tratamiento where id_evolucion_tratamiento like '" + dato + "%' or id_empleado like '" + dato + "%' or id_hoja_enfermeria like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
