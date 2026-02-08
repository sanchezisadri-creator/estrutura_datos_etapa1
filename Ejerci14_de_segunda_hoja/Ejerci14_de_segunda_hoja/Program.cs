using System;

class Program
{
    static void Main()
    {
        int cantidad;
        int i = 1;
        int numero;
        int suma = 0;
        double promedio;

        Console.WriteLine("¿Cuantos numeros desea ingresar?");
        cantidad = Convert.ToInt32(Console.ReadLine());

        while (i <= cantidad)
        {
            Console.WriteLine("Ingrese el numero " + i + ": ");
            numero = Convert.ToInt32(Console.ReadLine());
            suma = suma + numero;
            i = i + 1;
        }

        promedio = (double)suma / cantidad;

        Console.WriteLine("El promedio es: " + promedio);
    }
}
