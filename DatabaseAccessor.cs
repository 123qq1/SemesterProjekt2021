using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;


namespace SemesterProjekt2021
{
    class DatabaseAccessor
    {

        private static SqlConnection currentConnection;
        private static string currentString;
        private static bool connected;
        private static SqlCommand currentCommand;

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

            currentCommand = new SqlCommand("",currentConnection);
            connected = succes;
            return succes;
        }

        public static bool CreateBolig(Bolig b)
        {
            bool succes = false;

            string sqlString = $"INSERT INTO Bolig VALUES({b.Id},'{b.Type}',{b.Built},{b.InArea},{b.OutArea},{b.Rooms},'{b.City}',{b.Zip},'{b.Address}','{b.EnergyLabels}',{b.OfferPrice},{b.SellingPrice},{Convert.ToInt32(b.Active)},{Convert.ToInt32(b.IsSold)},'{b.SoldDate}',{b.RealtorId},{b.SellerId},{b.BuyerId});";
            
            currentCommand.CommandText = sqlString;

            MessageBox.Show(sqlString);

            if (connected) 
            {
                currentConnection.Open();

                currentCommand.ExecuteNonQuery();

                currentConnection.Close();
            }

            return succes;
        }

        public static Bolig ReadBolig(int id)
        {
            string sqlString = $"SELECT * FROM Bolig WHERE ID = {id};";
            currentCommand.CommandText = sqlString;
            Bolig b = new Bolig();

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

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

        public static bool UpdateBolig(Bolig b)
        {
            bool succes = false;

            Bolig dBolig = ReadBolig(b.Id);

            Type type = b.GetType();
            PropertyInfo[] props = type.GetProperties();
            string strconn = "UPDATE Bolig SET ";
            int loops = 0;

            foreach(PropertyInfo p in props)
            {
                var bV = p.GetValue(b);
                var dbV = p.GetValue(dBolig);

                if (bV.ToString() == dbV.ToString())
                {
                    continue;
                }
                else
                {
                    loops++;
                    string name = p.Name;

                    string firstLetter = name[0].ToString();

                    name = firstLetter.ToLower() + name.Substring(1);

                    if (name == "realtorId") name = "ejendomsmælgerID";
                    if (name == "sellerId") name = "sælgerID";
                    if (name == "buyerId") name = "køberID";

                    if (p.GetType() == typeof(int) || p.GetType() == typeof(bool))
                        strconn += "" + name + " = " + bV + ", ";
                    else
                        strconn += "" + name + " = '" + bV + "', ";
                }
            }

            if (loops > 0)
            {
                strconn = strconn.Remove(strconn.Length - 2);

                strconn += $" WHERE ID = {b.Id};";
                MessageBox.Show(strconn);

                currentCommand.CommandText = strconn;

                if (connected)
                {
                    currentConnection.Open();

                    currentCommand.ExecuteNonQuery();
                    succes = true;

                    currentConnection.Close();

                }
            }
            return succes;
        }
    }
}
