using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" ");

        int numero1;
        int numero2;
        int resultado;

        Console.WriteLine("Ingrese el primer número:");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        numero2 = Convert.ToInt32(Console.ReadLine());

        resultado = numero1 + numero2;

        Console.WriteLine("El resultado de la suma es: " + resultado);

        Console.WriteLine("La suma de " + numero1 + " y " + numero2 + " es " + resultado);
    }
}
