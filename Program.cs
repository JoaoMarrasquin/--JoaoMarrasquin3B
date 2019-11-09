using System;
using Tarea3.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Gasolina g = new Gasolina();
            Cliente c = new Cliente();
            Boolean ban = true;
            do
            {
                try
                {
                    Console.WriteLine("Nombres: ");
            c.Nombres = Convert.ToString(Console.ReadLine());
                    ban = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (ban);
            Boolean ban1 = true;
            do
            {
                try
                {
                    Console.WriteLine("Apellidos: ");
            c.Apellidos = Convert.ToString(Console.ReadLine());
                    ban1 = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (ban1);
            Console.WriteLine("Cédula: ");
            c.Cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dirección: " );
            c.Dirreccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n------TIPOS DE GASOLINA------\n" +
                      "1.- Gasolina Super\n" +
                      "2.- Gasolina Extra\n");
            Console.WriteLine("Escoja el tipo de gasolina que desea llenar" );
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    g.Extra();
                    Console.WriteLine("------------DATOS PERSONALES EN LA FACTURA----------");
                    Console.WriteLine("Nombres: " + c.Nombres);
                    Console.WriteLine("Apellidos " + c.Apellidos);
                    Console.WriteLine("CI: " + c.Cedula);
                    Console.WriteLine("Direccion: " + c.Dirreccion);
                    break;
                case 2:
                    g.Super();
                    Console.WriteLine("------------DATOS PERSONALES EN LA FACTURA----------");
                    Console.WriteLine("Nombres: "+c.Nombres);
                    Console.WriteLine("Apellidos "+c.Apellidos);
                    Console.WriteLine("CI: "+c.Cedula);
                    Console.WriteLine("Direccion: "+c.Dirreccion);
                    break;
            }
            Console.ReadKey();
        }
    }
}