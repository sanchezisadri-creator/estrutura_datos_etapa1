using System;

class Program
{
    static void Main()
    {
        string texto;
        string invertido = "";
        int i;

        Console.WriteLine("Ingrese una cadena de texto: ");
        texto = Console.ReadLine();

        i = texto.Length - 1;

        while (i >= 0)
        {
            invertido = invertido + texto[i];
            i = i - 1;
        }

        Console.WriteLine("Texto invertido: " + invertido);
    }
}