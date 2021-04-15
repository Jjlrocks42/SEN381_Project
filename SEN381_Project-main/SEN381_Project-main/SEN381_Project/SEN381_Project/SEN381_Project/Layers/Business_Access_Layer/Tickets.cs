using System;
using System.Collections.Generic;
using System.Text;
using SEN381_Project.Layers.Data_Access_Layer;
using System.Data;
using System.Data.SqlClient;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Tickets
    {
        private int CallID, JobID;
        private string Feedback;
        private DateTime Start_Time, End_Time, Duration;

        public Tickets(int callID, int jobID, string feedback, DateTime start_Time, DateTime end_Time, DateTime duration)
        {
            CallID = callID;
            JobID = jobID;
            Feedback = feedback;
            Start_Time = start_Time;
            End_Time = end_Time;
            Duration = duration;
        }

        public int CallID1 { get => CallID; set => CallID = value; }
        public int JobID1 { get => JobID; set => JobID = value; }
        public DateTime Start_Time1 { get => Start_Time; set => Start_Time = value; }
        public DateTime End_Time1 { get => End_Time; set => End_Time = value; }
        public DateTime Duration1 { get => Duration; set => Duration = value; }
        public string Feedback1 { get => Feedback; set => Feedback = value; }

        private static void View_Client_job(int JobID)
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Tickets"
                                        + "WHERE JobID1 = " + JobID.ToString());
        }

        private static void Assign_Emp(int JobID)
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("SELECT *"
                                        + "FROM Tickets"
                                        + "WHERE JobID1 = " + JobID.ToString());
        }

        private static void Delete_Record(int CallID)
        {
            DataTable DT = new DataTable();
            DT = Data_Handler.ExecuteSqlCmd("DELETE *"
                                        + "FROM Tickets"
                                        + "WHERE CallID1 = " + CallID.ToString());
        }
    }
}
