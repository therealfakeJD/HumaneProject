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
        public CareGiver careGiver = new CareGiver();
        public bool adoptionFee { get; set; }
        public List<Animal> Animals = new List<Animal>();
        public List<CareGiver> CareGivers = new List<CareGiver>();
        public List<Cages> Cages = new List<Cages>(); 
        


        public Shelter()
        {
            name = "Justin's Stupid Fucking Shelter";
            /*
            dog = new Dog();
            cat = new Cat();
            careGiver = new CareGiver();
            Cages = new List<Cages>();
            Animals = new List<Animal>();
            CareGivers = new List<CareGiver>();
            */
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
                    adoptedAge = careGiver.addAdoptedAnimalAge()
                });
            return careGiver;
        }

        public Dog createNewDog()
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
                hasBeenAdopted = dog.HasBeenAdopted()
            });
            return dog;
            
        }

        public Dog removeDog()
        {
            for (int i = 0; i < Animals.Count; i++)
            {
                Animals.RemoveAt(0);
            }
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
        
        public void printAnimalList()
        {
            
            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal.Display());
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
