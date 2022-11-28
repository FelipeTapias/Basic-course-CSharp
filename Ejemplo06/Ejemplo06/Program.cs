using System;
using System.Net.WebSockets;

class BucleWhile
{
    public static void Main()
    {
        const string CLAVE = "1234Siste";

        Console.Write("Introduce la clave: ");
        string usuarioClave = Console.ReadLine();

        while (usuarioClave != CLAVE)
        {
            Console.Write("Clave errónea. Introduce de nuevo la clave: ");
            usuarioClave = Console.ReadLine();
        }

        Console.WriteLine("¡Bienvenido!");

    }
}