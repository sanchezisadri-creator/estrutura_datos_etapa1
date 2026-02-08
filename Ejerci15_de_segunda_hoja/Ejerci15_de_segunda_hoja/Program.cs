using System;

class Program
{
    static void Main()
    {
        int anio;

        Console.WriteLine("Ingrese un año: ");
        anio = Convert.ToInt32(Console.ReadLine());

        if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
        {
            Console.WriteLine("El año es bisiesto.");
        }
        else
        {
            Console.WriteLine("El año no es bisiesto.");
        }
    }
}
