using System;
using System.Collections.Generic;
using System.Linq;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toContinue = true;
            do
            {
                switch (showMenu())
                {
                    case 1:addT(); break;
                    case 2:removeT(); break;
                    case 3:displayMaxT(); break;
                    case 4:displayAllC(); break;
                    case 5:displayAllF(); break;
                    case 6:displayAllK(); break;
                    case 7:toContinue =false; break;
                    default: Console.WriteLine("Opcion invalida");
                    break;
                }
            } while (toContinue);
            
        }
        public static List<double> listT = new List<double>();
        public static int showMenu()
        {
            Console.WriteLine("1) Agregar temperatura (Celsius) ");
            Console.WriteLine("2) Quitar temperatura (Celsius)");
            Console.WriteLine("3) Mostrar temperatura máxima (Celsius)");
            Console.WriteLine("4) Mostrar temperaturas en Clesius");
            Console.WriteLine("5) Mostrar temperaturas en Fahrenheit");
            Console.WriteLine("6) Mostrar temperaturas en Kelvin");
            Console.WriteLine("7) Salir");
            Console.Write("Opcion: ");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
    
        public static void addT()
        {
            Console.Write("Temp: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            listT.Add(temp);
        }

        public static void removeT()
        {
            Console.Write("Indice: ");
            int id = Convert.ToInt32(Console.ReadLine());
            listT.RemoveAt(id);    
        }
        public static void displayMaxT()
        {
            Console.WriteLine("Temp. max: " + listT.Max() + "°");
        }

        public static void displayAllC()
        {   
            Console.Write("Celsius: ");
            foreach (double temp in listT)
            Console.WriteLine(temp + "°");
        }
    
        public static void displayAllF()
        {   
            Console.Write("Fahrenheit: ");
            foreach (double temp in listT)
            Console.WriteLine((temp*9.0/5+32)  + "°");
        }

        public static void displayAllK()
        {   
            Console.Write("Kelvin: ");
            foreach (double temp in listT)
            Console.WriteLine((temp+273.15) + "°");
        }
    
    }

}
