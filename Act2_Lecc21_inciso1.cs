internal class Program
{
    private static void Main(string[] args)
    {
        int opciones;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Programa de atencion telefonica");
        Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1. Ventas");
        Console.WriteLine("2. Recepcion");
        Console.WriteLine("3. Direccion");
        Console.WriteLine("4. Compras");

        opciones = Convert.ToInt32(Console.ReadLine());

        if (opciones == 1)
        {
            Console.WriteLine("Bienvenido al departamento de Ventas");
            Console.WriteLine("Encargado: Santiago Ocaña");
            Console.WriteLine("Correo: socaña@gmail.com");
        }
        else
        {
            if (opciones == 2)
            {
                Console.WriteLine("Bienvenido al departamento de Recepcion");
                Console.WriteLine("Encargado: Franco Peruch");
                Console.WriteLine("Correo: franco.peruch@hgmail.com");
            }
            else
            {
                if (opciones == 3)
                {
                    Console.WriteLine("Bienvenido al departamento de Direccion");
                    Console.WriteLine("Encargada: Estefany Albizurez");
                    Console.WriteLine("Correo: estefany.albi@gmail.com");
                }
                else
                {
                    if (opciones == 4)
                    {
                        Console.WriteLine("Bienvenido al departamento de Compras");
                        Console.WriteLine("Encargado: Miguel Tumax");
                        Console.WriteLine("Correo: miguel.tx@gmail.com");
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