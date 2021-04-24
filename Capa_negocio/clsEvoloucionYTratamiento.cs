using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;

namespace capa_negocio
{
    public class ClsEvoloucionYTratamiento:ClsConexion
    {
        //Atributos
        private string id_hojaEvolT;
        private string duracion;
        private string flujo_Dialisis;
        private string evolucion_Clinica;
        private string nro_Uso_Filtro;
        private string diagnostico;
        private string peso_Seco;
        private string serologia;
        private string talla;
        private string imc;
        private bool vih; 
        private string grupo_Sanguineo;
        private string solucion_Dializante;        
        private string id_sesion;
        private string id_empleado;        

        //Constructor     
        public ClsEvoloucionYTratamiento()
        {
             id_hojaEvolT = "";
             duracion = "";
             flujo_Dialisis = "";
             evolucion_Clinica = "";
             nro_Uso_Filtro = "";
             diagnostico = "";
             peso_Seco = "";
             serologia = "";
             talla = "";
             imc = "";
             vih = false;
             grupo_Sanguineo = "";
             solucion_Dializante = "";
             id_sesion = "";
             id_empleado = "";        
        }

        //Getters y Setters       
        public string Id_hojaEvolT { get => id_hojaEvolT; set => id_hojaEvolT = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Flujo_Dialisis { get => flujo_Dialisis; set => flujo_Dialisis = value; }
        public string Evolucion_Clinica { get => evolucion_Clinica; set => evolucion_Clinica = value; }
        public string Nro_Uso_Filtro { get => nro_Uso_Filtro; set => nro_Uso_Filtro = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Peso_Seco { get => peso_Seco; set => peso_Seco = value; }
        public string Serologia { get => serologia; set => serologia = value; }
        public string Talla { get => talla; set => talla = value; }
        public string Imc { get => imc; set => imc = value; }
        public bool Vih { get => vih; set => vih = value; }
        public string Grupo_Sanguineo { get => grupo_Sanguineo; set => grupo_Sanguineo = value; }
        public string Solucion_Dializante { get => solucion_Dializante; set => solucion_Dializante = value; }
        public string Id_sesion { get => id_sesion; set => id_sesion = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }

        //Solo para usar la función de BoolToString que he creado en ClsHojaSecretaria
        ClsHojaSecretaria aux = new ClsHojaSecretaria();

        //Procedimientos del Crud
        public void Guardar_Registros()
        {
            IniciarSP("insertar_evolucion_y_tratamiento");
            AddParametro("@duracion", duracion);
            AddParametro("@flujo_Dialisis", flujo_Dialisis);
            AddParametro("@evolucion_Clinica", evolucion_Clinica);
            AddParametro("@nro_Uso_Filtro", nro_Uso_Filtro);
            AddParametro("@diagnostico", diagnostico);
            AddParametro("@peso_Seco", peso_Seco);
            AddParametro("@serologia", serologia);
            AddParametro("@talla", talla);
            AddParametro("@imc", imc);
            AddParametro("@vih", aux.BoolToString(vih));
            AddParametro("@grupo_Sanguineo", grupo_Sanguineo);
            AddParametro("@solucion_Dializante", solucion_Dializante);
            AddParametro("@id_sesion", id_sesion);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();            
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select nro_Sesion_HD,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,nombre as 'Médico',paterno as 'Médico' from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        /*
        public void Modificar_Registros()
        {
            IniciarSP("modificar_evolucion_y_tratamiento");
            AddParametro("@id_hojaEvolT", id_hojaEvolT);
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
            AddParametro("@id_hojaEvolT", id_hojaEvolT);
            AddParametro("@id_hoja_enfermeria", id_hoja_enfermeria);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }*/

        //Busca en los registros a un paciente por Nombre o por CI
        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from Evolucion_Tratamiento where id_hojaEvolT like '" + dato + "%' or id_empleado like '" + dato + "%' or id_hoja_enfermeria like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
