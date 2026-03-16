internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Numero negativos y positivos");
        int num;
        Console.WriteLine("Dame un numero entero");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine("Soy un numero positivo");
        }
        else
        {
            Console.WriteLine("Soy un numero negativo");
        }
    }
}