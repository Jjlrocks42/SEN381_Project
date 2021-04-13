using System;
using System.Collections.Generic;
using System.Text;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Services
    {
        private int ServiceID, PackageID;
        private string Service_Details, Status;

        public Services(int serviceID, int packageID, string service_Details, string status)
        {
            ServiceID = serviceID;
            PackageID = packageID;
            Service_Details = service_Details;
            Status = status;
        }

        public string Service_Details1 { get => Service_Details; set => Service_Details = value; }
        public string Status1 { get => Status; set => Status = value; }
        public string Service_Details2 { get => Service_Details; set => Service_Details = value; }
        public string Status2 { get => Status; set => Status = value; }
        public int PackageID1 { get => PackageID; set => PackageID = value; }
        public int ServiceID1 { get => ServiceID; set => ServiceID = value; }

        private static void Track_Performance()
        {

        }

        private static void Remove_Service()
        {

        }

        private static void Get_Service()
        {

        }
    }
}
