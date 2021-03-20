using System;

namespace Celular
{

    public class Celular
    {    
        // Atributos / propiedades
        public string pin { get; set; }
        public double saldo { get; set; }

        // Constructores
        
        public Celular(string pin) //sobrecarga 1
        {
            this.pin = pin;
            this.saldo = 0;
        }
         public Celular(string pin, double saldo) //sobregar 2
        {
            this.pin = pin;
            this.saldo = saldo;
        }

        // Metodos
        public void encender(string pin)
        {
            if(this.pin.CompareTo(pin)== 0)
                Console.WriteLine("hecho!");
            else
                Console.WriteLine("Error!");
        }
        public void llamar(string tel)
        {
            if(saldo >= 0.25)
            {   
                Console.WriteLine("Llamando a " + tel);
                Console.WriteLine("Hecho!");
                saldo -= 0.25;
            }
            else
                Console.WriteLine("Error!");

        }
        public void enviarSMS(string tel, string texto)
        {
             double precio = 0.01 *texto.Length;
             if(saldo >= precio)
            {
                Console.WriteLine("Hecho!");
                saldo -= precio;
            }
            else
                Console.WriteLine("Error!");
        }
        public void jugar(string nombre)
        {
            Console.WriteLine("Abriendo: "+ nombre);
            Console.WriteLine("Jugando...");
            Console.WriteLine("Saliendo...");
        }
        public void escucharMusica(string cancion)
        {
            Console.WriteLine("Reproduciendo" +cancion);
        }
        public void apagar()
        {
            Console.WriteLine("Apagando...Apagado...");
        }
    }
}