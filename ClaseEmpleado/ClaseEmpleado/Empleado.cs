/* Clase Empleado 
- Crear un clase empleado que represente a un empleado
- La clase debe tener atributos para el nombre,  el numero de empleado, el salario y el departamento
- Implementar un constructor que inicialice los atributos
- Implementar métodos para obtener el nombre (getNombre()), obtiene el numero de empleado (getNumeroEmpleado() ),
obtener el salario (getSalario() ), obtener el departamento (getDepartamento() ), aumentar el salario 
(aumentarSalario(double porcentaje)), y representar el empleado como una cadena de texto (toString() )
*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEmpleado
{
    public class Empleado
    {
        //Atributos
        public string nombre;
        public int NumeroEmpleado;
        public double salario;
        public string departamento;
        //Constructor
        public Empleado(string nombreDelEmpleado, int numeroDelEmpleado, double salarioEmpleado, string Departamento)
        {
            this.nombre = nombreDelEmpleado;
            this.NumeroEmpleado = numeroDelEmpleado;
            this.salario = salarioEmpleado;
            this.departamento = Departamento;
        }
        //Métodos 
        public string getNombre()
        {
            return nombre;
        }
        public int getNumeroEmpleado()
        {
            return NumeroEmpleado;
        }
        public double getSalario()
        {
            return salario;
        }
        public string getDepartamento()
        {
            return departamento;
        }
        public double aumentarSalario(double porcentaje)
        {
            salario += salario * (porcentaje/100);
            return salario;
        }
    }
}
