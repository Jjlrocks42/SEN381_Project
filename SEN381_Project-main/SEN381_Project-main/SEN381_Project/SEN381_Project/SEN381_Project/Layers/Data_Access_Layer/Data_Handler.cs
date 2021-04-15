using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace SEN381_Project.Layers.Data_Access_Layer
{
    //KRY DIE GEDEELTE WAT ONS GEDOEN HET EN PASTE DIT HIER
    class Data_Handler
    {
        // Only common generic methods exists for all derived classes.
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
            conn != null ? conn.close;
            return 1;
        }

        //make adustable according to recieved queries
        public int ExecuteSqlCommand()
        {
            Console.WriteLine("Sql Server specific Command Executed successfully");
            return 1;
        }
    }
}
