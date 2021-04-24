using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using capa_datos;

namespace capa_negocio
{
    public class ClsHojaSecretaria : ClsConexion
    {
        //Atributos
        private string id_hojaS;
        private string nro_familiar_Contacto;
        private bool formulario_Referencia;
        private bool carta_Negativa;
        private string grado_Intruccion;
        private string red;
        private string municipio;
        private string seguro;
        private string fecha_PHemodialisis;
        private string acceso_Vascular;
        private string CI;
        private string id_empleado;

        //Constructor
        public ClsHojaSecretaria()
        {
            id_hojaS = "";
            nro_familiar_Contacto = "";
            formulario_Referencia = false;
            carta_Negativa = false;
            grado_Intruccion = "";
            red = "";
            municipio = "";
            seguro = "";
            fecha_PHemodialisis = "";
            CI = "";
            id_empleado = "";
        }

        //Getters y Setters de los atributos
        public string Id_hojaS { get => id_hojaS; set => id_hojaS = value; }
        public string Nro_familiar_Contacto { get => nro_familiar_Contacto; set => nro_familiar_Contacto = value; }
        public bool Formulario_Referencia { get => formulario_Referencia; set => formulario_Referencia = value; }
        public bool Carta_Negativa { get => carta_Negativa; set => carta_Negativa = value; }
        public string Grado_Intruccion { get => grado_Intruccion; set => grado_Intruccion = value; }
        public string Red { get => red; set => red = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Seguro { get => seguro; set => seguro = value; }
        public string Fecha_PHemodialisis { get => fecha_PHemodialisis; set => fecha_PHemodialisis = value; }
        public string Acceso_Vascular { get => acceso_Vascular; set => acceso_Vascular = value; }
        public string CI1 { get => CI; set => CI = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }

        //Una función solo para convertir bool a string de forma simple
        public string BoolToString(bool entrada) 
        {
            string resultado = "0";
            if (entrada == true) { resultado = "1"; }
            return resultado; 
        }

        //Procedimientos del Crud
        public void Guardar_Registros()
        {
            IniciarSP("insertar_hoja_sec");
            AddParametro("@nro_familiar_Contacto", nro_familiar_Contacto);
            AddParametro("@formulario_Referencia", BoolToString(formulario_Referencia));
            AddParametro("@carta_Negativa", BoolToString(carta_Negativa));
            AddParametro("@grado_Intruccion", grado_Intruccion);
            AddParametro("@red", red);
            AddParametro("@municipio", municipio);
            AddParametro("@seguro", seguro);
            AddParametro("@fecha_PHemodialisis", fecha_PHemodialisis);
            AddParametro("@acceso_Vascular", acceso_Vascular);
            AddParametro("@CI", CI);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select pac.ci,nombre,paterno,materno,fecha_Nac as 'fecha de nacimiento',edad,sexo,direccion,nro_familiar_Contacto as 'Teléfono',formulario_Referencia,carta_Negativa,grado_Intruccion as 'grado de instrucción',red,municipio,seguro,fecha_PHemodialisis as 'primera fecha de hemodiálisis',acceso_Vascular from Paciente as pac,Hoja_Secretaria as sec where pac.ci=sec.ci";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Registros()
        {
            IniciarSP("modificar_hoja_sec");
            AddParametro("@id_hojaS", id_hojaS);
            AddParametro("@nro_familiar_Contacto", nro_familiar_Contacto);
            AddParametro("@formulario_Referencia", BoolToString(formulario_Referencia));
            AddParametro("@carta_Negativa", BoolToString(carta_Negativa));
            AddParametro("@grado_Intruccion", grado_Intruccion);
            AddParametro("@red", red);
            AddParametro("@municipio", municipio);
            AddParametro("@seguro", seguro);
            AddParametro("@fecha_PHemodialisis", fecha_PHemodialisis);
            AddParametro("@acceso_Vascular", acceso_Vascular);
            AddParametro("@CI", CI);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }

        public void Eliminar_Registros()
        {
            IniciarSP("eliminar_hoja_sec");
            AddParametro("@id_hojaS", id_hojaS);
            AddParametro("@CI", CI);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }
        
        public DataSet Buscar_Edad(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select pac.ci,nombre,paterno,materno,fecha_Nac as 'fecha de nacimiento',edad,sexo,direccion,nro_familiar_Contacto as 'Teléfono',formulario_Referencia,carta_Negativa,grado_Intruccion as 'grado de instrucción',red,municipio,seguro,fecha_PHemodialisis as 'primera fecha de hemodiálisis',acceso_Vascular from Paciente as pac,Hoja_Secretaria as sec where pac.ci=sec.ci and edad like " + dato;
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

        public DataSet Buscar_Name(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select pac.ci,nombre,paterno,materno,fecha_Nac as 'fecha de nacimiento',edad,sexo,direccion,nro_familiar_Contacto as 'Teléfono',formulario_Referencia,carta_Negativa,grado_Intruccion as 'grado de instrucción',red,municipio,seguro,fecha_PHemodialisis as 'primera fecha de hemodiálisis',acceso_Vascular from Paciente as pac,Hoja_Secretaria as sec where pac.ci=sec.ci and nombre like '" + dato + "%'";
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

        public DataSet Buscar_Apellido(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select pac.ci,nombre,paterno,materno,fecha_Nac as 'fecha de nacimiento',edad,sexo,direccion,nro_familiar_Contacto as 'Teléfono',formulario_Referencia,carta_Negativa,grado_Intruccion as 'grado de instrucción',red,municipio,seguro,fecha_PHemodialisis as 'primera fecha de hemodiálisis',acceso_Vascular from Paciente as pac,Hoja_Secretaria as sec where pac.ci=sec.ci and (paterno like '" + dato + "%') or materno like '" + dato + "%')";
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

        public DataSet Buscar_Ci(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select pac.ci,nombre,paterno,materno,fecha_Nac as 'fecha de nacimiento',edad,sexo,direccion,nro_familiar_Contacto as 'Teléfono',formulario_Referencia,carta_Negativa,grado_Intruccion as 'grado de instrucción',red,municipio,seguro,fecha_PHemodialisis as 'primera fecha de hemodiálisis',acceso_Vascular from Paciente as pac,Hoja_Secretaria as sec where pac.ci=sec.ci and pac.ci like '" + dato + "%')";
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
