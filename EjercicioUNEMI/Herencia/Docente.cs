using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Docente : Persona
    {
        //Atributos
        public string sueldo;
        public string areaDeEspecializacion;
        //Constructor
        public Docente(string Nombre, string Apellido, string Altura, int Edad, string Sueldo, string AreaDeEspecializacion) : base(Nombre, Apellido, Altura, Edad)
        {
            sueldo = Sueldo;
            areaDeEspecializacion = AreaDeEspecializacion;
        }
        //Metodos
        public string GetInfoDocent()
        {
            return sueldo + " " + areaDeEspecializacion;
        }
    }
}
