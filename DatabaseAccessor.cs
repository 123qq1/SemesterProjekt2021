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

            string sqlString = $"INSERT INTO Bolig VALUES({b.Id},'{b.Type}',{b.Built},{b.InArea},{b.OutArea},{b.Rooms},'{b.City}',{b.Zip},'{b.Address}','{b.EnergyLabels}',{b.OfferPrice},{b.SellingPrice},'{b.Active}','{b.IsSold}','{b.SoldDate}',{b.RealtorId},{b.SellerId},{b.BuyerId});";
            
            currentCommand.CommandText = sqlString;

            MessageBox.Show(sqlString);

            if (connected) 
            {
                currentConnection.Open();

                succes = true;
                currentCommand.ExecuteNonQuery();

                currentConnection.Close();
                
            }

            return succes;
        }

        public static bool ReadBolig(int id, ref Bolig b)
        {
            bool succes = false;
            string sqlString = $"SELECT * FROM Bolig WHERE ID = {id};";
            currentCommand.CommandText = sqlString;

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                object[] objs = new object[reader.FieldCount];

                reader.Read();
                reader.GetValues(objs);

                Type type = b.GetType();
                PropertyInfo[] props = type.GetProperties();
                int i = 0;
                foreach (PropertyInfo p in props)
                {

                    p.SetValue(b,objs[i]);
                    i++;
                }

                succes = true;

                reader.Close();
                currentConnection.Close();
            }
            return succes;
        }

        public static bool UpdateBolig(Bolig b)
        {
            bool succes = false;

            Bolig dBolig = new Bolig();
            ReadBolig(b.Id, ref dBolig);

            Type type = b.GetType();
            PropertyInfo[] props = type.GetProperties();
            string strconn = "UPDATE Bolig SET ";
            bool looped = false;

            foreach(PropertyInfo p in props)
            {
                var bV = p.GetValue(b);
                var dbV = p.GetValue(dBolig);

                if (bV.ToString() != dbV.ToString())
                {
                    looped = true;
                    string name = p.Name;

                    string firstLetter = name[0].ToString();

                    name = firstLetter.ToLower() + name.Substring(1);

                    if (name == "realtorId") name = "ejendomsmælgerID";
                    if (name == "sellerId") name = "sælgerID";
                    if (name == "buyerId") name = "køberID";

                    if (p.GetType() == typeof(int) || p.GetType() == typeof(bool))
                        strconn += "" + name + " = " + bV + ", ";
                    else
                        strconn += name + " = '" + bV + "', ";
                }
            }

            if (looped)
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

        public static bool ArchiveBolig(int id)
        {
            bool succes = false;

            Bolig b = new Bolig();
            succes = ReadBolig(id,ref b);

            if (succes)
            {
                b.Active = false;

                succes = UpdateBolig(b);
            }

            return succes;
        }

        public static bool CreatePerson(Person p)
        {
            bool succes = false;

            string sqlString = $"INSERT INTO Person VALUES({p.ID},'{p.CPR}',{p.City},{p.Zip},{p.Address},{p.Email},'{p.PhoneNr}',{p.FName},'{p.LName}','{p.IsEjendomsmælger}',{p.IsKøber},{p.IsSælger});";

            currentCommand.CommandText = sqlString;

            MessageBox.Show(sqlString);

            if (connected)
            {
                currentConnection.Open();

                currentCommand.ExecuteNonQuery();

                succes = true;
                currentConnection.Close();
            }

            return succes;
        }

        public static bool ReadPerson(int id, ref Person p)
        {
            bool succes = false;
            string sqlString = $"SELECT * FROM Bolig WHERE ID = {id};";
            currentCommand.CommandText = sqlString;

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                object[] objs = new object[reader.FieldCount];

                reader.Read();
                reader.GetValues(objs);

                Type type = p.GetType();
                PropertyInfo[] props = type.GetProperties();
                int i = 0;
                foreach (PropertyInfo prop in props)
                {

                    prop.SetValue(p, objs[i]);
                    i++;
                }
                succes = true;
                reader.Close();
                currentConnection.Close();
            }
            return succes;
        }

        public static bool UpdatePerson(Person p)
        {
            bool succes = false;

            Person dPerson = new Person();
            ReadPerson(p.ID, ref dPerson);

            Type type = p.GetType();
            PropertyInfo[] props = type.GetProperties();
            string strconn = "UPDATE Bolig SET ";
            bool looped = false;

            foreach (PropertyInfo prop in props)
            {
                var bV = prop.GetValue(p);
                var dbV = prop.GetValue(dPerson);

                if (bV.ToString() != dbV.ToString())
                {
                    looped = true;
                    string name = prop.Name;

                    string firstLetter = name[0].ToString();

                    name = firstLetter.ToLower() + name.Substring(1);

                    if (p.GetType() == typeof(int) || p.GetType() == typeof(bool))
                        strconn += "" + name + " = " + bV + ", ";
                    else
                        strconn += name + " = '" + bV + "', ";
                }
            }

            if (looped)
            {
                strconn = strconn.Remove(strconn.Length - 2);

                strconn += $" WHERE ID = {p.ID};";
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

        public static bool DeletePerson(int id)
        {
            bool succes = false;

            //Delete Person

            return succes;
        }
    }
}
