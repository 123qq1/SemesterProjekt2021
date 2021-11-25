using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SemesterProjekt2021
{
    class DatabaseAccessor
    {

        private static SqlConnection currentConnection;

        public static bool ConnectToDatabase(string dbName)
        {
            bool succes = false;

            string strconn = @"Data Source=" + Environment.MachineName +";Initial Catalog=" + dbName + ";Integrated Security=True;TrustServerCertificate=True";

            //string strconn = @"Data Source=LAPTOP-1HT927JP;Initial Catalog=Semesterprojekt2021;Integrated Security=True;TrustServerCertificate=True";
                        
            currentConnection = new SqlConnection(strconn);

            try
            {
                currentConnection.Open();
                currentConnection.Close();

                succes = true;
            }
            catch (Exception)
            {
                throw;
            }
            return succes;
        }


    }
}
