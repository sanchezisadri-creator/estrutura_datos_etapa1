using System;

class Program
{
    static void Main()
    {
        int numero;
        int i = 1;
        int resultado;

        Console.WriteLine("Ingrese un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (i <= 10)
        {
            resultado = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + resultado);
            i = i + 1;
        }
    }
}
