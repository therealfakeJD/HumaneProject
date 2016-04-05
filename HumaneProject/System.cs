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

        public void manageCareGivers()
        {
            Shelter shelter = new Shelter();
            shelter.AddCareGiverToList();
            Console.ReadLine();
            Console.WriteLine("**********************");
            shelter.printCareGiverList();
        }

    }
}
 