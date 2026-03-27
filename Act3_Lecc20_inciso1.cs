internal class Program
{
    private static void Main(string[] args)
    {
        int dia;

        Console.WriteLine("Luis Priego-IV-E");

        Console.WriteLine("Ingrese un numero del 1 al 7");

        dia = Convert.ToInt32(Console.ReadLine());

        if (dia == 6 || dia == 7)
        {
            Console.WriteLine("Fin de semana");
        }
        else
        {
        if (dia >= 1 && dia <= 5)
        {
        Console.WriteLine("Entre semana");
        }
        else
        {
        Console.WriteLine("Numero invalido");
            }
        }

    }
}