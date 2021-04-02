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
            //constructor            
            this.servidor = "DESKTOP-Q4VVLI3";
            this.usuario = "lesly";
            this.contrasena = "levanito";
            this.basedatos = "Nefroone4";
            this.cmdSP = new SqlCommand();
        }

        public SqlConnection conectar()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source =" + this.servidor + "; User ID=" + this.usuario + "; Password=" + this.contrasena + "; Initial Catalog= " + this.basedatos;
            cnx.Open();
            return cnx;
        }
        public void desconectar()
        {
            SqlConnection cnx = this.conectar();
            cnx.Close();
        }

        public void IniciarSP(String sp)
        {
            //procedimiento almacenado
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
