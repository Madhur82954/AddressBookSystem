using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    internal class Contact
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
