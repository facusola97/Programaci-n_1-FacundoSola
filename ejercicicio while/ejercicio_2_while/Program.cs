using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor_ingresado;
            int suma = 0;
            int cantidad = 0;

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
                cantidad++;
            }

            if (cantidad > 0)
            {
                double promedio = (double)suma / cantidad;
                Console.WriteLine("El promedio de los valores ingresados es: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron valores para calcular el promedio.");
            }

        }
    }
}
