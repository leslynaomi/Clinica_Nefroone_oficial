using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using capa_datos;
using System.Windows.Forms;

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
            s = "select nro_Sesion_HD,pac.nombre,pac.paterno,pac.materno,pac.ci,edad,sexo,seguro,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,emp.nombre as 'Nombre del Médico',emp.paterno as 'Apellido del Médico' from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp,Paciente as pac where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado and pac.ci = sec.ci";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        //Busca en los registros de evolución y tratamiento por fecha
        public DataSet Buscar_fecha_Sesion(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select nro_Sesion_HD,pac.nombre,pac.paterno,pac.materno,pac.ci,edad,sexo,seguro,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,emp.nombre as 'Nombre del Médico',emp.paterno as 'Apellido del Médico' from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp,Paciente as pac where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado and pac.ci = sec.ci and fecha_Sesion = '" + dato + "'";
            try
            {
                ejecutarSQL(s, "tac", ds);
            }
            catch (Exception er)
            {
                MessageBox.Show("No se encuentra el registro" + er.ToString());
            }
            return ds;
        }

        //Busca en los registros de evolución y tratamiento por acceso vascular
        public DataSet Buscar_acceso_Vascular(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select nro_Sesion_HD,pac.nombre,pac.paterno,pac.materno,pac.ci,edad,sexo,seguro,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,emp.nombre as 'Nombre del Médico',emp.paterno as 'Apellido del Médico' from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp,Paciente as pac where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado and pac.ci = sec.ci and acceso_Vascular = '" + dato + "'";
            try
            {
                ejecutarSQL(s, "tac", ds);
            }
            catch (Exception er)
            {
                MessageBox.Show("No se encuentra el registro" + er.ToString());
            }
            return ds;
        }

        //Busca en los registros de evolución y tratamiento por VIH
        public DataSet Buscar_VIH(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select nro_Sesion_HD,pac.nombre,pac.paterno,pac.materno,pac.ci,edad,sexo,seguro,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,emp.nombre as 'Nombre del Médico',emp.paterno as 'Apellido del Médico' from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp,Paciente as pac where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado and pac.ci = sec.ci and vih = '" + dato + "'";
            try
            {
                ejecutarSQL(s, "tac", ds);
            }
            catch (Exception er)
            {
                MessageBox.Show("No se encuentra el registro" + er.ToString());
            }
            return ds;
        }

        //Busca en los registros de evolución y tratamiento por grupo sanguíneo del paciente
        public DataSet Buscar_grupo_Sanguineo(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select nro_Sesion_HD,pac.nombre,pac.paterno,pac.materno,pac.ci,edad,sexo,seguro,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,emp.nombre as 'Nombre del Médico',emp.paterno as 'Apellido del Médico' from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp,Paciente as pac where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado and pac.ci = sec.ci and grupo_Sanguineo like '" + dato + "%'";
            try
            {
                ejecutarSQL(s, "tac", ds);
            }
            catch (Exception er)
            {
                MessageBox.Show("No se encuentra el registro" + er.ToString());
            }
            return ds;
        }

        //Busca en los registros de evolución y tratamiento por nombre del médico que ingresó el registro de evolución y tratamiento
        public DataSet Buscar_nombre_Medico(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select nro_Sesion_HD,pac.nombre,pac.paterno,pac.materno,pac.ci,edad,sexo,seguro,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,emp.nombre as 'Nombre del Médico',emp.paterno as 'Apellido del Médico' from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp,Paciente as pac where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado and pac.ci = sec.ci and emp.nombre like '" + dato + "%'";
            try
            {
                ejecutarSQL(s, "tac", ds);
            }
            catch (Exception er)
            {
                MessageBox.Show("No se encuentra el registro" + er.ToString());
            }
            return ds;
        }

        //Busca en los registros de evolución y tratamiento por apellido del médico que ingresó el registro de evolución y tratamiento
        public DataSet Buscar_apellido_Medico(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select nro_Sesion_HD,pac.nombre,pac.paterno,pac.materno,pac.ci,edad,sexo,seguro,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,emp.nombre as 'Nombre del Médico',emp.paterno as 'Apellido del Médico' from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp,Paciente as pac where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado and pac.ci = sec.ci and emp.paterno like '" + dato + "%' or emp.materno like '" + dato + "%'";
            try
            {
                ejecutarSQL(s, "tac", ds);
            }
            catch (Exception er)
            {
                MessageBox.Show("No se encuentra el registro" + er.ToString());
            }
            return ds;
        }
    }
}
