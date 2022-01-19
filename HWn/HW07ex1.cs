using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn
{
    class HW07ex1
    {
        public static void Main()
        {


        //Variables locales
        string nombreAr, apellidoAr, direccion, rfc;
            double saldo;

            Console.WriteLine("Bienvenido a MJBANK Inc.\n");
            Console.WriteLine("Ingrese los siguientes campos que se le solicitan: \n");

            Console.Write("Nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("Apellidos: ");
            apellidoAr = Console.ReadLine();
            Console.Write("Dirección: ");
            direccion = Console.ReadLine();
            Console.Write("RFC: ");
            rfc = Console.ReadLine();
            Console.Write("Deposito inicial: ");
            saldo = Convert.ToDouble(Console.ReadLine());


            CuentaBancaria CB = new CuentaBancaria(nombreAr, apellidoAr, saldo, direccion, rfc);

            ///aqui empieza
            ///
            IDictionary<int, CuentaBancaria> dBank = new Dictionary<int, CuentaBancaria>()
            {
                { 0,  CB},
            };

            Console.WriteLine("TEMP: {0}", dBank[0].ConsultaSaldo());

            Console.ReadKey();

        /// aqui termina

            string op;
            do
            {
                Console.Clear();
                Console.WriteLine("" +
                    "\n1) Deposito." +
                    "\n2) Retiro." +
                    "\n3) Consultar Saldo." +
                    "\n4) Mostrar información de la cuenta." +
                    "\n5) Salir.");
                op = Console.ReadLine();
                Console.Clear();
                switch (op)
                {
                    case "1":
                        Console.Write("¿Cual es el monto que desea depositar?: ");
                        double cargar = Convert.ToDouble(Console.ReadLine());
                        CB.Deposito(cargar);
                        //Console.ReadKey();
                        break;
                    case "2":
                        //Console.Clear();
                        Console.Write("¿Cual es el monto que desea retirar?: ");
                        double retirar = Convert.ToDouble(Console.ReadLine());
                        CB.Retiro(retirar);
                        //Console.ReadKey();
                        break;
                    case "3":
                        //Console.Clear();
                        Console.Write("El saldo actual es: {0}", CB.ConsultaSaldo());
                        //Console.ReadKey();
                        break;
                    case "4":
                        //Console.Clear();
                        Console.WriteLine(CB.ToString());
                        //Console.ReadKey();
                        break;
                    case "5":
                        break;
                    default:
                        Console.Write("Opcion incorrecta.");
                        //Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            } while (op != "5");
        }
    }

    class Empleado
    {
        //Campos
        private string nombre, apellido, id, locker, banco, nip;

        //Constructor
        public Empleado(string nombrePa, string apellidoPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;

            //Llamando a los métodos para generar los números aleatorios
            id = GenerarID();
            locker = GenerarLocker();
            banco = AsignaBanco();
        }

        //Instaciamos a Random
        Random random = new Random();

        //Propiedades
        public string Nip
        {
            set => nip = value;
        }

        //Métodos
        private string GenerarID()
        {
            //Variables
            int i, numero;
            string id = "";

            for (i = 0; i < 10; i++)
            {
                numero = random.Next(10);

                id += numero.ToString();
            }
            return id;
        }

        private string GenerarLocker()
        {
            //Variables
            int i, numero;
            string locker = "";

            for (i = 0; i < 2; i++)
            {
                numero = random.Next(10);

                locker += numero.ToString();
            }
            return locker;
        }

        private string AsignaBanco()
        {
            //Variables
            int asignarBanco;
            string banco = "";

            asignarBanco = random.Next(1, 3);

            switch (asignarBanco)
            {
                case 1:
                    banco = "Santander";
                    break;
                case 2:
                    banco = "BBVA";
                    break;
            }
            return banco;
        }

        public override string ToString()
        {
            string mensaje = "";

            mensaje = "Empleado: " + nombre + " " + apellido + "\nNúmero de empleado: " + id + "\nLocker No. " + locker + "\nBanco asignado: " + banco;

            return mensaje;
        }
 
    }

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
            if (dineroPa > 0)
            {
                saldo += dineroPa;
                return saldo;
            }
            else
            {
                Console.WriteLine("Monto a depositar no puede ser negativo.");
                return saldo;
            }
        }

        public double Retiro(double dineroPa)
        {
            if (dineroPa > 0)
            {
                if ((saldo - dineroPa) >= 0)
                {
                    saldo -= dineroPa;
                }
                else
                    Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Console.WriteLine("Monto a retirar no puede ser negativo.");

            }
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