class Program
{
    static void Main()
    {
        int numero;
        int suma = 0;
        int digitos;

        Console.WriteLine("Ingrese un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (numero != 0)
        {
            digitos = numero % 10;
            suma = suma + digitos;
            numero = numero / 10;
        }

        Console.WriteLine("La suma de los digitos es: " + suma);
    }
}
