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
                double costo;
                double total;
                double sumaCostos = 0.0; 
                double sumaTotales = 0.0;

                Console.WriteLine("Ingrese pares de datos Costo y Total. Ingrese costo 0 para finalizar.");

                while (true)
                {
                    Console.Write("Costo ingresado: ");
                    costo = Convert.ToDouble(Console.ReadLine());

                    if (costo == 0.0)
                    {
                        break;
                    }
                    else if (costo < 0)
                    {
                        Console.WriteLine("El costo ingresado no es válido. Intente de nuevo.");
                        continue;
                    }

                    Console.Write("Total ingresado: ");
                    total = Convert.ToDouble(Console.ReadLine());

                    if (total < 0)
                    {
                        Console.WriteLine("El total ingresado no es válido. Intente de nuevo.");
                        continue;
                    }

                    sumaCostos += costo;
                    sumaTotales += total;
                }

                Console.WriteLine("El total adeudado es: " + sumaTotales);
            }
        }

    }
}
}
