using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.WriteLine("Ingrese un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero es par.");
        }
        else
        {
            Console.WriteLine("El numero es impar.");
        }
    }
}