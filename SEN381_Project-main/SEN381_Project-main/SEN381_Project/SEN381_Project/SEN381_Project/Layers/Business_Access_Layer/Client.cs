using System;
using System.Collections.Generic;
using System.Text;
using SEN381_Project.Layers.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Client
    {
        private int ClientID, BusinessID, ContractID;
        private string ClientFName,ClientLName, Gender, PhoneNumber, Email, Address;

        public int ClientID1 { get => ClientID; set => ClientID = value; }
        public int BusinessID1 { get => BusinessID; set => BusinessID = value; }
        public int ContractID1 { get => ContractID; set => ContractID = value; }
        public string ClientFName1 { get => ClientFName; set => ClientFName = value; }
        public string ClientLName1 { get => ClientLName; set => ClientLName = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Address1 { get => Address; set => Address = value; }

        public Client(int clientID, int businessID, int contractID, string clientFName, string clientLName, string gender, string phoneNumber, string email, string address)
        {
            ClientID1 = clientID;
            BusinessID1 = businessID;
            ContractID1 = contractID;
            ClientFName1 = clientFName;
            ClientLName1 = clientLName;
            Gender1 = gender;
            PhoneNumber1 = phoneNumber;
            Email1 = email;
            Address1 = address;

            Data_Handler handler = new Data_Handler();

            Thread t = new Thread(new ThreadStart(handler.Handle_Data));

            if (t.IsAlive == false)
            {
                t.Start();
            }


        }

        private static void View_Client_Business(int ClientID)
        {
           

            DataTable DT = new DataTable();

            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Business"
                                        + "WHERE Business_id IN (SELECT Business_id FROM Clients WHERE Client_id = " + ClientID.ToString() + ")");
        }

        private static void View_Client_Details(int ClientID)
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Clients"
                                        + "WHERE Client_id = " + ClientID.ToString());
        }

        private static void View_Client_Job(int ClientID)
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Jobs"
                                        + "WHERE Call_id = " + "SELECT Call_id "
                                                             + "FROM Calls"
                                                             + "WHERE Client_id = " + ClientID.ToString());
        }

        private static void View_Client_History(int ClientID)
        {
             DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Calls"
                                        + "WHERE Call_id = " + "SELECT Call_id "
                                                             + "FROM Calls"
                                                             + "WHERE Client_id = " + ClientID.ToString());
        }

        private static void View_Client_Contract(int ClientID)
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Contracts"
                                        + "WHERE Contract_id = " + "SELECT Contract_id "
                                                             + "FROM Clients"
                                                             + "WHERE Contract_id = " + ClientID.ToString());
        }

        private static void Add_Client(int businessID, int contractID, string clientFName, string clientLName, string gender, string phoneNumber, string email, string address)
        {
            Data_Handler.ExecuteNonQuery("INSERT INTO Clients "
                                       + "VALUES (" + clientFName + "," + clientLName + ",'" + phoneNumber + "','" + businessID + "','" + gender + "', '" + email + "','" + address + "'," + contractID + ")");
        }

        private static void Delete_Client(int ClientID)
        {
                Data_Handler.ExecuteNonQuery("DELETE *"
                                       + "FROM Clients"
                                       + "WHERE Client_id = " + ClientID.ToString());
        }
    }
}
