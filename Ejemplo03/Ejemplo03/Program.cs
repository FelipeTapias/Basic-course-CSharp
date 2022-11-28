using System;

class Variables {
    static void Main() {

        string nombre;
        double numero1, numero2;
        int entero1, entero2;

        Console.Write("Dime tu nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Dime número 1: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Dime número 2: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Dime un entero 1: ");
        entero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dime un entero 2: ");
        entero2 = Convert.ToInt32(Console.ReadLine());



        Console.WriteLine("Bienvenido " + nombre);
        Console.WriteLine("La división es: " + numero1/numero2);
        Console.WriteLine("La división entera es: " + entero1/entero2 + " y su resto es: " + entero1 % entero2);


    }
}