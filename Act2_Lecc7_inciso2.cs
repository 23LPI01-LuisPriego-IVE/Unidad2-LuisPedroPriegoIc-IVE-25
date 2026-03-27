internal class Program
{
    private static void Main(string[] args)
    {
        int nota;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Ingrese su calificacion:");
        nota = Convert.ToInt32(Console.ReadLine());

        if (nota <= 69)
        {
            Console.WriteLine("Deficiente");
        }
        else
        {
        if (nota <= 79)
        {
            Console.WriteLine("Regular");
        }
        else
        {
        if (nota <= 89)
        {
            Console.WriteLine("Bien");
        }
        else
        {
        if (nota < 100)
        {
            Console.WriteLine("Muy bien");
        }
        else
        {
            Console.WriteLine("Excelente");
        }
        }
        }
        }

    }
}