using System;

class Program
{
    static void Main()
    {
        int inicio;
        int final;

        Console.WriteLine("Ingrese el numero de inicio: ");
        inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el numero final: ");
        final = Convert.ToInt32(Console.ReadLine());

        while (inicio <= final)
        {
            Console.WriteLine(inicio);
            inicio = inicio + 1;
        }
    }
}
