using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            System system = new System();
            system.getCareGiverInformation();
            */
            System system = new System();
            system.manageCareGivers();  
            system.manageDogs();          
            Console.ReadLine();
        }

//        Requirements:
//    Console Application
//    Must be able to add an animal to the system
//    Must be able to remove an animal from the system and collect money from an adopter(object adopting an animal)
//    Must be able to track which animals have had their shots and give animals their shots if have not received it yet
//    Must be able to track animals in the system
//    Must be able to categorize animals in the system.This also involves which cage the animal is located in.
//    Adopters should have a profile.If an adopter adopts an animal, it should say which animal in the system. That means the same animal must be removed from the system.
//    Keep track of the food the animals need. This means dog will need x amount of dog feed per week, etc.Different animals need different food.

//[10:47]
//You must create a UML class diagram and stub out your code

//[10:47]
//Both must be approved by an instructor before you start working on the logic

//[10:49]
//gliffy.com

        //Requirements:

        // 1. Method to add animal to the system
        // 2. Method to remove animal from the system
        // 3. Method to collect money from and adopter object
        // 4. Method to track animals who have had shots
        // 5. Method to give shots if animals have not received shots
        // 6. Method to track all animals in the system
        // 7. Be able to categorize all animals in system
        // 8. Be able to identify which CAGE the animal is occupying
        // 9. Each adopter object should have a profile
        //10. Method to track which adopter has which animal
        //11. When animals are adopted they are removed
        //12. Method to track the food the animals need (which animals need to be fed) 
        //13. Different animals need different amounts of food for the week
    }
}
