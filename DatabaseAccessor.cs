using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;
using InputValidation;


namespace SemesterProjekt2021
{
    class DatabaseAccessor
    {

        private static SqlConnection currentConnection;
        private static bool connected;
        private static SqlCommand currentCommand;
        private static List<int> usedBoligIDs;
        private static List<int> usedPersonIDs;
        private static List<long> usedPersonCPRs;

        public static Result ConnectToDatabase(string dbName)
        {
            Result r = new Result();

            string strconn = @"Data Source=" + Environment.MachineName + ";Initial Catalog=" + dbName + ";Integrated Security=True;TrustServerCertificate=True";

            currentConnection = new SqlConnection(strconn);

            string sqlString = "SELECT ID FROM Bolig;";
            usedBoligIDs = new List<int>();
            usedPersonIDs = new List<int>();
            usedPersonCPRs = new List<long>();

            try
            {
                currentConnection.Open();
                currentCommand = new SqlCommand("", currentConnection);
                currentCommand.CommandText = sqlString;

                SqlDataReader reader = currentCommand.ExecuteReader();

                while (reader.Read())
                {
                    usedBoligIDs.Add(reader.GetInt32(0));
                }

                currentConnection.Close();

            }
            catch (Exception e)
            {
                r.Message = e.Message;
                r.Type = e.GetType().ToString();
                r.Error = true;
            }

            try
            {
                currentConnection.Open();
                sqlString = "SELECT ID FROM Person;";
                currentCommand = new SqlCommand(sqlString, currentConnection);
                currentCommand.CommandText = "SELECT ID FROM Person;";
                SqlDataReader reader = currentCommand.ExecuteReader();

                while (reader.Read())
                {
                    usedPersonIDs.Add(reader.GetInt32(0));
                }

                currentConnection.Close();
            }
            catch (Exception e)
            {
                r.Message = e.Message;
                r.Type = e.GetType().ToString();
                r.Error = true;
            }

            try
            {
                currentConnection.Open();
                currentCommand = new SqlCommand("", currentConnection);
                currentCommand.CommandText = "SELECT CPR FROM Person;";
                SqlDataReader reader = currentCommand.ExecuteReader();

                while (reader.Read())
                {
                    usedPersonCPRs.Add(reader.GetInt64(0));
                }

                currentConnection.Close();
            }
            catch (Exception e)
            {
                r.Message = e.Message;
                r.Type = e.GetType().ToString();
                r.Error = true;
            }

            /*
            string s = "";

            for (int i = 0; i < usedPersonCPRs.Count; i++)
            {
                s += usedPersonCPRs[i] + "\n";
            }


            MessageBox.Show(s);
            */

            connected = !r.Error;
            return r;
        }

        // Missing parameters
        public static Result SearchBoligBy(string parameter, string value, string condition, ref Bolig[] result)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

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

                result = blst.ToArray();

                reader.Close();
                currentConnection.Close();
            }
            else
            {
                res.Error = true;
                res.Message = "Database not connected";
            }

