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
            age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        public long addSocialSecurityNumber()
        {
            Console.WriteLine("Social Security Number: ");
            socialSecurityNumber = Convert.ToInt64(Console.ReadLine());
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
            phoneNumber = Convert.ToInt64(Console.ReadLine());
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
            adoptedAge = Convert.ToInt32(Console.ReadLine());
            return adoptedAge;
        }
        /*
        public CareGiver addCareGiver()
        {
            Shelter shelter = new Shelter();
            Console.WriteLine("CareGiver Information: ");
            Console.WriteLine("Name:");
            name = Console.ReadLine();

            Console.WriteLine("Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Social Security Number: ");
            socialSecurityNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Address: ");
            address = Console.ReadLine();

            Console.WriteLine("Phone Number: ");
            phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Adoption Fee Pending: ");
            adoptionFeePaid();
            if (adoptionFee)
            {
                Console.WriteLine("Adoption Fee has been paid.");
            }
            else
            {
                Console.WriteLine("Adoption Fee Still Pending... ");
            }

            Console.WriteLine("Adopted Animal's Name: ");
            adoptedName = Console.ReadLine();

            Console.WriteLine("Adopted Animal's Age: ");
            adoptedAge = Convert.ToInt32(Console.ReadLine());

            CareGiver careGiver = new CareGiver();
            careGiver.name = name;
            careGiver.age = age;
            careGiver.socialSecurityNumber = socialSecurityNumber;
            careGiver.address = address;
            careGiver.phoneNumber = phoneNumber;
            careGiver.adoptionFee = adoptionFee;
            careGiver.adoptedName = adoptedName;
            careGiver.adoptedAge = adoptedAge;

            return careGiver;

        }
        */

        public string careGiverToString()
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