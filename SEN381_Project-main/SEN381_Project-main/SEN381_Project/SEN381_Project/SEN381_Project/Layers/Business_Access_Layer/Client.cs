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
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Clients"
                                        + "WHERE Client_id = " + ClientID.ToString());
        }

        private static void View_Client_Job()
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Jobs"
                                        + "WHERE Call_id = " + "SELECT Call_id "
                                                             + "FROM Calls"
                                                             + "WHERE Client_id = " + ClientID.ToString());
        }

        private static void View_Client_History()
        {
             DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Jobs"
                                        + "WHERE Call_id = " + "SELECT Call_id "
                                                             + "FROM Calls"
                                                             + "WHERE Client_id = " + ClientID.ToString());
        }

        private static void View_Client_Contract()
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Contracts"
                                        + "WHERE Contract = " + "SELECT Call_id "
                                                             + "FROM Calls"
                                                             + "WHERE Client_id = " + ClientID.ToString());
        }

        private static void Add_client(BussID,char Gendr, string Email,string Address,int contract_id,string num)
        {
            Data_Handler.ExecuteNonQuery("INSERT INTO Clients "
                                        + "VALUES (" + Name + ',' + Surname + ',' + BussID + ',' + Gendr +',' + Email + ',' + Address + ',' + contract_id + ',' + num + ")");
        }

        private static void Delete_Client()
        {
                Data_Handler.ExecuteNonQuery("DELETE *"
                                       + "FROM Clients"
                                       + "WHERE Client_id = " + ClientID.ToString());
        }
    }
}
