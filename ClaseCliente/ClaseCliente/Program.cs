using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuración visual de la consola 
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("CLASE CLIENTE");
            Random random = new Random();
            Cliente cliente1 = new Cliente("Ximena Harris", "Calle 7 y 9, Avenida Quito", "0999758598", random.Next(50, 1000));
            Console.WriteLine("\t Cliente 1");
            Console.WriteLine("Nombre: " + cliente1.getNombre());
            Console.WriteLine("Direccion: " + cliente1.getDireccion());
            Console.WriteLine("Telefono: " + cliente1.getTelefono());
            Console.WriteLine("ID cliente: " + cliente1.getNumeroCliente());
            Producto producto1 = new Producto("Rosca de reyes", 12, 50, "Roscas de reyes de chocolate");
            Console.WriteLine("\nSe vende lo siguiente");
            Console.WriteLine("Nombre producto: " + producto1.getNombre());
            Console.WriteLine("Precio producto: " + producto1.getPrecio());
            Console.WriteLine("Cantidad en stock: " + producto1.getCantidadStock());
            Console.WriteLine("Descripcion: " + producto1.getDescripcion());
            Console.WriteLine($"¿Deseas comprar {producto1.getNombre()}?");
            string answer = Console.ReadLine();
            if (answer == "Si" || answer == "si")
            {
                Console.WriteLine("¿Cuantos va a comprar?");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                producto1.vender(cantidad);
            }
            else
            {
                Console.WriteLine("Tambien se puede hacer pedidos");
                Console.WriteLine("¿Desea hacer un pedido?");
                answer = Console.ReadLine();
                if (answer == "si" || answer == "Si")
                {
                    Console.WriteLine("¿Cuantos va a comprar?");
                    int cantidad = int.Parse(Console.ReadLine());
                    if (cantidad > 0 && cantidad <= producto1.getCantidadStock())
                    {
                        producto1.vender(cantidad);
                        Pedido pedido1 = new Pedido(cliente1, DateTime.Now, new List<string>());
                        pedido1.agregarProducto(producto1);
                        Console.WriteLine("Pedido agendado");
                    }
                    else Console.WriteLine("Cantidad inválida o no hay suficiente stock.");
                }
                else Console.WriteLine("Presione cualquier tecla para salir");
            }
        }
    }
}
