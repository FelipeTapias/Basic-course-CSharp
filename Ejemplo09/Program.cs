using System;

class ProgramArray
{
    static void Main()
    {
        int[] datos = new int[5];

        for (int i = 0; i < datos.Length; i++)
        {
            Console.WriteLine("Dime un dato: ");
            datos[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Los datos son: ");
        for (int i = 0; i < datos.Length; i++)
        {
            Console.Write(datos[i] + " | ");
        }

        Console.WriteLine(" ");
        Console.WriteLine("Los datos al revés son: ");
        for (int i = datos.Length - 1; i >= 0; i--)
        {
            Console.Write(datos[i] + " | ");
        }

        //string[] diasSemana = new string[7];
        string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        int dia;
        string nombreDia;

        Console.WriteLine("Dime un número de la semana: ");
        dia = Convert.ToInt32(Console.ReadLine());
        do
        {
            if (dia < 0 | dia > 7)
            {
                Console.WriteLine("Dime otro número de la semana: ");
                Console.WriteLine("Los días de la semana son del 1 al 7.");
                dia = Convert.ToInt32(Console.ReadLine());
            }
        } while (dia < 0 | dia > 7);
        Console.WriteLine("El día de la semana es: " + diasSemana[dia - 1]);

        Console.WriteLine("Dime el nombre de un día: ");
        nombreDia = Console.ReadLine();
        int posicion = -1;
        for (int i = 0; i < diasSemana.Length; i++)
        {
            if (nombreDia == diasSemana[i])
            {
                posicion = i;
            }
        }
        if (posicion != -1)
        {
            Console.WriteLine($"Día encontrado en {posicion + 1}.");
        }
        else
        {
            Console.WriteLine("Día no encontrado.");
        }

        float[] numeros = new float[10];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Introduce un número: ");
            numeros[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("Los datos ingresados son: ");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write(numeros[i] + " | ");
        }

        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        int nMes;
        string nombreMes;
        int encontrado = -1;
        Console.Write("Introduce el número del mes: ");
        nMes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El mes es: {meses[nMes - 1]}");

        Console.Write("Introduce el nombre del mes: ");
        nombreMes = Console.ReadLine();

        for(int i = 0; i < meses.Length; i++)
        {
            if (nombreMes == meses[i])
            {
                encontrado = i;
            }
        }

        if(encontrado != -1)
        {
                Console.WriteLine($"Nombre mes: {nombreMes} en la posición {encontrado + 1}");
        }else 
        {
            Console.WriteLine("Mes no encontrado.");
        }



    }
}
