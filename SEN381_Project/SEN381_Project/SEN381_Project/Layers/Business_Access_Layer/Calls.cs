using System;
using System.Collections.Generic;
using System.Text;

namespace SEN381_Project.Layers.Business_Access_Layer
{
    class Calls
    {
        private int CallID, ClientID, EmpID;
        private string Client_Name, Call_Type, Employee_Name;
        private DateTime Start_Time, End_time;
        private double Duration;

        public Calls(int callID, int clientID, int empID, string client_Name, string call_Type, string employee_Name, DateTime start_Time, DateTime end_time, Double duration)
        {
            CallID = callID;
            ClientID = clientID;
            EmpID = empID;
            Client_Name = client_Name;
            Call_Type = call_Type;
            Employee_Name = employee_Name;
            Start_Time = start_Time;
            End_time1 = end_time;
            Duration = duration;
        }

        public DateTime Start_Time1 { get => Start_Time; set => Start_Time = value; }
        public DateTime End_time1 { get => End_time; set => End_time = value; }
        public double Duration1 { get => Duration; set => Duration = value; }
        public string Client_Name1 { get => Client_Name; set => Client_Name = value; }
        public string Call_Type1 { get => Call_Type; set => Call_Type = value; }
        public string Employee_Name1 { get => Employee_Name; set => Employee_Name = value; }
        public int CallID1 { get => CallID; set => CallID = value; }
        public int ClientID1 { get => ClientID; set => ClientID = value; }
        public int EmpID1 { get => EmpID; set => EmpID = value; }

        private static void View_Logs()
        {

        }

        private static void View_Jobs()
        {

        }

        private static void Delete_Call()
        {

        }
    }
}
