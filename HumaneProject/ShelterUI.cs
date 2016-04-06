using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    class ShelterUI
    {
        public int choice;
        public bool systemOn = true;

        public ShelterUI()
        {
          RunShelterUI();
        }
        public void RunShelterUI()
        {
            ShelterMethods shelterMethods = new ShelterMethods();

            shelterMethods.printWelcome();
           
            while (systemOn)
            {
               
                Console.WriteLine("Please select a menu option to manage the shelter");
                Console.WriteLine("");
                Console.WriteLine("1. Add a new orphaned Cat to the system");
                Console.WriteLine("2. Add a new orphaned Dog to the system");
                Console.WriteLine("3. Collect a profile from a possibly interested Care Giver");
                Console.WriteLine("4. Print list of shelter animals currently in the system");
                Console.WriteLine("5. Print list of potential Care Givers currently in the system");
                Console.WriteLine("6. Remove a dog from the system");
                Console.WriteLine("7. Exit Menu");
                Console.WriteLine("");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        shelterMethods.addCats();
                        break;

                    case 2:

                        shelterMethods.addDogs();
                        break;

                    case 3:

                        shelterMethods.AddCareGiver();
                        break;

                    case 4:

                        shelterMethods.printAnimalList();
                        break;

                    case 5:

                        shelterMethods.printCareGivers();
                        break;

                    case 6:

                        shelterMethods.removeDogs();
                        break;

                    case 7:

                        systemOn = false;
                        break;

                    default:
                        if (choice > 7)
                        {
                            Console.WriteLine("You must pick a number from the menu");
                            Console.WriteLine("Please press enter to continue");
                            Console.ReadLine();
                            RunShelterUI();
                        }
                        break;
                }
               
            }
            Console.ReadLine();
        }
    }
}
