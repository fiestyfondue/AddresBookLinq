using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        /// UC3 Method to insert data into the address book contact table
        /// </summary>
        public void InsertContactIntoTable()
        {
            ////Declaring Rows:
            dataTable.Rows.Add("Harsh", "Sinha", "Hyderabad", "HTown", "AP", 75766, "8676438585", "harsh.23@gmail.com");
            dataTable.Rows.Add("Prakriti", "Nayar", "Delhi", "A zone", "Capitol", 15346, "85543585", "prakriti@gmail.com");
            dataTable.Rows.Add("Tanmay", "Bhatt", "Mumbai", "NewTown", "MH", 73496, "584948585", "tanmay@gmail.com");
            dataTable.Rows.Add("ekta", "kapoor", "mumbai", "Mira Road", "MH", 178896, "856756585", "ekta@gmail.com");
            Console.WriteLine("Contact details added successfully!\n Select 2 for view contact\n");



        }
        //Display Details
        public void DisplayDetails()
        {
            // IEnumerable in C# is an interface that defines one method, 
            //AsEnumerable, which is an extension method for DataTable,
            //AsEnumerable method will return multiple, independent
            
            foreach (var table in dataTable.AsEnumerable())
            {
                // Get all field by column index.
                Console.WriteLine("\nFirstName:-" + table.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + table.Field<string>("LastName"));
                Console.WriteLine("Address:-" + table.Field<string>("Address"));
                Console.WriteLine("City:-" + table.Field<string>("City"));
                Console.WriteLine("State:-" + table.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + table.Field<string>("Zip"));
                Console.WriteLine("PhoneNumber:-" + table.Field<string>("PhoneNumber"));
                Console.WriteLine("Email:-" + table.Field<string>("Email"));
            }
        }
        /// <summary>
        /// Edit Existing Contact
        /// </summary>
        public void EditExistingContact()
        {
            try
            {
                ////ContactName that has to be edited
                string editName = "prakriti";
                //Selecting using Lambda Function
                //Table.asenumarable means takes all the data from table as list
              //Firstordefault means gets the first elements in the table when we search
                var updateData = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(editName)).FirstOrDefault();
                if (updateData != null)
                {
                    ////Update Phone Number and City
                    updateData.SetField("PhoneNumber", "982727328");
                    updateData.SetField("City", "Vancover");
                    Console.WriteLine("\n PhoneNumber and city of {0} updated successfully!", editName);
                    DisplayDetails();
                }
                else
                {
                    Console.WriteLine("No such record in the Address Book!");
                }
            }
            //exception
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
