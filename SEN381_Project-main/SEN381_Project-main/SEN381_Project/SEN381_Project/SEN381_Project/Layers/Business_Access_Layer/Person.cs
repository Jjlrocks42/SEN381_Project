using System;
using System.Collections.Generic;
using System.Text;
using SEN381_Project.Layers.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Person
    {
        private string Client_Name, Number, Email, Address, PackageCode;

        public Person(string client_Name, string number, string email, string address, string packageCode)
        {
            Client_Name = client_Name;
            Number = number;
            Email = email;
            Address = address;
            PackageCode = packageCode;
        }

        public string Client_Name1 { get => Client_Name; set => Client_Name = value; }
        public string Number1 { get => Number; set => Number = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string PackageCode1 { get => PackageCode; set => PackageCode = value; }
    }
}
