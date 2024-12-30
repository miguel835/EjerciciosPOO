/* Clase Producto
- Crear una clase Producto que represente un producto en venta
- La clase debe tener atributos para el nombre, el precio, la cantidad en stock y la descripción
- Implementar un constructor que inicialice los atributos
- Implementar metodos para obtener el nombre (getNombre() ), obtener el precio (getPrecio() ), obtener la cantidad en 
stock (getCantidadStock() ), obtener la descripción (getDescripción() ), vender un producto (vender(int unidades)) y 
representar el producto como una cadena de texto (toString() )
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCliente
{
    public class Producto
    {
        //Atributos
        public string nombre, descripcion;
        public double precio;
        public int cantidadStock;
        //Constructor
        public Producto(string nombreProducto, double precioProducto, int cantidadEnStock, string descripcionProducto)
        {
            this.nombre = nombreProducto;
            this.precio = precioProducto;
            this.cantidadStock = cantidadEnStock;
            this.descripcion = descripcionProducto;
        }
        //Metodos
        public string getNombre()
        {
            return nombre;
        }
        public double getPrecio()
        {
            return precio;
        }
        public int getCantidadStock() 
        {
            return cantidadStock;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public void vender(int unidades)
        {
            if (unidades > cantidadStock) Console.WriteLine($"En stock tan solo tenemos {cantidadStock}");
            else
            {
                cantidadStock -= unidades;
                Console.WriteLine($"Venta realizada que tenga buen dia");
            }
        }
    }
}
