/* Clase Pedido
- Crear una clase Pedido que represente un pedido de un cliente
- La clase debe tener atributos para el cliente (utilizando un objeto cliente del ejercicio anterior), la fecha del pedido,
la lista de productos (utilizando un array o lista) y el total del pedido
- Implementar un constructor que inicialice los atributos
- Implementar metodos para agregar un producto al pedido (agregarProducto(Producto producto)), calcular el total del 
pedido (calcularTotal() ), y representar el pedido como una cadena de texto (toString() ). 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCliente
{
    public class Pedido
    {
        //Atributos
        public Cliente cliente1;
        public DateTime dateTime;
        public List<string> lista = new List<string>();
        public double totalDelPedido;
        //Constructor
        public Pedido(Cliente cliente, DateTime time, List<string> listaProductos)
        {
            cliente1 = cliente;
            dateTime = time;
            lista = listaProductos;
        }
        //Metodos
        public void agregarProducto(Producto producto)
        {
            lista.Add(producto.getNombre());
            totalDelPedido += producto.getPrecio();
        }
        public double calcularTotal()
        {
            return totalDelPedido;
        }
    }
}
