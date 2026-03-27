internal class Program
{
    private static void Main(string[] args)
    {
        int opciones;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Bienvenido a MegaChamba S.A.");
        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1. Ventas");
        Console.WriteLine("2. Atencion al cliente");
        Console.WriteLine("3. Soporte tecnico");
        Console.WriteLine("4. Recursos humanos");

        opciones = Convert.ToInt32(Console.ReadLine());

        if (opciones == 1)
        {
            Console.WriteLine("Te comunicamos con el area de Ventas");
        }
        else
        {
        if (opciones == 2)
        {
            Console.WriteLine("Atencion al cliente te atendera pronto");
        }
        else
        {
        if (opciones == 3)
        {
            Console.WriteLine("Soporte tecnico esta en camino");
        }
        else
        {
        if (opciones == 4)
        {
            Console.WriteLine("Recursos humanos respondera tu solicitud");
        }
        else
        {
        Console.WriteLine("Opcion invalida");
        }
        }
        }
        }

    }
}