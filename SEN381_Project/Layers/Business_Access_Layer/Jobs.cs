using System;
using System.Collections.Generic;
using System.Text;

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

        private static void View_Client_Job()
        {

        }

        private static void Assign_Emp()
        {

        }

        private static void Delete_Job()
        {

        }

        private static void Remove_Emp()
        {

        }
    }
}
