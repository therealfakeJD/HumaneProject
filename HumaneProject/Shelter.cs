using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class Shelter
    {
        public string name { get; set; }
        public bool adoptionFee { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<CareGiver> CareGivers { get; set; }

        public List<CareGiver> AddCareGiverToList()
        {
            CareGivers = new List<CareGiver>();
            CareGiver careGiver = new CareGiver();
            
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
            return CareGivers;
        }

        public List<Dog> AddDogToDogList()
        {
            Dogs = new List<Dog>();
            Dog dog = new Dog();

            Dogs.Add(new Dog
            {
                animalType = dog.AddAnimalType(),
                dogBreed = dog.AddBreed(),
                sex = dog.GetSex(),
                name = dog.GetName(),
                weight = dog.GetWeight(),
                amountFoodPerDay = dog.GetAmountFedPerDay(),
                hasShots = dog.HasShots(),
                adoptionFee = dog.GetAdoptionFee(),
                shelterCareGiver = dog.GetShelterCareGiver(),
                hasBeenAdopted = dog.HasBeenAdopted(),
                cageNumber = dog.GetCurrentCageNumber(),
            });
            return Dogs;
        } 
        public void printCareGiverList()
        {
            foreach (CareGiver careGiver in CareGivers)
            {
                Console.WriteLine(careGiver.display());
            }
        }
        public void printDogList()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine(dog.display());
            }
        }
      
    }
}
