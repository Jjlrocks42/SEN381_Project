using System;
using System.Collections.Generic;
using System.Text;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Contracts
    {
        private int ContractID, PackageID;
        private string ContractDetails, Priority, Status, Packagelvl;
        private DateTime Start_Date, End_Date;

        public Contracts(int contractID, int packageID, string contractDetails, string priority, string status, string packagelvl, DateTime start_Date, DateTime end_Date)
        {
            ContractID = contractID;
            PackageID = packageID;
            ContractDetails = contractDetails;
            Priority = priority;
            Status = status;
            Packagelvl = packagelvl;
            Start_Date = start_Date;
            End_Date = end_Date;
        }

        public int ContractID1 { get => ContractID; set => ContractID = value; }
        public int PackageID1 { get => PackageID; set => PackageID = value; }
        public string ContractDetails1 { get => ContractDetails; set => ContractDetails = value; }
        public string Priority1 { get => Priority; set => Priority = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Packagelvl1 { get => Packagelvl; set => Packagelvl = value; }
        public DateTime Start_Date1 { get => Start_Date; set => Start_Date = value; }
        public DateTime End_Date1 { get => End_Date; set => End_Date = value; }

        private static void Show_Contract()
        {

        }
        private static void Track_Performance()
        {

        }
        private static void End_Contract()
        {

        }
        private static void Get_Package()
        {

        }
    }
}
