using System;

class Program
{
    static void Main()
    {
        int numero;
        int contador = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero == 0)
        {
            contador = 1;
        }
        else
        {
            while (numero != 0)
            {
                numero = numero / 10;
                contador = contador + 1;
            }
        }

        Console.WriteLine("La cantidad de digitos es: " + contador);
    }
}
