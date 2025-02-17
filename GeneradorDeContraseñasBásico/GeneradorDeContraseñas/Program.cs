//https://www.discoduroderoer.es/ejercicios-propuestos-y-resueltos-programacion-orientado-a-objetos-java/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeContraseñas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20,0);
            Console.WriteLine("GENERADOR DE CONTRASEÑAS");
            Console.WriteLine("¿Desea una contraseña de 8 caracteres? [Si/No]");
            string answers = Console.ReadLine().ToLower().Trim();
            if (answers == "si" || answers == "sí")
            {
                //Llamar para que se construya una contraseña con 8 caracteres 
                Password passwd= new Password();
                Console.WriteLine("La contraseña generada es: " + passwd.generarPassword());
            }
            else
            {
                Console.WriteLine("¿De cuantos caracteres desea la contraseña?");
                int lengthPassword = int.Parse(Console.ReadLine());
                Password passwdPersonalizada = new Password(lengthPassword);
                Console.WriteLine("La contraseña generada es: " + passwdPersonalizada.generarPassword()); 
            }
            Console.ReadKey();
        }
    }
}
