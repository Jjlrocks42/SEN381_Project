using System;
using System.Collections.Generic;
using System.Text;
using SEN381_Project.Layers.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Jobs
    {
        private int JobID, CallID, EmpID;
        private string Job_Details;
        private double Duration;
        private DateTime Start_Time, End_Time;

        public Jobs(int jobID, int callID, int empID, string job_Details, double duration, DateTime start_Time, DateTime end_Time)
        {
            JobID = jobID;
            CallID = callID;
            EmpID = empID;
            Job_Details = job_Details;
            Duration = duration;
            Start_Time = start_Time;
            End_Time = end_Time;
        }

        public int JobID1 { get => JobID; set => JobID = value; }
        public int CallID1 { get => CallID; set => CallID = value; }
        public int JobID2 { get => JobID; set => JobID = value; }
        public int CallID2 { get => CallID; set => CallID = value; }
        public int EmpID1 { get => EmpID; set => EmpID = value; }
        public string Job_Details1 { get => Job_Details; set => Job_Details = value; }
        public double Duration1 { get => Duration; set => Duration = value; }
        public DateTime Start_Time1 { get => Start_Time; set => Start_Time = value; }
        public DateTime End_Time1 { get => End_Time; set => End_Time = value; }

        private static void View_Client_Job(int ClientID)
        {
             DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                           + "FROM Jobs"
                                           + "WHERE Call_id = " + "SELECT Call_id "
                                                                + "FROM Calls"
                                                                + "WHERE Client_id = " + ClientID.ToString());

        }

        private static void Assign_Emp(int callID, int empID, string job_Details, double duration, DateTime start_Time, DateTime end_Time)
        {
            Data_Handler.ExecuteNonQuery("INSERT INTO Jobs "
                                      + "VALUES (" + callID + "," + empID + ",'" + job_Details + "','" + start_Time + "','" + end_Time + "'," + duration + ")");
        }

        private static void Delete_Job(int JobID)
        {
             Data_Handler.ExecuteNonQuery("DELETE *"
                            + "FROM Jobs"
                            + "WHERE Job_id = " + JobID.ToString());
        }

        private static void Unassign_Emp(int newEmployee,int oldEmployee)
        {
            Data_Handler.ExecuteNonQuery("UPDATE Jobs SET Employee_id = " + newEmployee + " WHERE Employee_id = " + oldEmployee);
        }
    }
}
