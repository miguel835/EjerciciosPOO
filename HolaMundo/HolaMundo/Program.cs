//Crear una aplicación de consola en C# que imprima "Hola Mundo"
//utilizando el concepto de Programación Orientada a Objetos (POO).
//Define una clase llamada Saludo.
//Dentro de la clase Saludo, crea un método llamado MostrarMensaje que no
//reciba parámetros y que imprima en consola el mensaje "Hola Mundo".
//En el método Main de tu aplicación, crea una instancia de la clase Saludo y
//llama al método MostrarMensaje para ejecutar la impresión del mensaje en consola.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludo saludo = new Saludo();
            saludo.MostrarMensaje();
            Console.ReadKey();
        }
    }

    public class Saludo
    {
        //Metodos o propiedades 
        public void MostrarMensaje()
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}