            return res;
        }

        public static Result CreateBolig(Bolig b)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            if (usedBoligIDs.Contains(b.Id))
            {
                res.Error = true;
                res.Type = " Multiple ID's";
                res.Message = "ID already exists";
                return res;
            }

            string sqlStringF = "INSERT INTO Bolig (";
            string sqlStringL = ") VALUES (";


            Type type = b.GetType();
            PropertyInfo[] props = type.GetProperties();
            List<object> objs = new List<object>();
            List<string> pNames = new List<string>();

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

                sqlStringF += name + ", ";
                sqlStringL += "@" + name + ", ";
                pNames.Add("@" + name);

            }
            sqlStringF = sqlStringF.Remove(sqlStringF.Length - 2);
            sqlStringL = sqlStringL.Remove(sqlStringL.Length - 2);

            string sqlString = sqlStringF + sqlStringL + ");";

            currentCommand.CommandText = sqlString;

            for (int i = 0; i < objs.Count; i++)
                currentCommand.Parameters.AddWithValue(pNames[i], objs[i]);

            MessageBox.Show(sqlString);

            if (connected)
            {
                currentConnection.Open();

                currentCommand.ExecuteNonQuery();
                usedBoligIDs.Add(b.Id);
                currentConnection.Close();

            }
            else
            {
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }

            return res;
        }

        public static Result ReadAllBolig(ref Bolig[] bs)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            List<Bolig> blst = new List<Bolig>();

            string sqlString = "SELECT * FROM Bolig";
            currentCommand.CommandText = sqlString;

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                object[] objs = new object[reader.FieldCount];

                while (reader.Read())
                {
                    Bolig b = new Bolig();
                    reader.GetValues(objs);

                    Type type = b.GetType();
                    PropertyInfo[] props = type.GetProperties();
                    int i = 0;
                    foreach (PropertyInfo p in props)
                    {
                        if (objs[i].GetType() != typeof(DBNull))
                            p.SetValue(b, objs[i]);
                        i++;
                    }
                    blst.Add(b);
                }

                bs = blst.ToArray();

                reader.Close();
                currentConnection.Close();
            }
            else
            {
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }
            return res;

        }

        public static Result ReadBolig(int id, ref Bolig b)
        {
            Result res = new Result();

            string sqlString = "SELECT * FROM Bolig WHERE ID = @ID;";
            currentCommand = new SqlCommand(sqlString, currentConnection);
            currentCommand.Parameters.AddWithValue("@ID", id);

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                object[] objs = new object[reader.FieldCount];

                if (reader.Read())
                {
                    reader.GetValues(objs);

                    Type type = b.GetType();
                    PropertyInfo[] props = type.GetProperties();
                    int i = 0;
                    foreach (PropertyInfo p in props)
                    {
                        if (objs[i].GetType() != typeof(DBNull))
                            p.SetValue(b, objs[i]);
                        i++;
                    }
                }
                else
                {
                    res.Error = true;
                    res.Message = "Bolig with ID not found. Try Create instead.";
                    res.Type = "IDNotFound";
                }
                reader.Close();
                currentConnection.Close();
            }
            else
            {
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }
            return res;
        }

        public static Result UpdateBolig(Bolig b)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            Bolig dBolig = new Bolig();
            Result readRes = ReadBolig(b.Id, ref dBolig);
            if (readRes.Error) return readRes;


            Type type = b.GetType();
            PropertyInfo[] props = type.GetProperties();
            string sqlString = "UPDATE Bolig SET ";
            bool looped = false;

            foreach (PropertyInfo p in props)
            {
                var bV = p.GetValue(b);
                var dbV = p.GetValue(dBolig);

                if (bV == null) continue;

                if (bV.GetType() == typeof(int))
                    if ((int)bV < 0) continue;

                if (p.Name == "ID")
                    continue;

                if (dbV == null || (bV.ToString() != dbV.ToString()))
                {
                    looped = true;
                    string name = p.Name;

                    string firstLetter = name[0].ToString();

                    name = firstLetter.ToLower() + name.Substring(1);

                    if (name == "realtorId") name = "ejendomsmælgerID";
                    if (name == "sellerId") name = "sælgerID";
                    if (name == "buyerId") name = "køberID";

                    sqlString += name + " = @" + name + ", ";
                    currentCommand.Parameters.AddWithValue("@" + name, bV);
                }
            }

            if (looped)
            {
                sqlString = sqlString.Remove(sqlString.Length - 2);

                sqlString += " WHERE ID = @ID;";
                MessageBox.Show(sqlString);

                currentCommand.CommandText = sqlString;

                if (connected)
                {
                    currentConnection.Open();

                    currentCommand.ExecuteNonQuery();

                    currentConnection.Close();
                }
                else
                {
                    res.Error = true;
                    res.Message = "Database not connected";
                    res.Type = "ConnectionError";
                }
            }
            else
            {
                res.Error = true;
                res.Message = "No new information given.";
                res.Type = "LackingData";
            }
            return res;
        }

        public static Result ArchiveBolig(int id)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            Bolig b = new Bolig();
            res = ReadBolig(id, ref b);

            if (!res.Error && b.Active)
            {
                b.Active = false;

                res = UpdateBolig(b);
            }
            else
            {
                res.Error = true;
                res.Type = "AlreadyArchived";
                res.Message = "The Bolig with the given ID has already been archived.";
            }

            return res;
        }

        public static Result CreatePerson(Person p)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            if (usedPersonIDs.Contains(p.ID))
            {
                res.Error = true;
                res.Type = " Multiple ID's";
                res.Message = "ID already exists";
                return res;
            }

            if (usedPersonCPRs.Contains(p.CPR))
            {
                res.Error = true;
                res.Type = " Multiple CPR's";
                res.Message = "CPR already exists";
                return res;
            }

            string sqlStringF = "INSERT INTO Person (";
            string sqlStringL = ") VALUES (";

            Type type = p.GetType();
            PropertyInfo[] props = type.GetProperties();
            List<object> objs = new List<object>();
            List<string> pNames = new List<string>();

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

                sqlStringF += name + ", ";
                sqlStringL += "@" + name + ", ";
                pNames.Add("@" + name);

            }
            sqlStringF = sqlStringF.Remove(sqlStringF.Length - 2);
            sqlStringL = sqlStringL.Remove(sqlStringL.Length - 2);

            string sqlString = sqlStringF + sqlStringL + ");";

            currentCommand.CommandText = sqlString;

            for (int i = 0; i < objs.Count; i++)
                currentCommand.Parameters.AddWithValue(pNames[i], objs[i]);

            MessageBox.Show(sqlString);

            if (connected)
            {
                currentConnection.Open();

                currentCommand.ExecuteNonQuery();

                currentConnection.Close();
            }
            else
            {
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }

            return res;
        }

        public static Result ReadAllPerson(ref Person[] ps)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);
            string sqlString = "SELECT * FROM Person;";
            currentCommand.CommandText = sqlString;
            List<Person> plst = new List<Person>();

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                object[] objs = new object[reader.FieldCount];

                while (reader.Read())
                {
                    Person p = new Person();

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
                    plst.Add(p);
                }
                ps = plst.ToArray();
                reader.Close();
                currentConnection.Close();
            }
            else
            {
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }
            return res;
        }

        public static Result ReadPerson(int id, ref Person p)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);
            string sqlString = "SELECT * FROM Person WHERE ID = @ID;";
            currentCommand.Parameters.AddWithValue("@ID", id);
            currentCommand.CommandText = sqlString;

            if (connected)
            {
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                object[] objs = new object[reader.FieldCount];

                if (reader.Read())
                {
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
                }
                else
                {
                    res.Error = true;
                    res.Message = "Person with ID not found. Try Create instead.";
                    res.Type = "IDNotFound";
                }
                reader.Close();
                currentConnection.Close();
            }
            else
            {
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }
            return res;
        }

        public static Result UpdatePerson(Person p)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            Person dPerson = new Person();
            Result readRes = ReadPerson(p.ID, ref dPerson);
            if (readRes.Error) return readRes;

            Type type = p.GetType();
            PropertyInfo[] props = type.GetProperties();
            string sqlString = "UPDATE Person SET ";
            bool looped = false;

            foreach (PropertyInfo prop in props)
            {
                var bV = prop.GetValue(p);
                var dbV = prop.GetValue(dPerson);

                if (bV == null) continue;

                if (bV.GetType() == typeof(int))
                    if ((int)bV < 0) continue;

                if (prop.Name == "CPR")
                    continue;

                if (prop.Name == "ID")
                    continue;

                if (bV.ToString() != dbV.ToString())
                {
                    looped = true;
                    string name = prop.Name;

                    string firstLetter = name[0].ToString();

                    name = firstLetter.ToLower() + name.Substring(1);

                    sqlString += name + " = @" + name + ", ";
                    currentCommand.Parameters.AddWithValue("@" + name, bV);
                }
            }

            if (looped)
            {
                sqlString = sqlString.Remove(sqlString.Length - 2);

                sqlString += " WHERE ID = @ID;";
                MessageBox.Show(sqlString);

                currentCommand.CommandText = sqlString;

                if (connected)
                {
                    currentConnection.Open();

                    currentCommand.ExecuteNonQuery();

                    currentConnection.Close();
                }
                else
                {
                    res.Error = true;
                    res.Message = "Database not connected";
                    res.Type = "ConnectionError";
                }
            }
            else
            {
                res.Error = true;
                res.Message = "No information given beyond ID";
                res.Type = "LackingData";
            }
            return res;
        }

        public static Result DeletePerson(int id)
        {
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            string strconn = "DELETE FROM Person WHERE ID = @ID;";
            currentCommand.Parameters.AddWithValue("@ID", id);
            currentCommand.CommandText = strconn;

            if (connected)
            {
                try
                {
                    currentConnection.Open();

                    currentCommand.ExecuteNonQuery();

                    currentConnection.Close();
                }
                catch (Exception e)
                {
                    if (e.GetType().ToString() == "Microsoft.Data.SqlClient.SqlException")
                    {
                        res.Error = true;
                        res.Message = "Cannot delete a person linked to a Bolig in the database.";
                        res.Type = "LinkError";
                    }
                    else
                    {
                        res.Error = true;
                        res.Message = e.Message;
                        res.Type = e.GetType().ToString();
                    }
                }
                finally
                {
                    if (currentConnection.State == System.Data.ConnectionState.Open)
                        currentConnection.Close();
                }
                
            }
            else
            {
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "Connection";
            }

            return res;
        }

        public static Result LinkRealtor(int boligId, int realtorId)
        {
            Bolig b = new Bolig();

            b.Id = boligId;

            b.RealtorId = realtorId;

            return UpdateBolig(b);
        }

        public static Result SellBolig(int boligId, int buyerId, int sellingPrice, string soldDate)
        {
            Bolig b = new Bolig();

            b.Id = boligId;

            b.BuyerId = buyerId;
            b.SellingPrice = sellingPrice;
            b.SoldDate = soldDate;
            b.IsSold = true;
            b.Active = false;

            return UpdateBolig(b);
        }

        public static Result LinkSeller(int boligId, int sellerId)
        {
            Bolig b = new Bolig();

            b.Id = boligId;

            b.SellerId = sellerId;

            return UpdateBolig(b);
        }

        public static Result LinkAllPeople(int boligId, int realtorId, int buyerId, int sellerId)
        {
            Bolig b = new Bolig();

            b.Id = boligId;

            b.RealtorId = realtorId;
            b.SellerId = sellerId;
            b.BuyerId = buyerId;

            return UpdateBolig(b);
        }

        public static int ValidPersonID()
        {
            if (usedPersonIDs.Count>0)
            {
                return usedPersonIDs.Max() + 1;
            }
            else
            {
                return 1;
            }
        }

        public static int ValidBoligID()
        {
            if (usedBoligIDs.Count>0)
            {
                return usedBoligIDs.Max() + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
