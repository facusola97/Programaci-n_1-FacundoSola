using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant_productos;
            double total_a_pagar = 0;

            Console.Write("Ingrese la cantidad de productos comprados: ");
            cant_productos = Convert.ToInt32(Console.ReadLine());

            while (cant_productos > 0)
            {
                double costoUnitario; 
                double cantidadConsumida;

                Console.Write("Ingrese el costo unitario del producto: ");
                costoUnitario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la cantidad consumida del producto: ");
                cantidadConsumida = Convert.ToDouble(Console.ReadLine());

                total_a_pagar += costoUnitario * cantidadConsumida;
                cant_productos--;
            }

            Console.WriteLine("El total a pagar es: " + total_a_pagar);




        }
    }
}
