using System;

namespace Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Celular miCelular = new Celular(pin:"5678", saldo: 10.0);

            miCelular.encender(pin:"5678");
            miCelular.llamar(tel:"7777-7777");
            miCelular.enviarSMS(tel:"7777-7777", texto: "hola xD");
            miCelular.jugar(nombre:"PvZ");
            miCelular.escucharMusica(cancion: " cancion.mp3");
            miCelular.apagar();
        }
    }
}
