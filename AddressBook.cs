using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using CsvHelper;

namespace AddressBookSystem
{
    class AddressBook
    {
        public static Dictionary<string, List<Contact>> addressbooks = new Dictionary<string, List<Contact>>();
        public static List<Contact> con = new List<Contact>();

        public static Dictionary<string, List<Contact>> cityBook = new Dictionary<string, List<Contact>>();
        public static Dictionary<string, List<Contact>> stateBook = new Dictionary<string, List<Contact>>();
        public static void AddTo(string name)
        {
            addressbooks.Add(name, con);
        }
        public void AddContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter FirstName : ");
            contact.Firstname = Console.ReadLine();
            Console.WriteLine("Enter LastName : ");
            contact.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Address : ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City : ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip : ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber : ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter E-mail : ");
            contact.Email = Console.ReadLine();

            con.Add(contact);
        }

        public void Display()
        {
            foreach (Contact contact in con)
            {
                Console.WriteLine("FirstName - " + contact.Firstname);
                Console.WriteLine("LastName - " + contact.Lastname);
                Console.WriteLine("Address - " + contact.Address);
                Console.WriteLine("City - " + contact.City);
                Console.WriteLine("State - " + contact.State);
                Console.WriteLine("Zip - " + contact.Zip);
                Console.WriteLine("PhoneNumber - " + contact.PhoneNumber);
                Console.WriteLine("E-mail - " + contact.Email);
            }
        }

