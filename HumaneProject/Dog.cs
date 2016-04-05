using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class Dog : IAnimal
    {
        public string species { get; set; }
        public string sex { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public int amountFoodPerDay { get; set; }
        public bool hasShots { get; set; }
        public decimal adoptionFee { get; set; }
        public bool hasCareGiver { get; set; }
        public bool hasBeenAdopted { get; set; }
        public int cageNumber { get; set; }
        public CareGiver currentCareGiver { get; set; }


    }

 

}

    

