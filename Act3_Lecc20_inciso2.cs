internal class Program
{
    private static void Main(string[] args)
    {
        int nota;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Ingrese la calificacion:");

        nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 70)
        {
            Console.WriteLine("Aprobado");   
        }
        else
        {
            Console.WriteLine("Reprobado");
        }

    }
}