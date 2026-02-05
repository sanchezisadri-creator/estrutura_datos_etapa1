using System;

class Program
{
    static void Main()
    {
        int numero;
        int suma = 0;
        int i = 1;

        Console.WriteLine("Ingrese un numero que necesites saber si es perfecto: ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (i < numero)
        {
            if (numero % i == 0)
            {
                suma = suma + i;
            }

            i = i + 1;
        }

        if (suma == numero)
        {
            Console.WriteLine("El numero es perfecto.");
        }
        else
        {
            Console.WriteLine("El numero no es perfecto.");
        }
    }
}
