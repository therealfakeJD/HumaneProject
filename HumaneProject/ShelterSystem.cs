using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class ShelterSystem
    {
        public Shelter shelter = new Shelter();
        public ShelterUI shelterUI = new ShelterUI();
        public Cages anCages = new Cages();

        public int choice;
        public bool systemOn = true;

        public ShelterSystem()
        {
            RunShelterSystem();
        }

        public void RunShelterSystem()
        {
            shelterUI.printWelcome();
            Console.ReadLine();

            while (systemOn) { 
            Console.WriteLine("Please select a menu option to manage the shelter");
            Console.WriteLine("");
            Console.WriteLine("1. Add a new orphaned Cat to the system");
            Console.WriteLine("2. Add a new orphaned Dog to the system");
            Console.WriteLine("3. Collect a profile from a possibly interested Care Giver");
            Console.WriteLine("4. Print list of Dogs we have in our shelter");
            Console.WriteLine("5. Print list of Cats we have in our shelter");
            Console.WriteLine("6. Remove a dog from the system");
            Console.WriteLine("7. Print Current Care Giver Profiles");
            Console.WriteLine("8. Exit the system");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    shelter.AddCat();
                    break;

                case 2:

                    shelter.AddDog();
                    break;

                case 3:

                    shelter.AddCareGiver();
                    break;

                case 4:

                    shelter.PrintDogs();
                    break;

                case 5:

                    shelter.PrintCats();
                    break;

                case 6:

                    shelter.RemoveDog();
                    break;

                case 7:

                    shelter.PrintCareGiverList();
                    break;

                case 8:

                    shelter.printShelterName();
                    Console.WriteLine("Exit System...");
                    systemOn = false;
                    break;
                    

                default:
                    if (choice > 8)
                    {
                        Console.WriteLine("You must pick a number from the menu");
                        Console.WriteLine("Please press enter to continue");
                        Console.ReadLine();
                        RunShelterSystem();
                    }
                    break;
            }

        }
        Console.ReadLine();
        }
     



   
     
        }
        

    }

 