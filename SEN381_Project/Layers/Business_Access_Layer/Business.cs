using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Business
    {
        private int BusinessID;
        private string Name, Email, Address, Number;

        public Business(int businessID, string name, string email, string address, string number)
        {
            BusinessID = businessID;
            Name = name;
            Email1 = email;
            Address = address;
            Number = number;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Number1 { get => Number; set => Number = value; }
        public int BusinessID1 { get => BusinessID; set => BusinessID = value; }
    }
}
