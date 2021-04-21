using capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class clsDetalle_Recetada : ClsConexion
    {


            //Atributos
            private string id_medicamento;
            private string id_receta;
            private string cant_recetada;
         

            //Constructor     
            public clsDetalle_Recetada()
            {
            id_medicamento = "";
            id_receta = "";
            cant_recetada = "";
        }


        }
}
