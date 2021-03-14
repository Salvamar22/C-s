using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad maxima de habs: ");
            max = Convert.ToInt32(Console.ReadLine());
            available = max;

           bool toContinue = true;
           do
           {
               
               switch (showMenu())
               {
                   case 1: reserve(); break;
                   case 2: dispatch(); break;
                   case 3: status(); break;
                   case 4: profits(); break;
                   case 5: toContinue = false; break;
                   default: Console.WriteLine("Opcion invalida!");
                   break;
               }
           } while (toContinue);
           
        }

        public static int max = 0;
        public static int available = 0;
        public static int dispatched = 0;        

        public static int showMenu()
        {
                Console.WriteLine("1) Reservar");
                Console.WriteLine("2) Despachar");
                Console.WriteLine("3) Estado actual");
                Console.WriteLine("4) Ganancias");
                Console.WriteLine("5) Salir");
                Console.WriteLine("1) Opcion: ");
                int option = Convert.ToInt32(Console.ReadLine());  
                return option; 
                
        }
       
        public static void status()

        {
            Console.WriteLine("Disponibles: " + available);
            int occupied = max - available;
            Console.WriteLine("Ocupadas: " + occupied);
        }

       public static void reserve()
            {
                Console.Write("Habs . a reservar: ");
                int rooms = Convert.ToInt32(Console.ReadLine());
                if ( rooms > 0 && rooms <= available)
                {
                    available-= rooms;
                    Console.WriteLine("Hecho!");

                }
                else
                    Console.WriteLine("Error!");

            }

       public static void dispatch()
            {
                Console.Write("Habs . a despachar: ");
                int rooms = Convert.ToInt32(Console.ReadLine());
                int occupied = max -available;
                if ( rooms > 0 && rooms <= occupied)
                {
                    available += rooms;
                    dispatched += rooms;
                    Console.WriteLine("Hecho!");

                }
                else
                    Console.WriteLine("Error!");

            }

        public static void profits()
        {
           int total = dispatched * 15;
           Console.WriteLine("Ganancias: $" + total); 
        }

        
    

    }
}
