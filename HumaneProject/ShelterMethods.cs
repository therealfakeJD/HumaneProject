using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class ShelterMethods
    {
        public Shelter shelter;
       
        public ShelterMethods()
        {
            shelter = new Shelter();
          
        }
        
        public void printShelterName()
        {
            Console.WriteLine(shelter.name);
        }

        public CareGiver AddCareGiver()
        {
            CareGiver careGiver = shelter.CreateAddCareGiver();
            return careGiver;
        }

        public void printCareGivers()
        {
            shelter.printCareGiverList();
        }
        public Dog addDogs()
        {
            Dog dog = shelter.createNewDog();
            return dog;
        }

        public void removeDogs()
        {
            shelter.removeDog();
        }

        public void printAnimalList()
        {
            shelter.printAnimalList();
        }

        public Cat addCats()
        {
            Cat cat = shelter.AddCatToList();
            return cat;
        }


        public void printWelcome()
        {
            Console.WriteLine("Welcome to Justin's Animal Shelter.");
            Console.WriteLine("This is a relatively new shelter so as of today possible Care Givers have a choice of Dogs or Cats, " +
                               "however, we will be expanding our care facilities soon... So there will be a greater selection of " +
                               "animals to adopt in the future");
            Console.WriteLine("");
            Console.WriteLine("This System will be what you need to use to help possible Care Givers take home one of our wonderful " +
                             " orphaned animals.");
            Console.WriteLine("*****************************************************************************************************");
        }

     
        }
        /*
        public void printShelter()
        {
            foreach (Animal dog in shelter.Animals)
            {
                Console.WriteLine(dog.name + " " + dog.cageNumber);
            }
            Console.ReadLine();
     
            foreach (Animal cat in shelter.Animals)
            {
                Console.WriteLine(cat.name + " " + cat.cageNumber);
            }
            Console.ReadLine();

            foreach (CareGiver careGiver in shelter.CareGivers)
            {
                Console.WriteLine("Adoptee: " + careGiver.name + "\nhas Adopted " + careGiver.adoptedName);
            }
            Console.ReadLine();
        }
        */
    }

 