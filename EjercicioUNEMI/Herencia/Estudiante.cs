using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Estudiante : Persona
    {
        //Atributos
        public string carrera;
        public string ID;
        public string facultad;
        //Constructor
        public Estudiante(string Nombre, string Apellido, string Altura, int Edad, string Carrera, string id, string Facultad) : base(Nombre, Apellido, Altura, Edad)
        {
            carrera = Carrera;
            ID = id;
            facultad = Facultad;
        }
        //Metodos
        public string GetInfoStudent()
        {
            return carrera + " " + ID + " " + facultad;
        }

    }
}
