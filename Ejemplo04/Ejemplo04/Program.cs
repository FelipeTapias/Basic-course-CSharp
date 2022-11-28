using System;
using System.Diagnostics;

class Conditional {

    public static void Main() {

        string nombre;
        int numero1, numero2;
        int entero1, entero2;

        Console.Write("Dime tu nombre: ");
        nombre = Console.ReadLine();

        if (nombre != "Felipe")
        {
            Console.WriteLine("Acceso denegado");
        }
        else
        {
            Console.WriteLine("Acceso permitido");
        }

        Console.WriteLine("Escribe el numero 1");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe el numero 2");
        numero2 = Convert.ToInt32(Console.ReadLine());
        if (numero2 == 0)
        {
            Console.WriteLine("No se puede hacer la divisón.");
        }
        else
        {
            Console.WriteLine("La división es: " + (numero1 / numero2));
        }

        Console.Write("Ingresa el número entero 1: ");
        entero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el número entero 2: ");
        entero2 = Convert.ToInt32(Console.ReadLine());

        if (entero1 > 0 && entero2 > 0)
        {
            Console.WriteLine("Ambos números son positivos");
        }
        else if (entero1 > 0)
        {
            Console.WriteLine("Solo el numero1 es positivo");
        }
        else if (entero2 > 0)
        {
            Console.WriteLine("Solo el numero2 es positivo");
        }
        else 
        {
            Console.WriteLine("Ninguno son positivos");
        }
    }

}