using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace SemesterProjekt2021
{
    class DatabaseAccessor
    {

        private static SqlConnection currentConnection;
        private static string currentString;
        private static bool connected;
        private static SqlCommand CurrentCommand;

        public static bool ConnectToDatabase(string dbName)
        {
            bool succes = false;

            string strconn = @"Data Source=" + Environment.MachineName +";Initial Catalog=" + dbName + ";Integrated Security=True;TrustServerCertificate=True";

            //string strconn = @"Data Source=LAPTOP-1HT927JP;Initial Catalog=Semesterprojekt2021;Integrated Security=True;TrustServerCertificate=True";
                        
            currentConnection = new SqlConnection(strconn);
            currentString = strconn;
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

            CurrentCommand = new SqlCommand("",currentConnection);
            connected = succes;
            return succes;
        }

        public static bool CreateBolig(Bolig b)
        {
            bool succes = false;

            

            string sqlString = $"INSERT INTO Bolig VALUES({b.Id},'{b.Type}',{b.Built},{b.InArea},{b.OutArea},{b.Rooms},'{b.City}',{b.Zip},'{b.Address}','{b.EnergyLable}',{b.OfferPrice},{b.SellingPrice},{Convert.ToInt32(b.Active)},{Convert.ToInt32(b.IsSold)},'{b.SoldDate}',{b.RealtorId},{b.SellerId},{b.BuyerId});";
            
            CurrentCommand.CommandText = sqlString;

            MessageBox.Show(sqlString);

            if (connected) 
            {
                currentConnection.Open();

                CurrentCommand.ExecuteNonQuery();

                currentConnection.Close();
            }

            return succes;
        }

        public static Bolig ReadBolig(int id)
        {

            string sqlString = $"SELECT * FROM Bolig WHERE ID = {id};";
            CurrentCommand.CommandText = sqlString;
            Bolig b = new Bolig();

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = CurrentCommand.ExecuteReader();

                while (reader.Read())
                {
                    int boligId = reader.GetInt32(0);
                    string type = reader.GetString(1);
                    int built = reader.GetInt32(2);
                    int inArea = reader.GetInt32(3);
                    int outArea = reader.GetInt32(4);
                    int rooms = reader.GetInt32(5);
                    string city = reader.GetString(6);
                    int zip = reader.GetInt32(7);
                    string address = reader.GetString(8);
                    string energyLable = reader.GetString(9);
                    int offerPrice = reader.GetInt32(10);
                    int sellingPrice = reader.GetInt32(11);
                    bool active = reader.GetBoolean(12);
                    bool isSold = reader.GetBoolean(13);
                    string soldDate = reader.GetString(14);
                    int realtorId = reader.GetInt32(15);
                    int sellerId = reader.GetInt32(16);
                    int buyerId = reader.GetInt32(17);

                    b = new Bolig(boligId, realtorId, sellerId, buyerId, type, address, city, zip, rooms, inArea, outArea, built, active, isSold, soldDate, energyLable, offerPrice, sellingPrice);
                }

                reader.Close();
                currentConnection.Close();

            }

            return b;
        }

    }
}
