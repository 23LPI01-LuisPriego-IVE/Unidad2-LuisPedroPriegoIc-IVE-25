internal class Program
{
    private static void Main(string[] args)
    {
        double n1, n2, n3, n4, n5, prom;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Ingrese 5 calificaciones:");

        n1 = Convert.ToDouble(Console.ReadLine());
        n2 = Convert.ToDouble(Console.ReadLine());
        n3 = Convert.ToDouble(Console.ReadLine());
        n4 = Convert.ToDouble(Console.ReadLine());
        n5 = Convert.ToDouble(Console.ReadLine());

        prom = (n1 + n2 + n3 + n4 + n5) / 5;

        if (prom >= 70)
        {
            Console.WriteLine("Aprueba");
        }
        else
        {
            Console.WriteLine("Reprueba");
        }

    }
}