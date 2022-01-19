using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Needed for make modify files.

using static HWn.HW08_Bank.Menu;

namespace HWn.HW08_Bank
{
    class HW08ex1
    {
        public static void Main()
        {

            String option;
            Boolean running = true;
            string path = @"D:\_Jaime\_GIT\01 Collaborators\04 MacroHex\01 MaCroSharp\01 Cursos\01 HWs\HW\HWn\HW08_Bank\clientsDatabase.db";
            List<Client> listClients = new List<Client>();
            int lastClientIndex = 1000;

            // Load clients from file.
            if (!File.Exists(path)) Console.WriteLine("WARGNING: File not loaded.");
            else{
                using (FileStream fsr = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fsr)){
                    string string4;
                    string[] stringArray;
                    do{
                        string4 = sr.ReadLine();

                        if (string4 != null){
                            stringArray = string4.Split(';');
                            listClients.Add(new Client(stringArray[0], stringArray[1], stringArray[2], stringArray[3], stringArray[4], stringArray[5], stringArray[6], stringArray[7]));
                            lastClientIndex = Convert.ToInt32(stringArray[0]);
                        }
                    } while (string4 != null);
                }
            }

            // run menu program.
            while (running){
                MenuPrint();
                option = MenuOption();
                switch (option){
                    case "1":
                        lastClientIndex++;
                        Client user = new Client(lastClientIndex);
                        user.ToString();
                        listClients.Add(user);

                        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                        using (StreamWriter sw = new StreamWriter(fs)){
                            foreach (Client client in listClients){
                                sw.WriteLine(client.ToCVS());
                            }
                        }

                        break;
                    case "2":
                        int idToFind;
                        Client targetUser = null;
                        Console.WriteLine("Enter client ID to find: ");
                        idToFind = Convert.ToInt32(Console.ReadLine());
                        foreach (Client client in listClients)
                        {
                            if (client.GetId().CompareTo(idToFind) == 0)
                            {
                                Console.WriteLine("Usuario encontrado!");
                                targetUser = client;
                                break;
                            }
                        }

                        if (targetUser != null)
                        {
                            Console.WriteLine(targetUser.ToString());
                        }
                        else
                        {
                            Console.WriteLine("El usuario con id {0} no existe.", idToFind);
                        }

                        Console.WriteLine("Press enter to continue...");
                        Console.ReadKey();
                        break;
            
                    case "3":
                        Console.WriteLine("Printing all clients: \n-------------------");
                        foreach (Client client in listClients)
                        {
                            Console.WriteLine(client.ToStringOneLine());
                        }
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadKey();
                        break;
                    case "5":
                        running = false;
                        break;
                }
            }
        }
    }
}
