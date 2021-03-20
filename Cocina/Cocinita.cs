using System;
namespace Cocina
{
    public class Cocina
    {
        //Atributos
        public int quemadores;
        public string color;
        public string marca;
        public string combustible;
        public bool tienehorno;

        //constructores
        public Cocina(int pQue, string pCol, string pMar, string pCom, bool pTH)
        {
            quemadores = pQue;
            color =pCol;
            marca = pMar;
            combustible = pCom;
            tienehorno = pTH;

        }
        //metodos:
        public void encender()
        {
            Console.WriteLine("Encendiendo...");
        }

        public void apagar()
        {
            Console.WriteLine("Apagando...");
        }
        public void hornear()
        {
        if (tienehorno)
            Console.WriteLine("Hecho...");
        else
            Console.WriteLine("Error...");
        }
        public string info()
        {
            string info = "Marca: " + marca + "\n" +
                          "Color: " + color + "\n" +
                          "Cantidad de quemadores que posee: " + quemadores + "\n" +
                          "Gas que utiliza: " + combustible + "." ;
            return info;
        }




    }
}