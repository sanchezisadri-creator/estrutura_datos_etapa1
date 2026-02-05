using System;

class program
{
    static void Main()
    {
        Console.WriteLine(" ");

        string nombre;
        int edad;

        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine($"Hola {nombre}, eres mayor.");
        }
        else
        {
            Console.WriteLine($"Hola {nombre}, eres menor .");
        }
    }
}
