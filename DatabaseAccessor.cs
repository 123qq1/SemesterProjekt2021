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
        private static List<int> usedBoligIDs;

        public static bool ConnectToDatabase(string dbName)
        {
            bool succes = false;

            string strconn = @"Data Source=" + Environment.MachineName +";Initial Catalog=" + dbName + ";Integrated Security=True;TrustServerCertificate=True";
       
            currentConnection = new SqlConnection(strconn);

            string sqlString = $"SELECT ID FROM Bolig;";
            usedBoligIDs = new List<int>();

            try
            {
                currentConnection.Open();
                currentCommand = new SqlCommand("", currentConnection);
                currentCommand.CommandText = sqlString;

                currentString = strconn;


                SqlDataReader reader = currentCommand.ExecuteReader();

                while (reader.Read())
                {
                    usedBoligIDs.Add(reader.GetInt32(0));
                }

                currentConnection.Close();

                succes = true;
            }
            catch (Exception)
            {
                throw;
            }

            string s = "";

            for (int i = 0; i < usedBoligIDs.Count; i++)
            {
                s += usedBoligIDs[i] + " ";
            }


            MessageBox.Show(s);
            connected = succes;
            return succes;
        }

        public static bool SearchBoligBy(string parameter, string value, string condition, ref Bolig[] result)
        {
            bool succes = false;

            string sqlString = $"SELECT * FROM Bolig WHERE {parameter} {condition} {value};";
            currentCommand.CommandText = sqlString;

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                object[] objs = new object[reader.FieldCount];
                List<Bolig> blst = new List<Bolig>();

                while (reader.Read()) 
                {
                    Bolig b = new Bolig();
                    reader.GetValues(objs);

                    Type type = result.GetType();
                    PropertyInfo[] props = type.GetProperties();
                    int i = 0;
                    foreach (PropertyInfo p in props)
                    {

                        p.SetValue(b, objs[i]);
                        i++;
                    }
                    blst.Add(b);
                }

                succes = true;

                result = blst.ToArray();

                reader.Close();
                currentConnection.Close();
            }

            return succes;
        }

        public static bool CreateBolig(Bolig b)
        {
            bool succes = false;

            if (usedBoligIDs.Contains(b.Id)) return false;

            string sqlString = $"INSERT INTO Bolig (";
            

            Type type = b.GetType();
            PropertyInfo[] props = type.GetProperties();
            List<object> objs = new List<object>();

            foreach (PropertyInfo p in props)
            {
                var bV = p.GetValue(b);

                if (bV == null) continue;

                if (bV.GetType() == typeof(int))
                    if ((int)bV < 0) continue;

                objs.Add(bV);

                string name = p.Name;

                string firstLetter = name[0].ToString();

                name = firstLetter.ToLower() + name.Substring(1);

                if (name == "realtorId") name = "ejendomsmælgerID";
                if (name == "sellerId") name = "sælgerID";
                if (name == "buyerId") name = "køberID";

                sqlString += name + ", ";

            }
            sqlString = sqlString.Remove(sqlString.Length - 2);
            sqlString += ") VALUES (";

            for (int i = 0; i < objs.Count; i++)
            {
                object o = objs[i];
                if (o.GetType() == typeof(int))
                    sqlString += o + ", ";
                else
                    sqlString += "'" + o + "'" + ", "; 
                
            }

            sqlString = sqlString.Remove(sqlString.Length - 2);
            sqlString += ");";

            currentCommand.CommandText = sqlString;

            MessageBox.Show(sqlString);

            if (connected) 
            {
                currentConnection.Open();

                succes = true;
                currentCommand.ExecuteNonQuery();
                usedBoligIDs.Add(b.Id);
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
                    if (objs[i].GetType() != typeof(DBNull))
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

                if(bV == null) continue;

                if (bV.GetType() == typeof(int))
                    if ((int)bV < 0) continue;

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

            //if (usedIDs.Contains(b.Id)) return false;

            string sqlString = $"INSERT INTO Person (";

            Type type = p.GetType();
            PropertyInfo[] props = type.GetProperties();
            List<object> objs = new List<object>();

            foreach (PropertyInfo prop in props)
            {
                var bV = prop.GetValue(p);

                if (bV == null) continue;

                if (bV.GetType() == typeof(int))
                    if ((int)bV < 0) continue;

                objs.Add(bV);

                string name = prop.Name;

                string firstLetter = name[0].ToString();

                name = firstLetter.ToLower() + name.Substring(1);

                sqlString += name + ", ";

            }
            sqlString = sqlString.Remove(sqlString.Length - 2);
            sqlString += ") VALUES (";

            for (int i = 0; i < objs.Count; i++)
            {
                object o = objs[i];
                if (o.GetType() == typeof(int))
                    sqlString += o + ", ";
                else
                    sqlString += "'" + o + "'" + ", ";

            }

            sqlString = sqlString.Remove(sqlString.Length - 2);
            sqlString += ");";

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
            string sqlString = $"SELECT * FROM Person WHERE ID = {id};";
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
                    if (objs[i].GetType() != typeof(DBNull))
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
            string strconn = "UPDATE Person SET ";
            bool looped = false;

            foreach (PropertyInfo prop in props)
            {
                var bV = prop.GetValue(p);
                var dbV = prop.GetValue(dPerson);

                if (bV == null) continue;

                if (bV.GetType() == typeof(int))
                    if ((int)bV < 0) continue;

                if (bV.ToString() != dbV.ToString())
                {
                    looped = true;
                    string name = prop.Name;

                    string firstLetter = name[0].ToString();

                    name = firstLetter.ToLower() + name.Substring(1);

                    if (p.GetType() == typeof(int))
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

            string strconn = $"DELETE FROM Person WHERE ID = {id};";
            
            currentCommand.CommandText = strconn;

            if (connected)
            {
                currentConnection.Open();

                currentCommand.ExecuteNonQuery();
                succes = true;

                currentConnection.Close();
            }

            return succes;
        }

        public static bool LinkRealtor(int boligId, int realtorId)
        {
            Bolig b = new Bolig();

            b.Id = boligId;

            b.RealtorId = realtorId;

            return UpdateBolig(b);
        }

        public static bool LinkBuyer(int boligId, int buyerId)
        {
            Bolig b = new Bolig();

            b.Id = boligId;

            b.BuyerId = buyerId;

            return UpdateBolig(b);
        }

        public static bool LinkSeller(int boligId, int sellerId)
        {
            Bolig b = new Bolig();

            b.Id = boligId;

            b.SellerId = sellerId;

            return UpdateBolig(b);
        }

        public static bool LinkAllPeople(int boligId, int realtorId, int buyerId, int sellerId)
        {
            Bolig b = new Bolig();

            b.Id = boligId;

            b.RealtorId = realtorId;
            b.SellerId = sellerId;
            b.BuyerId = buyerId;

            return UpdateBolig(b);
        }
    }
}
