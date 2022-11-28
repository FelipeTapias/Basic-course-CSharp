using System;

class ProgramList
{ 
    static void Main()
    {
        //List<int> datos = new();
        //int numero;
        //string nombreDia;

        //do
        //{
        //    Console.Write("Introduce datos; (-1) para terminar: ");
        //    numero = Convert.ToInt32(Console.ReadLine());
        //    if (numero != -1)
        //    {
        //        datos.Add(numero);
        //    }
        //} while (numero != -1);

        ////Console.WriteLine("Los datos son: ");
        ////for (int i = 0; i < datos.Count; i++)
        ////    Console.Write(datos[i] + " - ");


        ////Console.WriteLine(String.Empty);
        ////Console.WriteLine("Los datos al revés son: ");
        ////for (int i = datos.Count - 1; i >= 0; i--)
        ////    Console.Write(datos[i] + " - ");


        //Console.WriteLine(String.Empty);
        //Console.WriteLine("Dime un dato: ");
        //int datoABuscar = Convert.ToInt32(Console.ReadLine());

        //if(datos.Contains(datoABuscar))
        //{
        //    Console.WriteLine("Está");
        //}
        //else
        //{
        //    Console.WriteLine("No encontrado");
        //} 

        //List<string> listCadena = new();
        //string datoLista;

        //do
        //{
        //    Console.Write("Ingresa una cadena; (-1) para terminar: ");
        //    datoLista = Console.ReadLine();
        //    if (datoLista != "-1")
        //        listCadena.Add(datoLista);
        //}while (datoLista != "-1");

        //Console.WriteLine("Datos al revés: ");
        //Console.Write(" - ");
        //for(int i = listCadena.Count - 1; i >= 0; i--)
        //    Console.Write(listCadena[i] + " - ");

        //Console.WriteLine(String.Empty);
        //Console.WriteLine("Datos: ");
        //Console.Write(" - ");
        //foreach(string dato in listCadena)
        //    Console.Write(dato + " - ");

        List<int> listNumero = new();
        int dato, datoBuscar;

        do
        {
            Console.Write("Ingresa un dato; (-1) para terminar: ");
            dato = Convert.ToInt32(Console.ReadLine());

            if (dato != -1)
                listNumero.Add(dato);
        } while (dato != -1);

        Console.Write("Ingresaa el dato a buscar: ");
        datoBuscar = Convert.ToInt32(Console.ReadLine());

        if (listNumero.Contains(datoBuscar))
        {
            Console.WriteLine("Dato encontrado");
        }else
        {
            Console.WriteLine("Dato no encontrado");
        }
    }
}