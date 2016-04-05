using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    interface IAnimal
    {
        string species { get; set; }
        string sex { get; set; }
        string name { get; set; }
        int weight { get; set; }
        int amountFoodPerDay { get; set; }
        bool hasShots { get; set; }
        decimal adoptionFee { get; set; }
        bool hasCareGiver { get; set; }
        bool hasBeenAdopted { get; set; }
        int cageNumber { get; set; }
        CareGiver currentCareGiver { get; set; }
    }
}

    

