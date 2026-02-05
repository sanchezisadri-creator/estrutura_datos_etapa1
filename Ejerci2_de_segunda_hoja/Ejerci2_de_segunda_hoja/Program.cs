using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.WriteLine("Ingrese para saber si es positivo o negativo: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El numero es positivo (+).");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El numero es negativo (-).");
        }
        else
        {
            Console.WriteLine("El numero es neutro (0).");
        }
    }
}
