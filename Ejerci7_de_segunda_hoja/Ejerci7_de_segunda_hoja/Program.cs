using System;

class Program
{
    static void Main()
    {
        int numero;
        int factorial = 1;
        int i = 1;

        Console.WriteLine("Ingrese un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("No se puede calcular el factorial de un numero negativo.");
        }
        else
        {
            while (i <= numero)
            {
                factorial = factorial * i;
                i = i + 1;
            }

            Console.WriteLine("El factorial es: " + factorial);
        }
    }
}
