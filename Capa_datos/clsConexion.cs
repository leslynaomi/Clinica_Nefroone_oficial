using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace capa_datos
{
    public class ClsConexion
    {
        private String servidor;
        private String basedatos;
        private String usuario;
        private String contrasena;
        private SqlCommand cmdSP;//store procedure ''procedimiento almacenado

        public ClsConexion()
        {
            //constructor Paul 
            this.servidor = "Lenovo";
            this.usuario = "Pol";
            this.contrasena = "Pol";
            this.basedatos = "Nefroone13";
            this.cmdSP = new SqlCommand();

            //constructor Alejandra
            //this.servidor = "ALEJANDRA-PC";
            //this.usuario = "yo";
            //this.contrasena = "123456789";
            //this.basedatos = "Nefroone";
            //this.cmdSP = new SqlCommand();

            //constructor Lesly
            //Solo descomentan la línea de código que necesiten
            /* this.servidor = "DESKTOP-Q4VVLI3";
             this.usuario = "lesly";
             this.contrasena = "levanito";
             this.basedatos = "Nefroone4";
             this.cmdSP = new SqlCommand();*/
        }

        public SqlConnection conectar()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source =" + this.servidor + "; User ID=" + this.usuario + "; Password=" + this.contrasena + "; Initial Catalog= " + this.basedatos;
            cnx.Open();
            return cnx;
        }

        //Invocación del Procedimiento Almacenado para validar el usuario y contraseña
        public DataTable D_users(E_Users obje)
        {
            SqlCommand cmd = new SqlCommand("sp_login", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", obje.Usuario);
            cmd.Parameters.AddWithValue("@passwd", obje.Contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Validación del usuario logeado para mostrarle su respectivo menú
        //Obtiene el tipo de usuario/empleado en un Datatable
        public DataTable EncontrarTipoUsuario(String Usuario, String Contraseña)
        {
            SqlCommand cmd = new SqlCommand("encontrar_tipo_usuario", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", Usuario);
            cmd.Parameters.AddWithValue("@passwd", Contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Devuelve el ID usuario de un empleado con solo su user y password
        public DataTable EncontrarIDUsuario(String Usuario, String Contraseña)
        {
            SqlCommand cmd = new SqlCommand("encontrar_ID_empleado", conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", Usuario);
            cmd.Parameters.AddWithValue("@passwd", Contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void desconectar()
        {
            SqlConnection cnx = this.conectar();
            cnx.Close();
        }

        public void IniciarSP(String sp)
        {
            cmdSP.Connection = conectar();
            cmdSP.CommandType = CommandType.StoredProcedure;
            cmdSP.CommandText = sp;
        }

        public void AddParametro(String param, String valor)
        {
            SqlParameter par = new SqlParameter();
            par.ParameterName = param;
            par.Value = valor;
            cmdSP.Parameters.Add(par);            
        }

        public void ejecutarSP()
        {
            SqlDataReader spResult;
            cmdSP.Prepare();            
            spResult = cmdSP.ExecuteReader();            
            cmdSP.Parameters.Clear();
        }

        public void ejecutarSQL(String s, String nTable, DataSet ds)
        {
            SqlDataAdapter sqlAdapter;
            sqlAdapter = new SqlDataAdapter(s, conectar());
            sqlAdapter.Fill(ds, nTable);
            desconectar();
        }
    }
}
