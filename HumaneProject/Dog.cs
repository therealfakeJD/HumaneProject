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
        public int shelterCode { get; set; }
        public string dogBreed { get; set; }
        public string sex { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public int amountFoodPerDay { get; set; }
        public bool hasShots { get; set; }
        public decimal adoptionFee { get; set; }
        public bool hasBeenAdopted { get; set; }
        public int cageNumber { get; set; }
        

        public Dog()
        {
          
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

        public int GetShelterCode()
        {
             Console.WriteLine("ID Number: ");
                try
                {
                    shelterCode = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Entry -- Please Enter a number");
                    GetShelterCode();
                }
                return shelterCode;
}

        public override Int32 GetWeight()
        {
            Console.WriteLine("Weight: ");
            try
            {
                weight = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                GetWeight();
            }
            return weight;
        }

        public override Int32 GetAmountFedPerDay()
        {
            Console.WriteLine("Food Requirements: ");
            try
            {
                amountFoodPerDay = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                GetAmountFedPerDay();
            }
            return amountFoodPerDay;
        }


        public override Decimal GetAdoptionFee()
        {
            Console.Write("Adoption Fee: $");
            try
            {
                adoptionFee = Convert.ToDecimal(Console.Read());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                GetAdoptionFee();
            }
            return adoptionFee;
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

        public override Int32 GetCurrentCageNumber()
        {
            Console.WriteLine("Cage Number: ");
            try
            {
                cageNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                GetCurrentCageNumber();
            }
            return cageNumber;
        }

        public override string Display()
        {
            return "\nBreed: " + dogBreed
                   + "\nName: " + name
                   + "\nSex " + sex
                   + "\nCurrent Weight: " + weight
                   + "\nFood Requirements: " + amountFoodPerDay
                   + "\nShots: " + hasShots
                   + "\nHas " + name + " been adopted? " + hasBeenAdopted
                   + "\nCurrent Placement: Dog Cage Number " + cageNumber;
        }

     }

 }

    

