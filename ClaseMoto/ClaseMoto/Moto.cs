using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClaseMoto
{
    //Clase Moto
    public class Moto
    {
        //Atributos 
        public string marca_de_moto;
        public string modelo_de_moto;
        public int año_de_moto;
        //Propiedades de tipo Motor y tipo Tanque
        public Motor Motor { get; set; }
        public Tanque Tanque { get; set; }
        //Métodos 
        public void Arrancar() {Console.WriteLine($"La moto {marca_de_moto} esta lista para rodar.");}
        public void Frenar() {Console.WriteLine($"La moto {marca_de_moto} freno con seguridad.");}
    }
}
