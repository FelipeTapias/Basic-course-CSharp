using System;
using System.Reflection.Metadata.Ecma335;

class FuncionesValor
{
    public static void Main()
    {
        int MayorN;
        int[] Array = { 1, 2, 3, 4, 5 };
        int encontrado;

        Console.WriteLine("Triple: " + Triple(3));
        MayorN = Mayor(12, 5);
        if (MayorN == 0) {
            Console.WriteLine("Los números son iguales");
        } else { 
            Console.WriteLine("Mayor: " + MayorN);
        }

        encontrado = Buscar(Array, 10);
        if (encontrado != -1)
        {
            Console.WriteLine($"Número encontrado; Posición: {encontrado} ");
        }
        else {
            Console.WriteLine($"Número no encontrado; Posición: {encontrado}");
        }

    }

   public static int Triple(int n)
    {
        return n * 3;
    }

    public static int Mayor(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (b > a)
        {
            return b;
        }
        else {
            return 0;
        }
    }

    public static int Buscar(int[] Array, int elemento)
    {
        int position = -1;
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == elemento)
            {
                position = i;
            }
        }
        return position;

    }    
}