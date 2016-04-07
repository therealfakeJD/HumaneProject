using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class ShelterUI
    {
        public ShelterUI()
        {
         
        }

        public void printWelcome()
        {
            Console.WriteLine("Welcome to Justin's Animal Shelter.");
            Console.WriteLine("This is a relatively new shelter so as of today possible Care Givers have a choice of Dogs or Cats, " +
                               "however, we will be expanding our care facilities soon... So there will be a greater selection of " +
                               "animals to adopt in the future");
            Console.WriteLine("");
            Console.WriteLine("This System will be what you need to use to help possible Care Givers take home one of our wonderful " +
                             " orphaned animals.");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Please press enter to see the menu");
            Console.WriteLine("*****************************************************************************************************");
        }
    }
}
