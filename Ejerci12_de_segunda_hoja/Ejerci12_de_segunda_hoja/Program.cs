using System;

class Program
{
    static void Main()
    {
        int n;
        int a = 0;
        int b = 1;
        int c;
        int contador = 0;

        Console.WriteLine("Ingrese la cantidad de numeros Fibonacci a mostrar: ");
        n = Convert.ToInt32(Console.ReadLine());

        while (contador < n)
        {
            Console.WriteLine(a);

            c = a + b;
            a = b;
            b = c;

            contador = contador + 1;
        }
    }
}