        public void EditContact()
        {
            Console.WriteLine("To Edit Contact Enter FirstName : ");
            string name = Console.ReadLine();

            foreach (var data in con)
            {
                if (con.Contains(data))
                {
                    if (data.Firstname == name)
                    {
                        Console.WriteLine("Name Exists");
                        Console.WriteLine("To Edit Contact\n1)LastName\n2)Address\n3)City\n4)State\n5)Zip\n6)PhoneNumber\n7)Email");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter New LastName");
                                string lastname = Console.ReadLine();
                                data.Lastname = lastname;
                                break;
                            case 2:
                                Console.WriteLine("Enter New Address");
                                string address = Console.ReadLine();
                                data.Address = address;
                                break;
                            case 3:
                                Console.WriteLine("Enter New City");
                                string city = Console.ReadLine();
                                data.City = city;
                                break;
                            case 4:
                                Console.WriteLine("Enter New State");
                                string state = Console.ReadLine();
                                data.State = state;
                                break;
                            case 5:
                                Console.WriteLine("Enter New Zip");
                                int zip = Convert.ToInt32(Console.ReadLine());
                                data.Zip = zip;
                                break;
                            case 6:
                                Console.WriteLine("Enter New PhoneNumber");
                                long phonenumber = Convert.ToInt64(Console.ReadLine());
                                data.PhoneNumber = phonenumber;
                                break;
                            case 7:
                                Console.WriteLine("Enter new Email");
                                string email = Console.ReadLine();
                                data.Email = email;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name Does Not Exist");
                    }
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("To Edit Contact Enter FirstName : ");
            string name = Console.ReadLine();
            foreach (var details in con)
            {
                if (name == details.Firstname)
                {
                    con.Remove(details);
                    Console.WriteLine("Contact is Deleted");
                    break;
                }
                else
                {
                    Console.WriteLine("Contact is Not Present");
                }
            }
        }
        public static int SearchDuplicate(List<Contact> contacts, Contact contactBook)
        {

            foreach (var Details in contacts)
            {
                var person = contacts.Find(p => p.Firstname.Equals(contactBook.Firstname));
                if (person != null)
                {
                    Console.WriteLine("Already this contact exist with same first name : " + person.Firstname);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
        public static void SearchCity()
        {
            Console.WriteLine("Enter Name of City");
            string city = Console.ReadLine();
            foreach (var details in con)
            {
                var person = con.Find(e => e.City.Equals(city));
                if (person != null)
                {
                    Console.WriteLine("{0} is in the city {1}", details.Firstname, city);
                }
                else
                {

                }
            }
        }
        public static void SearchState()
        {
            Console.WriteLine("Enter Name of State");
            string state = Console.ReadLine();
            foreach (var details in con)
            {
                var person = con.Find(e => e.State.Equals(state));
                if (person != null)
                {
                    Console.WriteLine("{0} is in the city {1}", details.Firstname, state);
                }
                else
                {

                }
            }
        }
        public void AddByCity()
        {
            foreach (var details in con)
            {
                string city = details.City;
                if (cityBook.ContainsKey(city))
                {
                    List<Contact> exist = cityBook[city];
                    exist.Add(details);
                }
                else
                {
                    List<Contact> cityContact = new List<Contact>();
                    cityContact.Add(details);
                    cityBook.Add(city, cityContact);
                }
            }
        }
        public void AddByState()
        {
            foreach (var details in con)
            {
                string state = details.State;
                if (stateBook.ContainsKey(state))
                {
                    List<Contact> exist = stateBook[state];
                    exist.Add(details);
                }
                else
                {
                    List<Contact> stateContact = new List<Contact>();
                    stateContact.Add(details);
                    cityBook.Add(state, stateContact);
                }
            }
        }
        public void ViewByCityOrStateName()
        {
            Console.WriteLine("Please select your option: \n1)  To view all contacts by city, \n2) To view all contacts by state.");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                int cityCount = cityBook.Count();
                if (cityCount != 0)
                {
                    foreach (KeyValuePair<string, List<Contact>> item in cityBook)
                    {
                        Console.WriteLine("\n Following are the Person details residing in the city -" + item.Key);
                        foreach (var items in item.Value)
                        {

                            Console.WriteLine("First Name : " + items.Firstname);
                            Console.WriteLine("Last Name : " + items.Lastname);
                            Console.WriteLine("Address : " + items.Address);
                            Console.WriteLine("Phone Number : " + items.PhoneNumber);
                            Console.WriteLine("Email ID : " + items.Email);
                            Console.WriteLine("City : " + items.City);
                            Console.WriteLine("State : " + items.State);
                            Console.WriteLine("ZIP code : " + items.Zip);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("\nCurrently no entries are inserted.");
                }
            }
            else if (choice == 2)
            {

                int stateCount = stateBook.Count();
                if (stateCount != 0)
                {
                    foreach (KeyValuePair<string, List<Contact>> item in stateBook)
                    {
                        Console.WriteLine("\n Following are the Person details residing in the state -" + item.Key);
                        foreach (var items in item.Value)
                        {
                            Console.WriteLine("First Name : " + items.Firstname);
                            Console.WriteLine("Last Name : " + items.Lastname);
                            Console.WriteLine("Address : " + items.Address);
                            Console.WriteLine("Phone Number : " + items.PhoneNumber);
                            Console.WriteLine("Email ID : " + items.Email);
                            Console.WriteLine("City : " + items.City);
                            Console.WriteLine("State : " + items.State);
                            Console.WriteLine("ZIP code : " + items.Zip);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("\nCurrently no entries are inserted.");
                }

            }
            else
            {
                Console.WriteLine("\nWrong entry, Please choose between 1 and 2");
            }
        }
        public void CountByCityOrStateName()
        {
            Console.WriteLine("Select \n1) count person by city\n2) Count person by state");
            int num = Convert.ToInt32(Console.ReadLine());
            void CountByCity()
            {
                foreach (var item in cityBook)
                {
                    int count = item.Value.Count();
                    Console.WriteLine("There are {0} number of people in City- {1}", count, item.Key);
                }
            }
            void CountBystate()
            {
                foreach (var item in stateBook)
                {
                    int count = item.Value.Count();
                    Console.WriteLine("There are {0} number of people in City- {1}", count, item.Key);
                }
            }

            if (num == 1)
            {
                if (cityBook.Count != 0)
                {
                    CountByCity();
                }
                else
                {
                    Console.WriteLine("Currently no entries stored");
                }
            }
            else if (num == 2)
            {
                if (stateBook.Count != 0)
                {
                    CountBystate();
                }
                else
                {
                    Console.WriteLine("Currently no entries stored");
                }
            }
            else
            {
                Console.WriteLine("Invalid selection, please select between 1 and 2");
            }
        }
        public void SortByName(List<Contact> contacts)
        {
            con = contacts.OrderBy(e => e.Firstname).ToList();
        }
        public void SortByChoice(List<Contact> contacts)
        {
            Console.WriteLine("Select the option to sort the contct list : \n1 : City Name \n2 : State Name \n3. Zip Code");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                con = contacts.OrderBy(p => p.City).ToList();
            }
            if (num == 2)
            {
                con = contacts.OrderBy(p => p.State).ToList();
            }
            if (num == 3)
            {
                con = contacts.OrderBy(p => p.Zip).ToList();
            }
            else
            {
                Console.WriteLine("Invalid Selection,please select between 1 to 3 ");
            }
        }
    }
}
