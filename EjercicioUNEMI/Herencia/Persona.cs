using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Persona
    {
        //Atributos 
        public string nombre;
        public string apellido;
        public string altura;
        public int edad;
        //Constructor 
        public Persona(string Nombre, string Apellido, string Altura, int Edad)
        {
            nombre = Nombre;
            apellido = Apellido;
            altura = Altura;
            edad = Edad;
        }
        //Metodos
        public string GetInfo()
        {
            return nombre + " " + apellido + " " + altura + " " + edad;
        }
    }
}
