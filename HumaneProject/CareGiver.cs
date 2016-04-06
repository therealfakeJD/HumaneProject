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
        public bool adoptionFee { get; set; }
        public long phoneNumber { get; set; }
        public string adoptedName { get; set; }
        public int adoptedAge { get; set; }

        public CareGiver()
        {
            

        }

        public string addName()
        {
            Console.WriteLine("CareGiver Information: ");
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            return name;
        }

        public int addAge()
        {
            Console.WriteLine("Age: ");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please enter a number");
                addAge();
            }
            return age;
        }

        public long addSocialSecurityNumber()
        {
            Console.WriteLine("Social Security Number: ");
            try
            {
                socialSecurityNumber = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                addSocialSecurityNumber();
            }
            return socialSecurityNumber;
        }

        public string addAddress()
        {
            Console.WriteLine("Address: ");
            address = Console.ReadLine();
            return address;
        }

        public long addPhoneNumber()
        {
            Console.WriteLine("Phone Number: ");
            try
            {
                phoneNumber = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                addPhoneNumber();
            }
            return phoneNumber;
        }

        public bool getAdoptionFee()
        {
            Console.WriteLine("Adoption Fee: ");
            if (adoptionFeePaid())
            {
                Console.WriteLine("Fee Paid");
              
            }
            else if (adoptionFeePending())
            {
                Console.WriteLine("Fee Pending");
            }
            return adoptionFee;
        }

        public string addAdoptedAnimalName()
        {
            Console.WriteLine("Adopted Animal's Name: ");
            adoptedName = Console.ReadLine();
            return adoptedName;
        }

        public int addAdoptedAnimalAge()
        {
            Console.WriteLine("Adopted Animal's Age: ");
            try
            {
                adoptedAge = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry -- Please Enter a number");
                addAdoptedAnimalAge();
            }
            return adoptedAge;
        }
        public string display()
        {
            return "CareGiver Info: " 
                   + "\n"
                   + "\nName: " + name
                   + "\nAge " + age
                   + "\nSocial Security Number: " + socialSecurityNumber
                   + "\nAddress " + address
                   + "\nPhone Number " + phoneNumber
                   + "\nAdoption Fee " + adoptionFee
                   + "\nAdopted Animal Name " + adoptedName
                   + "\nAdopted Animal Age " + adoptedAge
                   + "\n";
        }
        public bool adoptionFeePaid()
        {
            adoptionFee = true;
            return adoptionFee;
        }

        public bool adoptionFeePending()
        {
            adoptionFee = false;
            return adoptionFee;
        }


    }
}