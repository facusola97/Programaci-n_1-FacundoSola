using System;

class Program
{
    static void Main(string[] args)
    {
        double suma = 0.0;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            suma += numero;
        }

        double promedio = suma / 8;
        Console.WriteLine("El promedio de los 8 números es: " + promedio);
    }
}
