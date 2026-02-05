using System;

class Program
{
    static void Main()
    {
        int numero;
        int contador = 0;
        int i = 1;

        Console.WriteLine("Ingrese el numero que quieras saber si es primo o no: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero <= 1)
        {
            Console.WriteLine("El numero no es primo.");
        }
        else
        {
            while (i <= numero)
            {
                if (numero % i == 0)
                {
                    contador = contador + 1;
                }

                i = i + 1;
            }

            if (contador == 2)
            {
                Console.WriteLine("El numero es primo.");
            }
            else
            {
                Console.WriteLine("El numero no es primo.");
            }
        }
    }
}
