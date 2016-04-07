using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class Shelter
    {

        public string name { get; set; }
        public Dog dog = new Dog();
        public Cat cat = new Cat();
        public decimal adoptionFee { get; set; }
        public CareGiver careGiver = new CareGiver();
        public List<List<Animal>> cageList = new List<List<Animal>>();
        public List<Animal> Dogs = new List<Animal>();
        public List<Animal> Cats = new List<Animal>(); 
        public List<CareGiver> CareGivers = new List<CareGiver>();
        public List<Cages> Cages = new List<Cages>(); 
        
        public Shelter()
        {
            name = "Justin's Humane Society Shelter";
        }

        public bool GiveShots()
        {
            dog.hasShots = true;
            return dog.hasShots;
        }

        public CareGiver AddCareGiver()
        {
            Console.WriteLine("Please Enter New Owner Information");
           
                CareGivers.Add(new CareGiver
                {
                    name = careGiver.AddName(),
                    age = careGiver.AddAge(),
                    socialSecurityNumber = careGiver.AddSocialSecurityNumber(),
                    address = careGiver.AddAddress(),
                    phoneNumber = careGiver.AddPhoneNumber(),
                    adoptedName = careGiver.AddAdoptedAnimalName(),
                    adoptedAge = careGiver.AddAdoptedAnimalAge()
                });
            return careGiver;
        }
    
        public Dog AddDog()
        {
            Console.WriteLine("Please Enter Dog Information");
            
            Dogs.Add(new Dog
            {
                dogBreed = dog.AddBreed(),
                sex = dog.GetSex(),
                name = dog.GetName(),
                weight = dog.GetWeight(),
                amountFoodPerDay = dog.GetAmountFedPerDay(),
                adoptionFee = dog.GetAdoptionFee(),
                hasBeenAdopted = dog.HasBeenAdopted()
            });
            return dog;
            
        }

        public Dog RemoveDog()
        {
            for (int i = 0; i < Dogs.Count; i++)
            {
                Dogs.RemoveAt(0);
            }
            return dog;
        }
        public Cat AddCat()
        {
            Console.WriteLine("Please Enter Cat Information");
       
            Cats.Add(new Cat
            {
                name = cat.GetName(),
                sex = cat.GetSex(),
                weight = cat.GetWeight(),
                amountFoodPerDay = cat.GetAmountFedPerDay(),
                adoptionFee = cat.GetAdoptionFee(),
                hasBeenAdopted = cat.HasBeenAdopted(),
                cageNumber = cat.GetCurrentCageNumber()
            });
            return cat;
        }

        public void printShelterName()
        {
            Console.WriteLine(name);
        }

        public void PrintCareGiverList()
        {
            foreach (CareGiver careGiver in CareGivers)
            {
                Console.WriteLine(careGiver.Display());
            }
        }
        
        public void PrintDogs()
        {
            
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine(dog.Display());
            }
            
        }

        public void PrintCats()
        {
            foreach (Cat cat in Cats)
            {
                Console.WriteLine(cat.Display());
            }
        }
  
   
        /*
        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Full Shelter Animal List");
            for (int i = 0; i < Animals.Count; i++)
            {
                yield return Animals[i];
              
            }
            yield return "No More Animals";
        }
        */
    }
}
