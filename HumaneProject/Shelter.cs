using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            /*
            CareGivers.Add(new CareGiver
            {
                name = careGiver.name,
                age = careGiver.age,
                socialSecurityNumber = careGiver.socialSecurityNumber,
                address = careGiver.address,
                phoneNumber = careGiver.phoneNumber,
                adoptionFee = careGiver.adoptionFee,
                adoptedName = careGiver.adoptedName,
                adoptedAge = careGiver.adoptedAge,

            });
            */
            return CareGivers;
        }

        public void printCareGiverList()
        {
            foreach (CareGiver careGiver in CareGivers)
            {
                Console.WriteLine(careGiver.careGiverToString());
            }
        }
      
    }
}
