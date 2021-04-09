using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using System.Data;

namespace capa_negocio
{
    public class ClsHojaMedica : ClsConexion
    {
        //Atributos
        private string id_hojaM;
        private string nro_Uso_Filtro;
        private string diagnostico;
        private string peso_Seco;
        private string serologia;
        private string talla;
        private string imc;
        private bool vih;
        private string acceso_Vascular;
        private string grupo_Sanguineo;
        private string solucion_Dializante;
        private string id_empleado;

        //Constructor     
        public ClsHojaMedica()
        {
            id_hojaM = "";
            nro_Uso_Filtro = "";
            diagnostico = "";
            peso_Seco = "";
            serologia = "";
            talla = "";
            imc = "";
            vih = false;
            acceso_Vascular = "";
            grupo_Sanguineo = "";
            solucion_Dializante = "";
            id_empleado = "";
        }

        //Getters y Setters       
        public string Id_hojaM { get => id_hojaM; set => id_hojaM = value; }
        public string Nro_Uso_Filtro { get => nro_Uso_Filtro; set => nro_Uso_Filtro = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Peso_Seco { get => peso_Seco; set => peso_Seco = value; }
        public string Serologia { get => serologia; set => serologia = value; }
        public string Talla { get => talla; set => talla = value; }
        public string Imc { get => imc; set => imc = value; }
        public bool Vih { get => vih; set => vih = value; }
        public string Acceso_Vascular { get => acceso_Vascular; set => acceso_Vascular = value; }
        public string Grupo_Sanguineo { get => grupo_Sanguineo; set => grupo_Sanguineo = value; }
        public string Solucion_Dializante { get => solucion_Dializante; set => solucion_Dializante = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }

        //Solo para usar la función de BoolToString que he creado en ClsHojaRegistro
        ClsHojaRegistro aux = new ClsHojaRegistro();

        //Procedimientos del Crud
        public void Guardar_Registros()
        {
            IniciarSP("insertar_hoja_medica");
            AddParametro("@nro_Uso_Filtro", nro_Uso_Filtro);
            AddParametro("@diagnostico", diagnostico);
            AddParametro("@peso_Seco", peso_Seco);
            AddParametro("@serologia", serologia);
            AddParametro("@talla", talla);
            AddParametro("@imc", imc);
            AddParametro("@vih", aux.BoolToString(vih));
            AddParametro("@acceso_Vascular", acceso_Vascular);
            AddParametro("@grupo_Sanguineo", grupo_Sanguineo);
            AddParametro("@solucion_Dializante", solucion_Dializante);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select *from Hoja_Medica";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Registros()
        {
            IniciarSP("modificar_hoja_medica");
            AddParametro("@id_hojaM", id_hojaM);
            AddParametro("@nro_Uso_Filtro", nro_Uso_Filtro);
            AddParametro("@diagnostico", diagnostico);
            AddParametro("@peso_Seco", peso_Seco);
            AddParametro("@serologia", serologia);
            AddParametro("@talla", talla);
            AddParametro("@imc", imc);
            AddParametro("@vih", aux.BoolToString(vih));
            AddParametro("@acceso_Vascular", acceso_Vascular);
            AddParametro("@grupo_Sanguineo", grupo_Sanguineo);
            AddParametro("@solucion_Dializante", solucion_Dializante);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }

        public void Eliminar_Registros()
        {
            IniciarSP("eliminar_hoja_medica");
            AddParametro("@id_hojaM", id_hojaM);
            AddParametro("@id_empleado", id_empleado);
            ejecutarSP();
        }
        //Busca en los registros a un paciente por Nombre o por CI
        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from Hoja_Medica where id_hojaM like '" + dato + "%' or id_empleado like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
