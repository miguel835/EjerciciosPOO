/* Clase Punto Bidimensional
- Crear una clase Punto que representa un punto en el plano cartesiano
- La clase debe tener atributos para las coordenadas x e y
- Implementar un constructor que inicialice las coordenadas
- Implementar metodos para obtener las coordenadas (getX(), getY()), calcular la distancia al origen 
(distanciaAlOrigen()), calcular la distancia a otro punto (distanciaA(Punto otroPunto)) y representar el punto
como una cadena de texto (toString()).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePuntoBidimensional
{
    public class Punto
    {       
        //Atributos 
        public double x;
        public double y;
        //Constructor 
        public Punto(double ejeX, double ejeY)
        {
            this.x = ejeX;
            this.y = ejeY;
        }
        //Métodos 
        public string getX()
        {
            return x.ToString();
        }
        public string getY()
        {
            return y.ToString();
        }
        public double DistanciaHaciaElOrigen()
        {
            return Math.Sqrt(Math.Pow(x-0, 2) + Math.Pow(y-0, 2));
        }
        public double DistanciaHaciaUnPuntoEspecifico(Punto OtroPunto)
        {
            return Math.Sqrt(Math.Pow(x-OtroPunto.x, 2) + Math.Pow(y-OtroPunto.y, 2));
        }
    }
}
