using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWn.HW08_Bank
{
    class Client
    {
        //User Fields
        private string name;
        private string surname;
        private string dniNumber;
        private string direction;
        private string phone;
        private string email;

        // Generated Fileds
        private int idClient;
        private string defaultPIN;

        //Constructores
        public Client(int lastIndex)
        {
            idClient = lastIndex;
            SetName();
            SetSurname();
            SetDniNumber();//dniNumber = dniNumberPa;
            SetDirection();//direction = directionPa;
            SetPhone();//phone = phonePa;
            SetEmail();//email = emailPa;

            //Llamando a los métodos para generar los números aleatorios
            //idClient = GenerarID(); //cargardo el ultimo index
            defaultPIN = DefaultPin();
        }
        public Client(string idClientPA, string namePa, string surnamePa, string dniNumberPa, string directionPa, string phonePa, string emailPa,  string defaulPINPA)
        {
            idClient = Convert.ToInt32(idClientPA);
            name = namePa;
            surname = surnamePa;
            dniNumber = dniNumberPa;
            direction = directionPa;
            phone = phonePa;
            email = emailPa;
            defaultPIN = defaulPINPA;
        }

        //Instaciamos a Random
        Random random = new Random();

        //Propiedades
        public void SetName()
        {
            Console.Write("Name: ");
            string tempNomre = Console.ReadLine();
            name = tempNomre;
        }

        public void SetSurname()
        {
            Console.Write("Surname: ");
            string tempSurname = Console.ReadLine();
            surname = tempSurname;
        }

        public void SetDniNumber()
        {
            Console.Write("DNI: ");
            string tempDni = Console.ReadLine();
            dniNumber = tempDni;
        }

        public void SetDirection()
        {
            Console.Write("Adress: ");
            direction = Console.ReadLine();
        }

        public void SetPhone()
        {
            Console.Write("Phone: ");
            phone = Console.ReadLine();
        }

        public void SetEmail()
        {
            Console.Write("Email: ");
            email = Console.ReadLine();
        }

        public int GetId()
        {
            return idClient;
        }

        private int GenerarID()
        {
            //Variables
            int i, numero;
            string id = "";

            for (i = 0; i < 5; i++)
            {
                numero = random.Next(10);

                id += numero.ToString();
            }
            return Convert.ToInt32(id);
        }

        private string DefaultPin()
        {
            //Variables
            int i, numero;
            string id = "";

            for (i = 0; i < 4; i++)
            {
                numero = random.Next(10);

                id += numero.ToString();
            }
            return id;
        }

        public string ToCVS()
        {
            return idClient + ";" + name + ";" + surname + ";" + dniNumber + ";" + direction + ";" + phone + ";" + email + ";" +  defaultPIN;
        }

        public override string ToString()
        {
            string mensaje = "";
            mensaje += "\nID Client: " + idClient;
            mensaje += "\nUser: " + surname;
            mensaje += ", " + name;
            mensaje += "\nDNI: " + dniNumber + "\tPhone: " + phone;
            mensaje += "\nDirection: " + direction;
            mensaje += "\nEmail: " + email;
            return mensaje;
        }

        public string ToStringOneLine()
        {
            string mensaje = "";
            mensaje += "ID Client: " + idClient;
            mensaje += "\tUser: " + surname;
            mensaje += ", " + name;
            return mensaje;
        }

    }
}
