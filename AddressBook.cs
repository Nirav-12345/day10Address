using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUC1
{
    public class AddressBook
    {
        private string FirstName1;

        public string LastName1;

        public string PhoneNumber1;

        public string Addresses1;

        public double contact1;

        public AddressBook( string FirstName1,string LastName1,string PhoneNumber1,string Addresses1,double contact1)
        {
            this.FirstName1 = FirstName1;
            this.LastName1 = LastName1;
            this.PhoneNumber1 = PhoneNumber1;
            this.contact1 = contact1;

        }






        public void AddressBook1(string FirstName1, string LastName1, string PhoneNumber1, string Addresses1, double contact1)
        {
            this.FirstName1 = FirstName1;
            this.LastName1 = LastName1;
            this.PhoneNumber1 = PhoneNumber1;
            this.contact1 = contact1;

        }





        public void display()
        {

            Random random = new Random();
            int num = random.Next(2);
            switch (num)
            {
                case 0:
                    Console.WriteLine("Here you can add a entry to your address book.");
                    Console.Write("Name: ");
                    string FirstName1 = Console.ReadLine();
                    Console.Write("Phone number: ");
                    string Phonenumber1 = Console.ReadLine();

                    break;

                case 1:

                    Console.WriteLine("Remove");
                    break;
                default:
                    Console.WriteLine("The choice you made isn't valid, please try again.");
                    break;

            }
        }

    }
}
