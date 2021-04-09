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
    public class ClsHojaRegistro : ClsConexion
    {
        //Atributos
        private string nro_registro;
        private string nro_familiar_Contacto;
        private bool formulario_Referencia;
        private string carta_Negativa;
        private string grado_Intruccion;
        private string red;
        private string municipio;
        private string seguro;
        private string fecha_PHemodialisis;
        private string CI;
        private string id_empleado;

        //Constructor
        public ClsHojaRegistro()
        {
            nro_registro = "";
            nro_familiar_Contacto = "";
            formulario_Referencia = false;
            carta_Negativa = "";
            grado_Intruccion = "";
            red = "";
            municipio = "";
            seguro = "";
            fecha_PHemodialisis = "";
            CI = "";
            id_empleado = "";
        }

        //Getters y Setters de los atributos
        public string Nro_registro { get => nro_registro; set => nro_registro = value; }
        public string Nro_familiar_Contacto { get => nro_familiar_Contacto; set => nro_familiar_Contacto = value; }
        public bool Formulario_Referencia { get => formulario_Referencia; set => formulario_Referencia = value; }
        public string Carta_Negativa { get => carta_Negativa; set => carta_Negativa = value; }
        public string Grado_Intruccion { get => grado_Intruccion; set => grado_Intruccion = value; }
        public string Red { get => red; set => red = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Seguro { get => seguro; set => seguro = value; }
        public string Fecha_PHemodialisis { get => fecha_PHemodialisis; set => fecha_PHemodialisis = value; }
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
            IniciarSP("insertar_hoja_reg");

            //No necesito agregar el id que es Nro_registro por que es autoincrementable en la base de datos
            //AddParametro("@Nro_registro", Nro_registro);

            AddParametro("@nro_familiar_Contacto", nro_familiar_Contacto);
            AddParametro("@formulario_Referencia", BoolToString(formulario_Referencia));
            AddParametro("@carta_Negativa", carta_Negativa);
            AddParametro("@grado_Intruccion", grado_Intruccion);
            AddParametro("@red", red);
            AddParametro("@municipio", municipio);
            AddParametro("@seguro", seguro);
            AddParametro("@fecha_PHemodialisis", fecha_PHemodialisis);
            AddParametro("@CI", CI);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select *from Hoja_Registro";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Registros()
        {
            IniciarSP("modificar_hoja_reg");
            AddParametro("@Nro_registro", Nro_registro);
            AddParametro("@nro_familiar_Contacto", nro_familiar_Contacto);
            AddParametro("@formulario_Referencia", BoolToString(formulario_Referencia));
            AddParametro("@carta_Negativa", carta_Negativa);
            AddParametro("@grado_Intruccion", grado_Intruccion);
            AddParametro("@red", red);
            AddParametro("@municipio", municipio);
            AddParametro("@seguro", seguro);
            AddParametro("@fecha_PHemodialisis", fecha_PHemodialisis);
            AddParametro("@CI", CI);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }

        public void Eliminar_Registros()
        {
            IniciarSP("eliminar_hoja_reg");
            AddParametro("@nro_reg", Nro_registro);
            AddParametro("@CI", CI);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }
        
        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from hoja_registro where ci like '" + dato + "%' or nombre like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
