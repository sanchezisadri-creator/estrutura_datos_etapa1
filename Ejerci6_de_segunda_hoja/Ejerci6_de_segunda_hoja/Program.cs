using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int inicio;
        int final;
        int suma = 0;

        Console.WriteLine("Ingrese el numero de inicio: ");
        inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el numero final: ");
        final = Convert.ToInt32(Console.ReadLine());

        while (inicio <= final)
        {
            suma = suma + inicio;
            inicio = inicio + 1;
        }

        Console.WriteLine("La suma de los numeros es: " + suma);
    }
}
