using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of Address Book you want : ");
            int numBook = Convert.ToInt32(Console.ReadLine());
            int numberBook = 0;
            Console.WriteLine("Enter name of address book");
            string book = Console.ReadLine();
            while (numberBook < numBook)
            {
                AddressBook address = new AddressBook();
                while (true)
                {
                    Console.WriteLine("Enter Option \n1) Add Contact \n2) Display Contact \n3) Edit Contact \n4) Delete Contact\n5) Search City\n6) Search State\n7) View By City or State Name\n8) Count By City or State Name\n9) Sort By Name");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            address.AddContact();
                            break;
                        case 2:
                            address.Display();
                            break;
                        case 3:
                            address.EditContact();
                            break;
                        case 4:
                            address.DeleteContact();
                            break;
                        case 5:
                            AddressBook.SearchCity();
                            break;
                        case 6:
                            AddressBook.SearchState();
                            break;
                        case 7:
                            address.ViewByCityOrStateName();
                            break;
                        case 8:
                            address.CountByCityOrStateName();
                            break;
                        case 9:
                            address.SortByName(AddressBook.con);
                            break;
                    }
                }
            }
            AddressBook.AddTo(book);
            numberBook++;
        }
    }
}
