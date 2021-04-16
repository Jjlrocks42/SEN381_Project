using System;
using System.Collections.Generic;
using System.Text;
using SEN381_Project.Layers.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Packages
    {
        private int PackageID;
        private string Package_Details, Priority, Status, Packagelvl;

        public Packages(string package_Details, string priority, string status, string packagelvl)
        {
            Package_Details = package_Details;
            Priority = priority;
            Status = status;
            Packagelvl = packagelvl;
        }

        public int PackageID1 { get => PackageID; set => PackageID = value; }
        public string Package_Details1 { get => Package_Details; set => Package_Details = value; }
        public string Priority1 { get => Priority; set => Priority = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Packagelvl1 { get => Packagelvl; set => Packagelvl = value; }

        private static void Track_Performance(int ID)
        {
           ///////////////Need some work
        }

        private static void Remove_Packaged(int ID)
        {
            Data_Handler.ExecuteSqlCmd("DELETE "
                                        + "FROM Packages"
                                        + "WHERE Package_id = " + ID.ToString());
        }

        private static void Get_Services(int ID)
        {
            Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Packages"
                                        + "WHERE Package_id = " + ID.ToString());
        }
    }
}
