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
        public Dog dog;
        public Cat cat;
        public CareGiver careGiver;
        public bool adoptionFee { get; set; }
        public List<Animal> Animals;
        public List<CareGiver> CareGivers;

        public Shelter()
        {
            name = "Justin's Stupid Fucking Shelter";
            dog = new Dog();
            cat = new Cat();
            careGiver = new CareGiver();
            Animals = new List<Animal>();
            CareGivers = new List<CareGiver>();
        }
        
     
        public CareGiver CreateAddCareGiver()
        {
            Console.WriteLine("Please Enter New Owner Information");
           
                CareGivers.Add(new CareGiver
                {
                    name = careGiver.addName(),
                    age = careGiver.addAge(),
                    socialSecurityNumber = careGiver.addSocialSecurityNumber(),
                    address = careGiver.addAddress(),
                    phoneNumber = careGiver.addPhoneNumber(),
                    adoptionFee = careGiver.getAdoptionFee(),
                    adoptedName = careGiver.addAdoptedAnimalName(),
                    adoptedAge = careGiver.addAdoptedAnimalAge(),
                });
            return careGiver;
        }

        public Dog AddDogToList()
        {
            Console.WriteLine("Please Enter Dog Information");

            Animals.Add(new Dog
            {
                dogBreed = dog.AddBreed(),
                sex = dog.GetSex(),
                name = dog.GetName(),
                weight = dog.GetWeight(),
                amountFoodPerDay = dog.GetAmountFedPerDay(),
                hasShots = dog.HasShots(),
                adoptionFee = dog.GetAdoptionFee(),
                shelterCareGiver = dog.GetShelterCareGiver(),
                hasBeenAdopted = dog.HasBeenAdopted(),
                cageNumber = dog.GetCurrentCageNumber()
            });
            return dog;
        }

        public Cat AddCatToList()
        {
            Console.WriteLine("Please Enter Cat Information");

            Animals.Add(new Cat
            {
                catBreed = cat.AddBreed(),
                sex = cat.GetSex(),
                name = cat.GetName(),
                weight = cat.GetWeight(),
                amountFoodPerDay = cat.GetAmountFedPerDay(),
                hasShots = cat.HasShots(),
                adoptionFee = cat.GetAdoptionFee(),
                shelterCareGiver = cat.GetShelterCareGiver(),
                hasBeenAdopted = cat.HasBeenAdopted(),
                cageNumber = cat.GetCurrentCageNumber()
            });
            return cat;
        } 
        public void printCareGiverList()
        {
            foreach (CareGiver careGiver in CareGivers)
            {
                Console.WriteLine(careGiver.display());
            }
        }

        public void printDogInList()
        {
            foreach (Animal dog in Animals)
            {
                Console.WriteLine(dog.Display());
            }
        }
        
        public void printCatInList()
        {
            foreach (Animal cat in Animals)
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
