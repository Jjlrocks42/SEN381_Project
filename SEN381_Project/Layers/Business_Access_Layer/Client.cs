using System;
using System.Collections.Generic;
using System.Text;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Client
    {
        private int ClientID, BusinessID, ContractID;
        private string Client_Name, Number, Email, Address;

        public Client(int clientID, int businessID, int contractID, string client_Name, string number, string email, string address)
        {
            ClientID = clientID;
            BusinessID = businessID;
            ContractID = contractID;
            Client_Name = client_Name;
            Number = number;
            Email = email;
            Address = address;
        }

        public int ClientID1 { get => ClientID; set => ClientID = value; }
        public int BusinessID1 { get => BusinessID; set => BusinessID = value; }
        public int ContractID1 { get => ContractID; set => ContractID = value; }
        public string Client_Name1 { get => Client_Name; set => Client_Name = value; }
        public string Number1 { get => Number; set => Number = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Address1 { get => Address; set => Address = value; }

        private static void View_Client_Details()
        {

        }

        private static void View_Client_Job()
        {

        }

        private static void View_Client_History()
        {

        }

        private static void View_Client_Contract()
        {

        }

        private static void Add_client()
        {

        }

        private static void Delete_Client()
        {

        }
    }
}
