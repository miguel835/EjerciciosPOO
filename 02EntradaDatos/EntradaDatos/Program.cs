﻿/*
Crea una aplicación de consola en C# que capture datos ingresados por el usuario,
convierte estos datos a diferentes tipos y demuestre el uso de control de excepciones
para evitar errores por entradas incorrectas. Crea una clase llamada EntradaDatos.
El programa debe capturar datos de edad y altura desde la consola, realizando las conversiones
necesarias para trabajar con tipos int y float. Además utiliza un control de excepciones para 
manejar las entradas de datos no validas, adicionalmente deberas mostrar la edad y altura del usuario.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntradaDatos entradaDatos = new EntradaDatos();
            entradaDatos.LeerDatos();
            entradaDatos.MostrarDatos();
            Console.ReadKey();
        }
    }
    public class EntradaDatos
    {
        //Atributos 
        public int? edad;
        public double? altura;

        //Metodos o propiedades 
        public void LeerDatos()
        {
            try
            {
                Console.WriteLine("Ingrese su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                if (true)
                {
                    
                }
                Console.WriteLine("Ingrese su altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex) {
                Console.WriteLine("No se puedo leer los datos proporcionados");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("\nLos datos ingresados son: \n Edad: {0} \n Altura: {1}", edad, altura);
        }
    }
}
