using System;

class ConditionalSw {
    static void Main() {

        int n;

        Console.Write("Dime un número: ");
        n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 2:
                Console.WriteLine("El número es un dos");
                break;
            case 3:
                Console.WriteLine("El número es un tres");
                break;
            case 4:
                Console.WriteLine("El número es un cuatro");
                break;
            case 5:
                Console.WriteLine("El número es un cinco");
                break;
            default:
                Console.WriteLine("El número no esta entre el dos y el cinco");
                break;
        }

        Console.Write("Dime un número del día de la semana (1-7): ");
        int dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Día no válido");
                break;
        }

        int nMes;
        Console.Write("Dime un número (1-12): ");
        nMes = Convert.ToInt32(Console.ReadLine());

        switch (nMes)
        {
            case 1: Console.WriteLine("Enero"); break;
            case 2: Console.WriteLine("Febrero"); break;
            case 3: Console.WriteLine("Marzo"); break;
            case 4: Console.WriteLine("Abril"); break;
            case 5: Console.WriteLine("Mayo"); break;
            case 6: Console.WriteLine("Junio"); break;
            case 7: Console.WriteLine("Julio"); break;
            case 8: Console.WriteLine("Agosto"); break;
            case 9: Console.WriteLine("Septiembre"); break;
            case 10: Console.WriteLine("Octrubre"); break;
            case 11: Console.WriteLine("Noviembre"); break;
            case 12: Console.WriteLine("Diciembre"); break;
            default: Console.WriteLine("Número de mes no válido"); break;
        }

        string nameMes;
        Console.Write("Dime un nombre de un mes: ");
        nameMes = Console.ReadLine();

        switch (nameMes)
        {
            case "enero": Console.WriteLine("Días del mes:" + 31); break;
            case "febrero": Console.WriteLine("Días del mes:" + 28); break;
            case "marzo": Console.WriteLine("Días del mes:" + 31); break;
            case "abril": Console.WriteLine("Días del mes:" + 30); break;
            case "mayo": Console.WriteLine("Días del mes:" + 31); break;
            case "junio": Console.WriteLine("Días del mes:" + 30); break;
            case "julio": Console.WriteLine("Días del mes:" + 31); break;
            case "agosto": Console.WriteLine("Días del mes:" + 31); break;
            case "septiembre": Console.WriteLine("Días del mes:" + 30); break;
            case "octubre": Console.WriteLine("Días del mes:" + 31); break;
            case "noviembre": Console.WriteLine("Días del mes:" + 30); break;
            case "diciembre": Console.WriteLine("Días del mes:" + 31); break;
            default: Console.WriteLine("Nombre del mes no válido"); break;
        }

    }
}