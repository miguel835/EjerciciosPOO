using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GeneradorDeContraseñas
{
    public class Password
    {
        //Atributos 
        public int longitud = 8; //Por defecto 8 caracteres 
        public string contraseña;
        //Constructor por defecto
        public Password() { }
        //Constructor con la longitud de la contraseña que el usuario desea 
        public Password(int longitudDeLaContraseña)
        {
            longitud = longitudDeLaContraseña;
        }
        //Metodos 
        public string generarPassword()
        {
            string[] caracteresEspeciales = { ",", ".", "?", "¿", "¡", "!", "*", "%", "$", "@", "#"};
            string[] vocales = { "a", "e", "i", "o", "u"};
            string[] consonantes = { "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "n", "m", "ñ", "o", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"};
            Random random = new Random();
            string contraseñaGenerada = string.Empty;
            var estadoCompletado = false;
            while (estadoCompletado == false)
            {
                contraseñaGenerada += caracteresEspeciales[random.Next(0, caracteresEspeciales.Length)] + vocales[random.Next(0, vocales.Length)] + consonantes[random.Next(0, consonantes.Length)];
                if (contraseñaGenerada.Length == longitud) estadoCompletado = true;
                else if (contraseñaGenerada.Length > longitud)
                {
                    var cantidadAQuitar = contraseñaGenerada.Length - longitud;
                    contraseñaGenerada = contraseñaGenerada.Substring(0, cantidadAQuitar);
                    //Comprobar la cantidad de caracteres de la nueva contraseña 
                    if (contraseñaGenerada.Length == longitud) estadoCompletado = true;
                }
            }
            return contraseñaGenerada;
        }

    }
}
