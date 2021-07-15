using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLinq
{
    class AddressBook
    {
        DataTable dataTable = new DataTable();
        public AddressBook()
        {
            // Here store Type as a field
            //column Represents all table columns
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
        }
        public void InsertContactToTable()
        {
            Console.Write("\nEnter the first name of the contact : ");
            string firstName = Console.ReadLine();
            Console.Write("\nEnter the last name of the contact : ");
            string lastName = Console.ReadLine();
            Console.Write("\nEnter the address of the contact : ");
            string address = Console.ReadLine();
            Console.Write("\nEnter the city of the contact : ");
            string city = Console.ReadLine();
            Console.Write("\nEnter the state of the contact : ");
            string state = Console.ReadLine();
            Console.Write("\nEnter the zip code of the contact : ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the phone number of the contact : ");
            long phone = Convert.ToInt64(Console.ReadLine());
            Console.Write("\nEnter the email id of the contact : ");
            string email = Console.ReadLine();

            dataTable.Rows.Add(firstName, lastName, address, city, state, zip, phone, email);

            Console.WriteLine("Contact details added successfully!");
        }
    }
}
