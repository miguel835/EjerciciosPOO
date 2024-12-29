using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaseCuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración Visual de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("CLASE CUENTA BANCARIA");
            Console.WriteLine("BIENVENIDO AL BANCO 3 TELEMATICA");
            Console.Write("Ingrese el nombre del titular de la cuenta: ");
            string Titular = Console.ReadLine();
            Console.Write("Ingrese el tipo de cuenta [ahorro/corriente]: ");
            string tipo = Console.ReadLine();
            Console.Write("Ingrese la cantidad de dinero que va a dejar en la cuenta: ");
            double valorDinero = double.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            CuentaBancaria cuentaBancaria = new CuentaBancaria(aleatorio.Next(100, 10000000).ToString(), Titular, valorDinero, tipo);
            Console.WriteLine("Listo ahora ya tiene su cuenta y puede realizar depositos y retiros");
            Thread.Sleep(500);
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("[0] Depositar");
                Console.WriteLine("[1] Retirar");
                Console.WriteLine("[2] Ver el tipo de cuenta");
                Console.WriteLine("[3] Consultar saldo");
                Console.WriteLine("[4] Salir");
                Console.Write("Ingresar opción: ");
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 4)
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }
                switch (opcion)
                {
                    case 0: 
                        cuentaBancaria.depositar();
                        break;
                    case 1:
                        cuentaBancaria.retirar();
                        break;
                    case 2:
                        Console.WriteLine($"El tipo de cuenta es: {cuentaBancaria.getTipoCuenta()}");
                        break;
                    case 3:
                        Console.WriteLine($"El saldo de la cuenta es : {cuentaBancaria.consultarSaldo()}");
                        break;
                    case 4:
                        Console.WriteLine("Ha salido exitosamente");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (true);
        }
    }
}
