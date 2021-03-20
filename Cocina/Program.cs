using System;

namespace Cocina
{
    public class Program
    {
       public static void Main(string[] args)
        {
            //aqui instanciaremos los objetos
            Cocina cocinaVerde = new Cocina(
                pQue:4, pCol:"verde", pMar:"LG",pCom:"gas propano", pTH:false);
                Console.WriteLine("Cocina 01. ");
                Console.WriteLine(cocinaVerde.info());
                cocinaVerde.encender();
                cocinaVerde.apagar();
                cocinaVerde.hornear();

            Cocina cocinaMabe = new Cocina(
                pQue:6, pCol:"gris", pMar:"mabe",pCom:"gas propano", pTH:true);
                Console.WriteLine("Cocina 02. ");
                Console.WriteLine(cocinaMabe.info());
                cocinaMabe.encender();
                cocinaMabe.apagar();
                cocinaMabe.hornear();

                         
        }
    }
}
