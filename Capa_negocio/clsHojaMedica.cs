﻿using System;
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
        private string ci;
        private string nombre;
        private string paterno;
        private string materno;
        private string fecha_Nac;
        private string edad;
        private string sexo;
        private string direccion;

        //Constructor
        public ClsHojaMedica()
        {
            ci = "";
            nombre = "";
            paterno = "";
            materno = "";
            Fecha_Nac = "";
            edad = "";
            sexo = "";
            direccion = "";
        }

        //Getters y Setters
        public string Ci { get => ci; set => ci = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string Fecha_Nac { get => fecha_Nac; set => fecha_Nac = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        //Procedimientos del Crud

        public void Guardar_Registros()
        {
            IniciarSP("insertar_paciente");
            AddParametro("@ci", ci);
            AddParametro("@nombre", nombre);
            AddParametro("@paterno", paterno);
            AddParametro("@materno", materno);
            AddParametro("@fecha_Nac", fecha_Nac);
            AddParametro("@edad", edad);
            AddParametro("@sexo", sexo);
            AddParametro("@direccion", direccion);
            ejecutarSP();
        }

        public DataSet Mostrar_Registros()
        {
            string s;
            s = "select *from Paciente";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tac", ds);
            return ds;
        }

        public void Modificar_Registros()
        {
            IniciarSP("modificar_paciente");
            AddParametro("@ci", ci);
            AddParametro("@nombre", nombre);
            AddParametro("@paterno", paterno);
            AddParametro("@materno", materno);
            AddParametro("@fecha_Nac", fecha_Nac);
            AddParametro("@edad", edad);
            AddParametro("@sexo", sexo);
            AddParametro("@direccion", direccion);
            ejecutarSP();
        }

        public void Eliminar_Registros()
        {
            IniciarSP("eliminar_paciente");
            AddParametro("@ci", ci);
            ejecutarSP();
        }
        //Busca en los registros a un paciente por Nombre o por CI
        public DataSet Buscar_Registros(string dato)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select *from paciente where ci like '" + dato + "%' or nombre like '" + dato + "%'";
            ejecutarSQL(s, "tac", ds);
            return ds;
        }
    }
}
