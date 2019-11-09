using System;
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
            set {
                if (value.Split().Length < 2)
                {
                    throw new Exception("Ingrese sus dos nombres");
                }
                nombres = value; }
        }
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set {
                if (value.Split().Length < 2)
                {
                    throw new Exception("Ingrese sus dos apellidos");
                }
                apellidos = value; }
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
