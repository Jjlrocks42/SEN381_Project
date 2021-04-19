using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace SEN381_Project.Layers.Data_Access_Layer
{
    //NOTE
    class Data_Handler
    {
        static SqlConnection conn = new SqlConnection("Data Source = (local); Initial Catalog=DBpremier_service_solutions;Integrated Security=SSPI");
        public static void OpenConnection()
        {
            try
            {
                conn.Open();
                Console.WriteLine("\nSql Connection opened successfully");
            }
            catch (Exception)
            {

            }
        }

        //close connection
        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                Console.WriteLine("\nConnection close");
            }
        }

        //Initializing Thread
        public void Handle_Data() 
        {
            
        }




        //make adustable according to recieved queries
        public static DataTable ExecuteSqlCmd(string command)
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(command,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Console.WriteLine("\nData Retrieved");
            CloseConnection();
            return dt;
        }

        public static void ExecuteNonQuery(string command)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("\nDatabase Edited");
                CloseConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("Edit failed: " + e);
            }
        }
    }
}
