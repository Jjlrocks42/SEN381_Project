using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace SEN381_Project.Layers.Data_Access_Layer
{
    class Data_Handler
    {
        // Only common generic methods exists for all derived classes.
        interface IDataProvider
        {
           DbConnection conn = new SqlConnection("Data Source = (local); Initial Catalog=DBpremier_service_solutions;Integrated Security=SSPI");
           int OpenConnection();
           int CloseConnection();
        }

       // Implement methods specific to the respective derived classe
       interface ISqlDataProvider : IDataProvider
       {
           int ExecuteSqlCommand();
       }

    // Client 1
    // Should not force SqlDataProvider client to implement ExecuteOracleCommand, as it wont required that method to be implemented.
    // So that we will derive ISqlDataProvider not IOracleDataProvider
       class SqlDataClient : ISqlDataProvider
       {
            //Open connection
           public int OpenConnection()
           {
                try
                {
                    conn.Open();
                    Console.WriteLine("\nSql Connection opened successfully");
                }
                catch (Exception)
            {

                MessageBox.Show("Database connection unsuccessfull", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }              
                return 1;
           }
        
            //close connection
           public int CloseConnection()
           {
               conn != null? conn.close;
               return 1;
           }

            //make adustable according to recieved queries
           public int ExecuteSqlCommand()
           {
               Console.WriteLine("Sql Server specific Command Executed successfully");
               return 1;
           }
    }

   
    class InterfaceSegregationPrincipleDemo
    {
        public static void ISPDemo()
        {
            Console.WriteLine("\n\nInterface Inversion Principle Demo ");

            // Each client will implement their respective methods no base class forces the other client to implement the methods which dont required.
            // From the above implementation, we are not forcing Sql client to implemnt orcale logic or Oracle client to implement sql logic.

            ISqlDataProvider SqlDataProviderObject = new SqlDataClient();
            SqlDataProviderObject.OpenConnection();
            SqlDataProviderObject.ExecuteSqlCommand();
            SqlDataProviderObject.CloseConnection();

        }

    }
}
