﻿using System;
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
            //Create Reault object for error handling, 
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            //Check if the id of the supplied bolig is already in use
            if (usedBoligIDs.Contains(b.Id))
            {
                res.Error = true;
                res.Type = " Multiple ID's";
                res.Message = "ID already exists";
                return res;
            }

            //Create a two part SQL string so the names and values for the columns can be filled all at once
            string sqlStringF = "INSERT INTO Bolig (";
            string sqlStringL = ") VALUES (";

            //Create an array of properties that is a decomposition of the class bolig
            Type type = b.GetType();
            PropertyInfo[] props = type.GetProperties();

            //Loop over all the properties in the class Bolig
            foreach (PropertyInfo p in props)
            { 
                //Get the value of the currdnt propertie from the supplied Bolig
                var bV = p.GetValue(b);

                //Check if the values of the propertie is null
                if (bV == null) continue;
                if (bV.GetType() == typeof(int))
                    if ((int)bV < 0) continue;
                string name = p.Name;

                //Translate from English properties
                if (name == "RealtorId") name = "ejendomsmælgerID";
                if (name == "SellerId") name = "sælgerID";
                if (name == "BuyerId") name = "køberID";

                //Compile SQL string with name and value
                CompileCreateString(name, bV, ref sqlStringF, ref sqlStringL);
            }

            //Remove the last "," from the SQL fragments
            sqlStringF = sqlStringF.Remove(sqlStringF.Length - 2);
            sqlStringL = sqlStringL.Remove(sqlStringL.Length - 2);

            //Concat the 2 parts of the SQL string with ending, and adds it to the command
            string sqlString = sqlStringF + sqlStringL + ");";
            currentCommand.CommandText = sqlString;

            //Debug the current command
            MessageBox.Show(sqlString);

            //Send the compiled command
            Result conRes = SendCommand();
            
            //Check if the command gave error
            if (conRes.Error)
            {
                res = conRes;
            }
            else
            {
                //If no errors add the id of the added bolig to th list of used ids
                usedBoligIDs.Add(b.Id);
            }

            //Return the result
            return res;
        }

        private static Result SendCommand()
        {
            Result res = new Result();
            //Execute query if there is a connection
            if (connected)
            {
                //Open connection, Execute Query
                currentConnection.Open();
                currentCommand.ExecuteNonQuery();

                //Close the connection
                currentConnection.Close();

            }
            else
            {
                //If there is no connection compile an error message
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }

            return res;
        }

        private static void CompileCreateString(string name, object v, ref string f, ref string l)
        {
            //Change the first letter of the propertie name to lovercase
            string firstLetter = name[0].ToString();
            name = firstLetter.ToLower() + name.Substring(1);

            //Compile the SQL string with the name of the propertie, and add its value as a paramater
            f += name + ", ";
            l += "@" + name + ", ";
            currentCommand.Parameters.AddWithValue("@" + name, v);
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
            //Create a result object for error catching
            Result res = new Result();

            //Construct SQL query to get bolig that matches id supplied
            string sqlString = "SELECT * FROM Bolig WHERE ID = @ID;";
            currentCommand = new SqlCommand(sqlString, currentConnection);
            currentCommand.Parameters.AddWithValue("@ID", id);

            //Check if there is a connection to the database
            if (connected)
            {
                //Open the current connection, and read the data of the bolig
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                //Create an array of objects which length is the number of column of the database
                object[] objs = new object[reader.FieldCount];

                //Check whether there is any data to read
                if (reader.Read())
                {
                    //Read the data into the array of objects
                    reader.GetValues(objs);

                    //Create an array of properties that corrospond with the properties of bolig
                    Type type = b.GetType();
                    PropertyInfo[] props = type.GetProperties();

                    //For all properties in the propertie array
                    for (int i = 0; i < props.Length; i++)
                    {
                        //If the value from the database is not null, load the value into the bolig object
                        if (objs[i].GetType() != typeof(DBNull))
                            props[i].SetValue(b, objs[i]);
                    }
                }
                else
                {
                    //Compile error is there was no data to be read
                    res.Error = true;
                    res.Message = "Bolig with ID not found. Try Create instead.";
                    res.Type = "IDNotFound";
                }
                //If a connection was opened, always close the reader and the connection
                reader.Close();
                currentConnection.Close();
            }
            else
            {
                //Compile error if no connection can be established
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }
            return res;
        }

        public static Result UpdateBolig(Bolig b)
        {
            //Create result for compiling errors, and a clean command for interfacing with the database
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            //Read the current values of the bolig with the id ssupplies
            Bolig dBolig = new Bolig();
            Result readRes = ReadBolig(b.Id, ref dBolig);

            //If the read failed return the error from the read
            if (readRes.Error) return readRes;

            //Create an array of properties that corrospond with the properties of bolig
            Type type = b.GetType();
            PropertyInfo[] props = type.GetProperties();

            //Create a string to contain the SQL string which updates the bolig
            string sqlString = "UPDATE Bolig SET ";

            //Create a bool to check whether any info was updated
            bool looped = false;

            //Loop through all the properties in bolig
            foreach (PropertyInfo p in props)
            {
                //Read the values of the old and new bolig into variables
                var bV = p.GetValue(b);
                var dbV = p.GetValue(dBolig);

                //Check if the new value is null, where strings are null, and ints are negativ
                if (bV == null) continue;
                if (bV.GetType() == typeof(int))
                    if ((int)bV < 0) continue;

                //Dont update the id value
                if (p.Name == "ID")
                    continue;

                //If the old and new data are different perfom an update
                if (dbV == null || (bV.ToString() != dbV.ToString()))
                {
                    //Set looped to true now that an update has taken place
                    looped = true;

                    //Set the name og the propertie to a variable for easy access
                    string name = p.Name;

                    //Set the first letter of the name to lowercase
                    string firstLetter = name[0].ToString();
                    name = firstLetter.ToLower() + name.Substring(1);

                    //Translate specifik names form english to danish
                    if (name == "realtorId") name = "ejendomsmælgerID";
                    if (name == "sellerId") name = "sælgerID";
                    if (name == "buyerId") name = "køberID";

                    //Compile the SQL sentence to update bolig with the propertie names and values as parameters
                    sqlString += name + " = @" + name + ", ";
                    currentCommand.Parameters.AddWithValue("@" + name, bV);
                }
            }

            //Only send message of there was values to update
            if (looped)
            {
                //Remove the last ", " from the string
                sqlString = sqlString.Remove(sqlString.Length - 2);

                //Finalize the SQL string with the supplied id
                sqlString += " WHERE ID = @ID;";
                //Debug the current SQL string
                MessageBox.Show(sqlString);

                //Set the command text of the command to the SQL string
                currentCommand.CommandText = sqlString;

                Result conRes = new Result();
                conRes = SendCommand();
                if (conRes.Error) res = conRes;
            }
            else
            {
                //If no data needs to updated compile an error
                res.Error = true;
                res.Message = "No new information given.";
                res.Type = "LackingData";
            }
            return res;
        }

        public static Result ArchiveBolig(int id)
        {
            //Create result for compiling errors, and a clean command for interfacing with the database
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            //Read the current values from the bolig with the supplied id
            Bolig b = new Bolig();
            res = ReadBolig(id, ref b);

            //If the read didnt give errors
            if (!res.Error)
            {
                //Update the bolig to be inactive
                b.Active = false;
                res = UpdateBolig(b);
            }

            return res;
        }

        public static Result CreatePerson(Person p)
        {
            //Create result for compiling errors, and a clean command for interfacing with the database
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            //Check whether the id is already in use, an return error if it does
            if (usedPersonIDs.Contains(p.ID))
            {
                res.Error = true;
                res.Type = " Multiple ID's";
                res.Message = "ID already exists";
                return res;
            }

            //Check whether the CPR is already in use, an return error if it does
            if (usedPersonCPRs.Contains(p.CPR))
            {
                res.Error = true;
                res.Type = " Multiple CPR's";
                res.Message = "CPR already exists";
                return res;
            }

            //Create a two part SQL string to compile values and names simultaneously
            string sqlStringF = "INSERT INTO Person (";
            string sqlStringL = ") VALUES (";

            //Create array of properties based on bolig
            Type type = p.GetType();
            PropertyInfo[] props = type.GetProperties();

            //Loop through all properties in bolig
            foreach (PropertyInfo prop in props)
            {
                //Read the value of person into variable for easy access
                var pV = prop.GetValue(p);

                //Check if the value is null, where strings are null, and ints are negativ
                if (pV == null) continue;
                if (pV.GetType() == typeof(int))
                    if ((int)pV < 0) continue;

                //Read the name of the propertie into variable for easy access
                string name = prop.Name;

                //Compile SQL string with name and value
                CompileCreateString(name, pV, ref sqlStringF, ref sqlStringL);

            }
            //Remove  the last ", " from the SQL strings
            sqlStringF = sqlStringF.Remove(sqlStringF.Length - 2);
            sqlStringL = sqlStringL.Remove(sqlStringL.Length - 2);

            //Compile the final SQL string
            string sqlString = sqlStringF + sqlStringL + ");";

            //Set the current command text to be the SQL string
            currentCommand.CommandText = sqlString;
            
            //Debug the SQL string
            MessageBox.Show(sqlString);

            Result conRes = new Result();

            conRes = SendCommand();
            if (conRes.Error)
            {
                res = conRes;
            }
            else
            {
                usedPersonIDs.Add(p.ID);
                usedPersonCPRs.Add(p.CPR);
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
            //Create result for compiling errors, and a clean command for interfacing with the database
            Result res = new Result();
            currentCommand = new SqlCommand("", currentConnection);

            //Create a SQL string to read the bolig with the given id
            string sqlString = "SELECT * FROM Person WHERE ID = @ID;";
            currentCommand.Parameters.AddWithValue("@ID", id);
            currentCommand.CommandText = sqlString;

            //Check whether a connection is able to be astablished
            if (connected)
            {
                //Open the connection and read the information from the database
                currentConnection.Open();
                SqlDataReader reader = currentCommand.ExecuteReader();

                //Create an array of objects which length is the number of column of the database
                object[] objs = new object[reader.FieldCount];

                //If there is any data to be read
                if (reader.Read())
                {
                    //read all the values into the object area
                    reader.GetValues(objs);

                    //Create propertie array based on person
                    Type type = p.GetType();
                    PropertyInfo[] props = type.GetProperties();

                    //Loop through each propertie in person
                    for (int i = 0; i < props.Length; i++)
                    {
                        //If the value read is not null read it into the p object
                        if (objs[i].GetType() != typeof(DBNull))
                            props[i].SetValue(p, objs[i]);
                    }
                }
                else
                {
                    //If no info avaliable to read compile error
                    res.Error = true;
                    res.Message = "Person with ID not found";
                    res.Type = "IDNotFound";
                }

                //Always close connection
                reader.Close();
                currentConnection.Close();
            }
            else
            {
                //If no connection could be astablished compile error
                res.Error = true;
                res.Message = "Database not connected";
                res.Type = "ConnectionError";
            }
            return res;
        }

        public static Result UpdatePerson(Person p)
        {
            //Create result for compiling errors, and a clean command for interfacing with the database
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
                currentConnection.Open();

                currentCommand.ExecuteNonQuery();

                currentConnection.Close();
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
