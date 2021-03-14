using System;

namespace Mundial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Cantidad de entradas: ");
            int tickets = Convert.ToInt32(Console.ReadLine());

            if (tickets > 0)
            {
                Console.Write("Correlativo: ");
                int id = Convert.ToInt32(Console.ReadLine());

                int total = 0;
                if (id == 1) 
                    total = 2240;
                else if (id >= 2 && id <= 12)
                    total = 960;
                else if (id >= 13 && id <= 14)
                    total = 2240;
                else if (id == 15) 
                    total = 960;
                else
                    total = 2560;

                total *= tickets; //total = total *tickets
                Console.WriteLine("Total: " + total + "rublos.");

            }
            else
                Console.WriteLine("Cantidad invalida!");
            



        }
    }
}