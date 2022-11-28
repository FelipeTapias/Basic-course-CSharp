using System;

class FuncionesVoid
{
    static void Main()
    {

        ResolverSegundoGrado(0, 1, 0);
    }

    static void ResolverSegundoGrado(float a, float b, float c)
    {
        // ax^2 + bx + c = 0
        double x1, x2;
        x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        Console.WriteLine("Primera solución: " + x1 );
        Console.WriteLine("Segunda solución: " + x2 );

    }
}