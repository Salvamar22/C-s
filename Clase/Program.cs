using System;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Apellido: ");
            string lastname = Console.ReadLine();
            Console.Write("Edad: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Carrera: ");
            string major = Console.ReadLine();
            Console.WriteLine("Bienvenido: " + Environment.NewLine + name + " " + lastname + " (" + age + ", " + major + ")");


        }
    }
}