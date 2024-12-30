using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ClasePuntoBidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración visual de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(10, 0);

            Console.WriteLine("CLASE PUNTO");
            Console.Write("Ingrese el valor para el eje X: ");
            double ejeDeAbscisas = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor para el eje Y: ");
            double ejeDeOrdenadas = double.Parse(Console.ReadLine());
            //Primera instanciación de la clase Punto
            Punto punto1 = new Punto(ejeDeAbscisas, ejeDeOrdenadas);
            Console.WriteLine("Las coordenadas son:");
            Console.WriteLine($"Eje X: {punto1.getX()}");
            Console.WriteLine($"Eje Y: {punto1.getY()}");
            Console.WriteLine($"La distancia al origen (0,0) es: {punto1.DistanciaHaciaElOrigen():F2}");
            Console.WriteLine("Calculo de la distancia a un punto especifico");
            Console.Write("Ingrese el valor para el eje X: ");
            double NuevoEjeX = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor para el eje Y: ");
            double NuevoEjeY = double.Parse(Console.ReadLine());
            //Segunda instanciación de la clase Punto
            Punto punto2 = new Punto(NuevoEjeX, NuevoEjeY);
            Console.WriteLine($"La distancia entre ({ejeDeAbscisas},{ejeDeOrdenadas}) y ({NuevoEjeX},{NuevoEjeY}) es: {punto1.DistanciaHaciaUnPuntoEspecifico(punto2):F2}");
            Thread.Sleep(1000);
            Console.Clear();


            Console.SetCursorPosition(10, 0);
            Console.WriteLine("CLASE CIRCULO");
            Console.WriteLine("\nCalculo para obtener el radio, el area y el perimetro de una circuferencia");
            Console.Write("Ingrese el valor del radio de la circuferencia: ");
            double radio = double.Parse(Console.ReadLine());
            //Primera instanciación de la clase Circulo
            Circulo circulo1 = new Circulo(radio, punto1);
            Console.WriteLine($"El area del circulo es: {circulo1.CalcularArea():F2}");
            Console.WriteLine($"El perimetro del circulo es: {circulo1.CalcularPerimetro():F2}");
            Console.WriteLine($"El radio del circulo es: {circulo1.getRadio():F2}");
            Thread.Sleep(1000);
            Console.Clear();


            Console.SetCursorPosition(10, 0);
            Console.WriteLine("CLASE RECTANGULO");
            Console.WriteLine("\nCalculo de la base, la altura, el area y el perimetro de un rectangulo");
            Console.Write("Ingrese la base del rectangulo: ");
            double baseR = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la longitud del rectangulo: ");
            double longitudR = double.Parse(Console.ReadLine());
            Rectangulo rectangulo = new Rectangulo(baseR, longitudR, punto1);
            Console.WriteLine($"La base del rectangulo es: {rectangulo.getBase():F2}");
            Console.WriteLine($"La altura del rectangulo es: {rectangulo.getAltura():F2}");
            Console.WriteLine($"El area del rectangulo es: {rectangulo.calcularArea():F2}");
            Console.WriteLine($"El perimetro del rectangulo es: {rectangulo.calcularPerimetro():F2}");
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
