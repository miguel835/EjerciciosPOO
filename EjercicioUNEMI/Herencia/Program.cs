using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            configuracionVisual();
            Estudiante e1 = new Estudiante("Gustavo", "Cajas", "1.55", 21, "Enfermeria", "15121546187", "Ciencias de la Salud");
            Estudiante e2 = new Estudiante("Maria", "Guarderas", "1.65", 22, "Agropecuaria", "12346789543", "Ciencias Pecuarias y Biologicas");
            Docente d1 = new Docente("Alex", "Ortega", "1.70", 45, "1500", "Comunicaciones móviles");
            Docente d2 = new Docente("Francisca", "Matute", "1.80", 35, "1000", "Robotica");
            Console.SetCursorPosition(10,0);
            Console.WriteLine("BASES DE DATOS DE LA UNEMI");
            Console.WriteLine("\nData de estudiantes:");
            Console.WriteLine($"{e1.GetInfo()} {e1.GetInfoStudent()}");
            Console.WriteLine($"{e2.GetInfo()} {e2.GetInfoStudent()}");
            Console.WriteLine("\nData de docentes: ");
            Console.WriteLine($"{d1.GetInfo()} {d1.GetInfoDocent()}");
            Console.WriteLine($"{d2.GetInfo()} {d2.GetInfoDocent()}");
            Console.ReadKey();
        }

        static void configuracionVisual()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}
