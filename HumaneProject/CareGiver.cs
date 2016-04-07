using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneProject
{
    public class CareGiver
    {
        public string name { get; set; }
        public int age { get; set; }
        public long socialSecurityNumber { get; set; }
        public string address { get; set; }
        public bool adopt { get; set; }
        public decimal careGiverWallet;
        public long phoneNumber { get; set; }
        public string adoptedName { get; set; }
        public int adoptedAge { get; set; }
        

        public CareGiver()
        {
            

        }

        public string AddName()
        {
            Console.WriteLine("CareGiver Information: ");
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            return name;
        }

        public int AddAge()
        {
            Console.WriteLine("Age: ");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please enter a number");
                AddAge();
            }
            return age;
        }

        public long AddSocialSecurityNumber()
        {
            Console.WriteLine("Social Security Number: ");
            try
            {
                socialSecurityNumber = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                AddSocialSecurityNumber();
            }
            return socialSecurityNumber;
        }

        public string AddAddress()
        {
            Console.WriteLine("Address: ");
            address = Console.ReadLine();
            return address;
        }

        public long AddPhoneNumber()
        {
            Console.WriteLine("Phone Number: ");
            try
            {
                phoneNumber = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                AddPhoneNumber();
            }
            return phoneNumber;
        }

        public bool Adopt(Dog dog)
        {
            careGiverWallet = new decimal(1000.00);
            Console.WriteLine(careGiverWallet);
            careGiverWallet -= dog.adoptionFee;
            Console.WriteLine(careGiverWallet);
            adopt = true;
            return adopt;
        }


        public string AddAdoptedAnimalName()
        {
            Console.WriteLine("Adopted Animal's Name: ");
            adoptedName = Console.ReadLine();
            return adoptedName;
        }

        public int AddAdoptedAnimalAge()
        {
            Console.WriteLine("Adopted Animal's Age: ");
            try
            {
                adoptedAge = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                AddAdoptedAnimalAge();
            }
            return adoptedAge;
        }

        public string Display()
        {
            return "CareGiver Info: " 
                   + "\n"
                   + "\nName: " + name
                   + "\nAge " + age
                   + "\nSocial Security Number: " + socialSecurityNumber
                   + "\nAddress " + address
                   + "\nPhone Number " + phoneNumber
                   + "\nAdopted Animal Name " + adoptedName
                   + "\nAdopted Animal Age " + adoptedAge
                   + "\n";
        }
        


    }
}