using System;

class Program
{
    static void Main(string[] args)
    {
        int suma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese un valor entero: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            suma += valor;
        }

        Console.WriteLine("La suma de los 5 valores es: " + suma);
    }
}

