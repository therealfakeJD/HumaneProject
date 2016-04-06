using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public abstract class Animal
    {
        
        public string sex { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public int ShelterID { get; set; }
        public int amountFoodPerDay { get; set; }
        public bool hasShots { get; set; }
        public bool giveShots { get; set; }
   
        public decimal adoptionFee { get; set; }
        public string shelterCareGiver { get; set; }
        public bool hasBeenAdopted { get; set; }
        public int cageNumber { get; set; }
        

       
        abstract public string GetSex();
        abstract public string GetName();
        abstract public int GetWeight();
        abstract public int GetAmountFedPerDay();
        abstract public bool HasShots();
        abstract public bool GiveShots();
        abstract public decimal GetAdoptionFee();
        abstract public string GetShelterCareGiver();
        abstract public bool HasBeenAdopted();
        abstract public int GetCurrentCageNumber();
        abstract public string Display();


    }
}
