using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook address = new AddressBook();
            while (true)
            {
                Console.WriteLine("Enter Option \n1) Add Contact \n2) Display Contact \n3) Edit Contact \n4) Delete Contact");
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
                }
            }
        }
    }
}
