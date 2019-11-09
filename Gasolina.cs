using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Clases
{
    public class Gasolina
    {
        Cliente cl = new Cliente();
        public void Super()
        {
            float precio = 2.00F, cantidad, subtotal, iva, total;       
            Console.WriteLine("Ingrese la cantidad de galones a llenar");
            cantidad = float.Parse(Console.ReadLine());
            subtotal= cantidad* precio;
            iva = subtotal * 0.12F;
            total = subtotal + iva;
            Console.WriteLine("-------DATOS DE LA FACTURA GENERADA POR LA COMPRA DE GASOLINA------------");          
            Console.WriteLine(" ");
            Console.WriteLine("La gasolina a llenar fue de tipo: Super");
            Console.WriteLine("Fue un total de: "+cantidad+ " galones ");
            Console.WriteLine("El precio de la gasolina está a: " + precio + " dólares por galón");
            Console.WriteLine("Subtotal: "+subtotal);
            Console.WriteLine("IVA: "+iva);
            Console.WriteLine("Total a pagar: "+total);
        }
        public void Extra()
        {
            float precio = 1.50F, cantidad, subtotal, iva, total;
            Console.WriteLine("Ingrese la cantidad de galones a llenar");
            cantidad = float.Parse(Console.ReadLine());
            subtotal = cantidad * precio;
            iva = subtotal * 0.12F;
            total = subtotal + iva;
            Console.WriteLine("-------DATOS DE LA FACTURA GENERADA POR LA COMPRA DE GASOLINA------------");
            Console.WriteLine(" ");
            Console.WriteLine("La gasolina a llenar fue de tipo: Extra");
            Console.WriteLine("Fue un total de: " + cantidad + " galones ");
            Console.WriteLine("El precio de la gasolina está a: " + precio + " dólares por galón");
            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("IVA: " + iva);
            Console.WriteLine("Total a pagar: " + total);
        }
      

    }
}
