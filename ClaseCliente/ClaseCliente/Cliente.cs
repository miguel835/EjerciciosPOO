/* Clase Cliente
- Crear una clase Cliente que representa a un cliente de una tienda.
- La clase debe tener atributos para el nombre, la dirección, el telefono y el numero de cliente.
- Implementar un constructor que inicialice los atributos
- Implementar metodos para obtener el nombre (getNombre() ), obtener la dirección(getDireccion() ), obtener el telefono
(getTelefono() ), obtener el numero de cliente (getNumeroCliente() ), y representar el cliente como una cadena
de texto (toString() ). 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCliente
{
    public class Cliente
    {
        //Atributos
        public string nombre;
        public string dirección;
        public string telefono;
        public int numeroDeCliente;
        //Constructor
        public Cliente(string nombreCliente, string direcciónCliente, string telefonoCliente, int numeroCliente)
        {
            this.nombre = nombreCliente;
            this.dirección = direcciónCliente;
            this.telefono = telefonoCliente;
            this.numeroDeCliente = numeroCliente;
        }
        //Metodos
        public string getNombre() 
        {
            return nombre;
        }
        public string getDireccion()
        {
            return dirección;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public int getNumeroCliente()
        {
            return numeroDeCliente;
        }
    }
}
