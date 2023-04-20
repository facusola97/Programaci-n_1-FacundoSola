using System;

class Program
{
    static void Main(string[] args)
    {
        double Total_a_pagar = 0.0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese los datos de la compra N°: " + (i + 1));
            Console.Write("Ingrese el valor total de la compra: ");
            double total = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Ingrese el costo de la compra: ");
            double costo = Convert.ToDouble(Console.ReadLine());

            Total_a_pagar += total - costo;
        }

        Console.WriteLine("El total adeudado es: " + Total_a_pagar);
    }
}

