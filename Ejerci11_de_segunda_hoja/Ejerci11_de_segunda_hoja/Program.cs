using System;

class Program
{
    static void Main()
    {
        int num1;
        int num2;
        int num3;

        Console.WriteLine("Ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer numero: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("El mayor es: " + num1);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine("El mayor es: " + num2);
        }
        else
        {
            Console.WriteLine("El mayor es: " + num3);
        }
    }
}
