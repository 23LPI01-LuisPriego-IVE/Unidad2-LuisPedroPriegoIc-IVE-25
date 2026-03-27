internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Ingrese los tres lados del triangulo:");

        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Equilatero");
        }
        else
        {
        if (a == b || b == c || a == c)
        {
            Console.WriteLine("Isosceles");
        }
        else
        {
            Console.WriteLine("Escaleno");
        }
        }

    }
}