using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
