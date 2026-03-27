//Primavera empieza aprox 21 de marzo
//Verano 21 de junio
//Otoño 21 de septiembre
//Invierno 21 de diciembre

internal class Program
{
    private static void Main(string[] args)
    {
        int dia, mes;

        Console.WriteLine("Luis Priego-IV-E");
        Console.WriteLine("Consulta de estacion del año");

        Console.WriteLine("Ingrese el dia:");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el mes (1-12):");
        mes = Convert.ToInt32(Console.ReadLine());

        if (mes < 1 || mes > 12)
        {
            Console.WriteLine("Fecha invalida");
        }
        else
        {
        if (dia < 1)
        {
        Console.WriteLine("Fecha invalida");
        }
        else
        {
        if (mes == 2 && dia > 29)
        {
        Console.WriteLine("Fecha invalida");
        }
        else
        {
        if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30)
        {
        Console.WriteLine("Fecha invalida");
        }
        else
        {
        if ((mes == 12 && dia >= 21) || mes == 1 || mes == 2 || (mes == 3 && dia < 21))
        {
        Console.WriteLine("Invierno");
        }
        else
        {
        if ((mes == 3 && dia >= 21) || mes == 4 || mes == 5 || (mes == 6 && dia < 21))
        {
        Console.WriteLine("Primavera");
        }
        else
        {
        if ((mes == 6 && dia >= 21) || mes == 7 || mes == 8 || (mes == 9 && dia < 21))
        {
            Console.WriteLine("Verano");
        }
        else
        {
            Console.WriteLine("Otoño");
        }
        }
        }
        }
        }
        }
        }

    }
}