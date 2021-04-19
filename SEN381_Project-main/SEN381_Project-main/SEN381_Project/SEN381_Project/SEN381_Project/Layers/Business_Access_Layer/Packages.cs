using System;
using System.Collections.Generic;
using System.Text;
using SEN381_Project.Layers.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

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

            Data_Handler handler = new Data_Handler();

            Thread t = new Thread(new ThreadStart(handler.Handle_Data));

            if (t.IsAlive == false)
            {
                t.Start();
            }


        }

        public int PackageID1 { get => PackageID; set => PackageID = value; }
        public string Package_Details1 { get => Package_Details; set => Package_Details = value; }
        public string Priority1 { get => Priority; set => Priority = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Packagelvl1 { get => Packagelvl; set => Packagelvl = value; }

        private static void Track_Performance(int ID)
        {
            ///////////////Need some work
            // Data_Handler.ExecuteSqlCmd("SELECT COUNT(Package_id)"
            //+ "FROM Packages");

            //DataTable DT = new DataTable();
            //DT = Data_Handler.ExecuteSqlCmd("SELECT 100*( COUNT(Package_id)/COUNT(Client_id) )  FROM Clients INNER JOIN Packages ON #Departments.Department_id = #Employees.Department_ID ");











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
