using System;

class program
    {
    static void Main()
    {
        Console.WriteLine(" ");

        int numero1;
        int numero2;
        int resultado;

        Console.WriteLine("Ingrese el primer numero: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        numero2 = Convert.ToInt32(Console.ReadLine());

        resultado = numero1 - numero2;

        Console.WriteLine("El resultado de la resta es: " + resultado);

    }
}
