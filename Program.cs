using System;

namespace AddressBookUC1
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddressBook n = new AddressBook("nirav", "raj", "7585853052", "ffff", 2);
            n.AddressBook1("nirav", "raj", "7585853052", "ffff", 2);

            n.display();
        }
    }
}