/*                                     PRACTICA EXPERIMENTAL
Integrantes: Díaz Zambrano Miguel Roberth, Pacheco Reyes Jhon Jairo y Quiñonez Mendoza Anthony Alejandro
Problema: Una empresa de construcción de motocicletas requiere el desarrollo de un software que controle 
el software de este vehículo. El software debe implementar una clase motocicleta que tenga al menos 
tres propiedades y dos métodos que usted considere importantes. Además, esta clase debe estar compuesta de
al menos dos clases más de algunas de sus partes (pueden ser: motor, tanque, neumáticos, carburador, etc.),
estas dos clases de composición deben tener también dos propiedades cada una.*/
using ClaseMoto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración visual de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            // Creacion de motos usando inicialización de objetos anónima
            Moto p1 = new Moto
            {
                marca_de_moto = "Nexus",
                modelo_de_moto = "Deportiva",
                año_de_moto = 2024,
                Motor = new Motor { Cilindrada = 250, Potencia = 30 },
                Tanque = new Tanque { Capacidad = 15, TipoCombustible = "Gasolina" }
            };
            Moto p2 = new Moto
            {
                marca_de_moto = "Ssenda",
                modelo_de_moto = "Doble propósito - Todo terreno",
                año_de_moto = 2025,
                Motor = new Motor { Cilindrada = 300, Potencia = 35 },
                Tanque = new Tanque { Capacidad = 20, TipoCombustible = "Diesel" }
            };
            Moto seleccionada = null;
            //Menu del software 
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("||      *** SOFTWARE DE CONTROL DE MOTOS ***      ||");
                Console.WriteLine("==================================================");
                Console.WriteLine("Selecciona una moto para interactuar:");
                Console.WriteLine("1. Moto NEXUS 250RS SPORT");
                Console.WriteLine("2. Moto SSENDA DURO 250 TK");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        seleccionada = p1;
                        break;
                    case "2":
                        seleccionada = p2;
                        break;
                    case "3":
                        Console.WriteLine("¡Chao!");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Presiona cualquier tecla para intentar de nuevo.");
                        Console.ReadKey();
                        continue;
                }
                //Llamado a la funcion InteractuarMoto con el parametro de la moto seleccionada por el usuario
                InteractuarMoto(seleccionada);
            }
        }
        static void InteractuarMoto(Moto moto)
        {
            //Menu de la moto seleccionada
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Has seleccionado la moto: {moto.marca_de_moto} ({moto.modelo_de_moto})");
                Console.WriteLine("==================================================");
                Console.WriteLine("¿Qué deseas hacer?");
                Console.WriteLine("1. Mostrar detalles");
                Console.WriteLine("2. Arrancar moto");
                Console.WriteLine("3. Frenar moto");
                Console.WriteLine("4. Estado");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        MostrarDetalles(moto);
                        break;
                    case "2":
                        moto.Arrancar();
                        break;
                    case "3":
                        moto.Frenar();
                        break;
                    case "4":
                        Interactuar(moto);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intenta nuevamente.");
                        break;
                }
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
        static void Interactuar(Moto moto)
        {
            //Menu de las partes de la moto
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Interacción con las partes de la moto: {moto.marca_de_moto}");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Ver/Editar Motor");
                Console.WriteLine("2. Ver/Editar Tanque");
                Console.WriteLine("3. Volver al menú anterior");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Mostrardetalles(moto.Motor);
                        break;
                    case "2":
                        Eltanque(moto.Tanque);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intenta nuevamente.");
                        break;
                }
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
        static void Mostrardetalles(Motor motor)
        {
            //Menu con los detalles del motor
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("Detalles del Motor:");
            Console.WriteLine($"|| Cilindrada: {motor.Cilindrada}cc");
            Console.WriteLine($"|| Potencia: {motor.Potencia}HP");
            Console.WriteLine("====================================================");
            Console.WriteLine("¿Deseas editar las propiedades del motor? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "s")
            {
                Console.Write("Introduce nueva cilindrada (cc): ");
                motor.Cilindrada = int.Parse(Console.ReadLine());
                Console.Write("Introduce nueva potencia (HP): ");
                motor.Potencia = int.Parse(Console.ReadLine());
                Console.WriteLine("¡Propiedades del motor actualizadas!");
            }
        }
        static void Eltanque(Tanque tanque)
        {
            //Menu de los detalles del tanqu
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("Detalles del Tanque:");
            Console.WriteLine($"|| Capacidad: {tanque.Capacidad}L");
            Console.WriteLine($"|| Tipo de Combustible: {tanque.TipoCombustible}");
            Console.WriteLine("====================================================");
            Console.WriteLine("¿Deseas editar las propiedades del tanque? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "s")
            {
                Console.Write("Introduce nueva capacidad (L): ");
                tanque.Capacidad = int.Parse(Console.ReadLine());
                Console.Write("Introduce nuevo tipo de combustible: ");
                tanque.TipoCombustible = Console.ReadLine();
                Console.WriteLine("¡Propiedades del tanque actualizadas!");
            }
        }
        static void MostrarDetalles(Moto moto)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine($"|| Marca: {moto.marca_de_moto}");
            Console.WriteLine($"|| Modelo: {moto.modelo_de_moto}");
            Console.WriteLine($"|| Año: {moto.año_de_moto}");
            Console.WriteLine($"|| Motor: {moto.Motor.Cilindrada}cc, {moto.Motor.Potencia}HP");
            Console.WriteLine($"|| Tanque: {moto.Tanque.Capacidad}L, {moto.Tanque.TipoCombustible}");
            Console.WriteLine("====================================================");
        }
    }
}