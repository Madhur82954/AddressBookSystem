using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<Contact> con = new List<Contact>();
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

        /*public void Display()
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
        }*/
    }
}
