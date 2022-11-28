using System;

class BucleDoWhile
{
    public static void Main() 
    {

        const string USERNAME = "machine";
        const string PASSWORD = "1234";

        string userUsername;
        string userPassword;

        do
        {
            Console.Write("Introduce el usuario: ");
            userUsername = Console.ReadLine();

            Console.Write("Introduce la contraseña: ");
            userPassword = Console.ReadLine();

            if (PASSWORD != userPassword || USERNAME != userUsername)
            {
                Console.WriteLine("Usuario y/o contraseña incorrecta, intentalo de nuevo");
            }
        }
        while (PASSWORD != userPassword || USERNAME != userUsername);

        Console.WriteLine("Bienvenido");


    }
}
