using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn.HW08_Bank
{
    class BankAcc
    {

        class CuentaBancaria
        {
            private string nombre;
            private string apellidos;
            private string direccion;
            private string rfc;
            private double saldo;

            //Constructores
            public CuentaBancaria(string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string rfcPa)
            {
                nombre = nombrePa;
                apellidos = apellidosPa;
                saldo = saldoPa;
                direccion = direccionPa;
                rfc = rfcPa;
            }
            // Metodos
            public double Deposito(double dineroPa)
            {
                saldo += dineroPa;
                return saldo;
            }

            public double Retiro(double dineroPa)
            {
                if ((saldo - dineroPa) >= 0)
                {
                    saldo -= dineroPa;
                }
                else
                    Console.WriteLine("Saldo insuficiente.");

                return saldo;
            }

            public double ConsultaSaldo()
            {
                return saldo;
            }

            public override string ToString()
            {
                string mensaje = "\nNombre: " + nombre + "\nApellidos: " + apellidos + "\nSaldo: " + saldo + "\nDirección: " + direccion + "\nRFC: " + rfc;
                return mensaje;
            }
        }
    }
}
