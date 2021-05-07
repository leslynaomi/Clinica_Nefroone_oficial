using capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class clsDetalleReceta : ClsConexion
    {
        //Atributos
        private string id_medicamento;
        private string id_receta;
        private string cant_recetada;

        //Constructor     
        public clsDetalleReceta()
        {
            id_medicamento = "";
            id_receta = "";
            cant_recetada = "";
        }

        public string Id_medicamento { get => id_medicamento; set => id_medicamento = value; }
        public string Id_receta { get => id_receta; set => id_receta = value; }
        public string Cant_recetada { get => cant_recetada; set => cant_recetada = value; }

        public void Guardar_Registros()
        {
            IniciarSP("insertarDetalleRec");
            AddParametro("@id_medicamento", Id_medicamento);
            AddParametro("@id_receta", Id_receta);
            AddParametro("@cant_Recetada", Cant_recetada);
            ejecutarSP();
        }
    }
}
