using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address book Using linq ");
            AddressBook addressBook = new AddressBook();
            addressBook.InsertContactToTable();
            Console.ReadLine();
        }
    }
}
