internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Ingrese su edad:");

        num = Convert.ToInt32(Console.ReadLine());

        if (num >= 18)
        {
            Console.WriteLine("Mayor de edad");
        }
        else
        {
            Console.WriteLine("Menor de edad");
        }

    }
}