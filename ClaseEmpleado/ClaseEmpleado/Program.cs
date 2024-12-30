using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEmpleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración visual de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //Primera Instanciación
            Empleado empleado1 = new Empleado("Miguel Díaz", 777, 470, "IT");
            Console.WriteLine("\tEmpleado 1");
            Console.WriteLine($"Nombre: {empleado1.getNombre()}");
            Console.WriteLine($"N° Empleado: {empleado1.getNumeroEmpleado()}");
            Console.WriteLine($"Salario: {empleado1.getSalario()}");
            Console.WriteLine($"Departamento: {empleado1.getDepartamento()}");
            Console.WriteLine("¿Consideras que este empleado merece un aumento?");
            string answer = Console.ReadLine();
            if (answer == "Si" || answer == "si")
            {
                Console.WriteLine("¿Cual es el porcentaje de aumento?");
                double porcentaje = double.Parse(Console.ReadLine());
                Console.WriteLine($"El nuevo salario es: {empleado1.aumentarSalario(porcentaje)}");
            }
        }
    }
}
