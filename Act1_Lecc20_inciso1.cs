internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0;

        Console.WriteLine("Introduzca un numero");
        num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("El numero es menor a cero");
        }
        else
        {
            Console.WriteLine("El numero es igual o mayor a cero");
        }
    }
}