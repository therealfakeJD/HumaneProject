using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class System
    {
        Shelter shelter = new Shelter();
        public void manageCareGivers()
        {
            shelter.AddCareGiverToList();
            Console.ReadLine();
            Console.WriteLine("**********************");
            shelter.printCareGiverList();
            Console.WriteLine("**********************");
        }

        public void manageDogs()
        {
            shelter.AddDogToDogList();
            Console.ReadLine();
            Console.WriteLine("**********************");
            shelter.printDogList();
            Console.WriteLine("**********************");
            Console.ReadLine();
        }

    }
}
 