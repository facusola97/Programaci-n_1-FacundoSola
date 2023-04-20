using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_1_while_Facundo_Sola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int valor_ingresado;
            int suma = 0;

            Console.WriteLine("Ingrese valores positivos. Ingrese 0 (cero) para finalizar.");

            while (true)
            {
                Console.Write("Valor ingresado: ");
                valor_ingresado = Convert.ToInt32(Console.ReadLine());

                if (valor_ingresado == 0)
                {
                    break;
                }
                else if (valor_ingresado < 0)
                {
                    Console.WriteLine("El valor ingresado no es positivo. Intente de nuevo.");
                    continue;
                }

                suma += valor_ingresado;
            }

            Console.WriteLine("La suma de los valores ingresados es: " + suma);

            
        }
    }
}
