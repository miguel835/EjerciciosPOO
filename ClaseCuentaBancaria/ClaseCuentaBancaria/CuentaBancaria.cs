/* Clase Cuenta Bancaria
- Crear una clase CuentaBancaria que represente una cuenta bancaria
- La clase debe tener atributos para el numero de cuenta, el titular, el saldo y el tipo de cuenta (ahorro, corriente)
- Implementar un constructor que inicialice los atributos
- Implementar metodos para depositar dinero (depositar(double monto)), retirar dinero (retirar(double monto)), 
consultar saldo (consultarSaldo()) y obtener el tipo de cuenta (getTipoCuenta()). 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ClaseCuentaBancaria
{
    public class CuentaBancaria
    {
        //Atributos
        public string NumeroCuenta;
        public string Titular;
        public double Saldo;
        public string TipoCuenta;
        //Constructor
        public CuentaBancaria(string numCuenta, string nombreDelTitular, double CantidadDeDinero, string TypeCuenta)
        {
            this.NumeroCuenta = numCuenta;
            this.Titular = nombreDelTitular;
            this.Saldo = CantidadDeDinero;
            this.TipoCuenta = TypeCuenta;
        }
        //Metodos
        public void depositar()
        {
            Console.Write("Ingrese el monto a depositar: ");
            float monto = float.Parse(Console.ReadLine());
            if (monto <= 0)
            {
                string cadenaMonto = monto.ToString();
                if (cadenaMonto.Contains("-"))
                {
                    cadenaMonto = cadenaMonto.Remove('-');
                    monto = float.Parse(cadenaMonto);
                    Saldo += monto;
                    Console.WriteLine("Deposito realizado exitosamente");
                }
                else if (monto == 0) Console.WriteLine("No aceptamos ceros");
            }
            Saldo += monto;
            Console.WriteLine("Deposito realizado exitosamente");
        }
        public void retirar()
        {
            Console.Write("Ingrese el monto a retirar: ");
            float montoRetirar = float.Parse(Console.ReadLine());

            if (montoRetirar <= 0)
            {
                string cadenaMontoRetiro = montoRetirar.ToString();
                if (cadenaMontoRetiro.Contains("-"))
                {
                    cadenaMontoRetiro = cadenaMontoRetiro.Remove('-');
                    montoRetirar = float.Parse(cadenaMontoRetiro);
                    Saldo -= montoRetirar;
                    Console.WriteLine("Retiro realizado exitosamente");
                }
                else if (montoRetirar == 0) Console.WriteLine("No aceptamos ceros");
            }
            else if (montoRetirar > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else if (montoRetirar < Saldo)
            {
                Saldo -= montoRetirar;
                Console.WriteLine("Retiro realizado exitosamente");
            }
            
        }
        public string consultarSaldo() 
        {
            //Console.WriteLine($"El saldo actual de la cuenta es: {Saldo}");
            return Saldo.ToString();
        }
        public string getTipoCuenta()
        {
            //Console.WriteLine($"El tipo de cuenta es: {TipoCuenta}");
            return TipoCuenta.ToString();
        }
    }
}
