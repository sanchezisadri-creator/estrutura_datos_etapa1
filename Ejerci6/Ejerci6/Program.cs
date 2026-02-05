using System;

class Program
{
    static void Main()
    {
        int numero = 1;

        while (numero <= 100)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero);
            }

            numero = numero + 1;
        }
    }
}
