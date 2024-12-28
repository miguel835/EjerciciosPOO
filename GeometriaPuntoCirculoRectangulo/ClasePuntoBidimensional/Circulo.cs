/* Clase Circulo
- Crear una clase Circulo que represente un circulo
- La clase debe tener atributos para el radio y la posición (utilizando un objeto Punto del ejercicio anterior)
- Implementar un constructor que inicialice el radio y la posición
- Implementar métodos para obtener el radio (getRadio() ), calcular el area (calcularArea() ),
calcular el perimetro (calcularPerimetro() ) y representar el circulo como una cadena de texto (toString() )
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePuntoBidimensional
{
    public class Circulo
    {
        //Atributos
        public double Radio;
        public Punto Posicion;
        //Constructor 
        public Circulo(double radio, Punto posicion)
        {
            this.Radio = radio;
            this.Posicion = posicion;
        }
        //Metodos
        public double getRadio()
        {
            return CalcularPerimetro()/(2*Math.PI);
        }
        public double CalcularArea()
        { 
            return Math.PI * Math.Pow(Radio, 2);
        }
        public double CalcularPerimetro()
        {
            return 2 * Radio * Math.PI;
        }
    }
}
