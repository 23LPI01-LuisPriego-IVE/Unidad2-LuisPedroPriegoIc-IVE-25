internal class Program
{
    private static void Main(string[] args)
    {
        string pass;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Ingrese la contraseña:");
        pass = Console.ReadLine();

        if (pass == "Password123")
        {
            Console.WriteLine("Bienvenid@");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }

    }
}