/* Clase Rectangulo
- Crear una clase Rectangulo que represente un rectangulo
- La clase debe tener atributos para la base, la altura y la posición (utilizando un Punto del ejercicio anterior)
- Implementar un constructor 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePuntoBidimensional
{
    public class Rectangulo
    {
        //Atributos
        public double baseDelRectangulo;
        public double alturaDelRectangulo;
        public Punto Posicion;
        //Constructor
        public Rectangulo(double BaseRect, double AlturaRect, Punto PosicionRect)
        {
            this.baseDelRectangulo = BaseRect;
            this.alturaDelRectangulo = AlturaRect;
            this.Posicion = PosicionRect;
        }
        //Metodos
        public double getBase()
        {
            return baseDelRectangulo;
        }
        public double getAltura()
        {
            return alturaDelRectangulo;
        }
        public double calcularArea()
        {
            return baseDelRectangulo * alturaDelRectangulo;
        }
        public double calcularPerimetro()
        {
            return 2*baseDelRectangulo + 2*alturaDelRectangulo;
        }
    }
}
