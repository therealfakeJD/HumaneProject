using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class Dog : Animal
    {
        public string animalType { get; set; }
        public string dogBreed { get; set; }
        public string sex { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public int amountFoodPerDay { get; set; }
        public bool hasShots { get; set; }
        public decimal adoptionFee { get; set; }
        public string shelterCareGiver { get; set; }
        public bool hasBeenAdopted { get; set; }
        public int cageNumber { get; set; }
       

        public Dog()
        {
            
        }

        

        public override String AddAnimalType()
        {
            Console.WriteLine("Animal Information: ");
            Console.WriteLine("Type: ");
           
            animalType = Console.ReadLine();
            return animalType;
        }

        public string AddBreed()
        {
            Console.WriteLine("Breed: ");
            dogBreed = Console.ReadLine();
            return dogBreed;
        }

        public override String GetSex()
        {
            Console.WriteLine("Sex: ");
            sex = Console.ReadLine();
            return sex;
        }

        public override String GetName()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            return name;
        }

        public override Int32 GetWeight()
        {
            Console.WriteLine("Weight: ");
            weight = Convert.ToInt32(Console.ReadLine());
            return weight;
        }

        public override Int32 GetAmountFedPerDay()
        {
            Console.WriteLine("Food Requirements: ");
            amountFoodPerDay = Convert.ToInt32(Console.ReadLine());
            return amountFoodPerDay;
        }

        public override Boolean HasShots()
        {
            Console.WriteLine("Shots: ");
            if (GiveShots())
            {
                Console.WriteLine("Shots Given");
            }
            else
            {
                Console.WriteLine("Shots Needed");
            }
            return hasShots;
        }

        public override Boolean GiveShots()
        {
            Console.WriteLine("Animal has been given shots");
            hasShots = true;
            return hasShots;
        }

        public override Decimal GetAdoptionFee()
        {
            Console.Write("Adoption Fee: $");
            adoptionFee = Convert.ToDecimal(Console.Read());
            return adoptionFee;
        }

        public override String GetShelterCareGiver()
        {
            Console.WriteLine("Current Shelter Worker in Charge of Care: ");
            shelterCareGiver = Console.ReadLine();
            return shelterCareGiver;
        }

        public override Boolean HasBeenAdopted()
        {
            if (hasBeenAdopted)
            {
                Console.WriteLine(name + " has been adopted");
            }
            else
            {
                Console.WriteLine(name + " is currently waiting to be adopted");
            }
            return hasBeenAdopted;
        }

        public bool adopt()
        {
            hasBeenAdopted = true;
            return hasBeenAdopted;
        }

        public override Int32 GetCurrentCageNumber()
        {
            Console.WriteLine("Cage Number: ");
            cageNumber = Convert.ToInt32(Console.ReadLine());
            return cageNumber;
        }

        public string display()
        {
            return "Type: " + animalType
                   + "\nBreed: " + dogBreed
                   + "\nName: " + name
                   + "\nSex " + sex
                   + "\nCurrent Weight: " + weight
                   + "\nFood Requirements: " + amountFoodPerDay
                   + "\nShots: " + hasShots
                   + "\nAdoption Cost: " + adoptionFee
                   + "\nCurrent Shelter Care Giver: " + shelterCareGiver
                   + "\nHas " + name + " been adopted? " + hasBeenAdopted
                   + "\nCurrent Placement: Dog Cage Number " + cageNumber;
        }

        
    }

 

}

    

