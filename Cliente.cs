﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Clases
{
    public class Cliente
    {
        private string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set {apellidos = value; }
        }
        private int cedula;
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private string direccion;

        public string Dirreccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
