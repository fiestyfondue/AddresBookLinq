using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address book Using linq ");
            AddressBook addressBook = new AddressBook();
            int choice = 1;
            while (choice == 1)
            {
                Console.WriteLine("Enter your choice: \n1.Insert a new contact \n" + 
                "2.Display existing contact" +
                " \n3.Edit existing contact " +
                " \n4.Exit.");
                int Selectchoice = Convert.ToInt32(Console.ReadLine());
                switch (Selectchoice)
                {
                    case 1:
                        addressBook.InsertContactToTable();
                        break;
                    case 2:
                        addressBook.DisplayDetails();
                        break;
                    case 3:
                        addressBook.EditExistingContact();
                        break;
                    default:
                        Console.WriteLine("Please enter the valid number : ");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
