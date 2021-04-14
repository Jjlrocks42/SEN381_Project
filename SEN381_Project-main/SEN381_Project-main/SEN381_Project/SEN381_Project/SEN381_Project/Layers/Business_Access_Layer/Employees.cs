﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Employees
    {
        private int EmpID;
        private string Name, Number, Email, Address, JobType;

        public Employees(int empID, string name, string number, string email, string address, string jobType)
        {
            EmpID = empID;
            Name = name;
            Number = number;
            Email = email;
            Address = address;
            JobType = jobType;
        }

        public int EmpID1 { get => EmpID; set => EmpID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Number1 { get => Number; set => Number = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string JobType1 { get => JobType; set => JobType = value; }

        private static void View_Client_Job(int ID)
        {
            Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Jobs"
                                        + "WHERE Employee_id = " + ID.ToString());
        }

        private static void View_Client_History(int ID)
        {
            Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Calls"
                                        + "WHERE Emloyee_id = " + ID.ToString());
        }

        private static void View_Client_SLA(int ID)
        {
            
        }

        private static void View_Client_Package(int ID)
        {
            Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Packages"
                                        + "WHERE Employee_ID = " + ID.ToString());
        }

        private static void Add_client(string name, string email, string phone, string adrees, string job)
        {
            Data_Handler.ExecuteSqlCmd("INSERT INTO *"
                                        + "VALUE("+name+email+phone+adrees+job+")");
        }

        private static void Delete_Client(int ID)
        {
            Data_Handler.ExecuteSqlCmd("DELETE"
                                        + "FROM Employees"
                                        + "WHERE Employee_id = " + ID.ToString());
        }
    }
}
