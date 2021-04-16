using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using SEN381_Project.Layers.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Business
    {
        private int BusinessID;
        private string Name, Email, Address, PhoneNumber;

        public Business(int businessID, string name, string email, string address, string phoneNumber)
        {
            BusinessID = businessID;
            Name = name;
            Email1 = email;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public int BusinessID1 { get => BusinessID; set => BusinessID = value; }

        private static void Add_Business(string name, string email, string address, string phoneNumber)
        {
            Data_Handler.ExecuteNonQuery("INSERT INTO Business "
                                       + "VALUES ('" + name + "','" + phoneNumber + "','" + email + "','" + address + "')");
        }

        private static void Delete_Business(int BusID)
        {
            Data_Handler.ExecuteNonQuery("DELETE *"
                                   + "FROM Business"
                                   + "WHERE Business_id = " + BusID.ToString());
        }

        private static void View_Businesses(int BusID)
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Business"
                                        + "WHERE Business_id = " + BusID.ToString() + ")");
        }
    }
}
