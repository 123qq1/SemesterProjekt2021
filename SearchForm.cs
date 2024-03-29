﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SemesterProjekt2021
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void PrintAll_Click(object sender, EventArgs e)
        {
            Bolig[] bs = new Bolig[1];
            InputValidation.Result r = DatabaseAccessor.ReadAllBolig(ref bs);
            string outputTilTxt = "";
            if (r.Error)
            {
                MessageBox.Show(r.Message);
            }
            else
            {
                StreamWriter stream = null;
                String filLokal = $@"c:\USERS\{Environment.UserName}\Documents\AllBolig.txt";
                try
                {
                    foreach (Bolig j in bs)
                    {
                        outputTilTxt += $"ID: {j.Id}, ";
                        outputTilTxt += $"Addresse: {j.Address}, ";
                        outputTilTxt += $"PostNr.: {j.Zip}, ";
                        outputTilTxt += $"By: {j.City}, ";
                        outputTilTxt += $"Udbudspris: {j.OfferPrice}. ";
                        outputTilTxt += $"\r\n";
                        outputTilTxt += $"\r\n";
                    }
                    if (outputTilTxt == "")
                    {
                        outputTilTxt = "Der findes ikke boliger i databasen.";
                        MessageBox.Show("Der findes ikke boliger i databasen. ");
                    }
                    stream = new StreamWriter(filLokal); // open file
                    stream.Write(outputTilTxt);
                    MessageBox.Show("Succes! Filen er placeret: " + filLokal);
                }
                catch (IOException x)
                {
                    MessageBox.Show(x.Message);
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            //DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021");
        }

        private void PrintSome_Click(object sender, EventArgs e)
        {
            Bolig[] bs = new Bolig[1];
            Person[] ps = new Person[1];

            InputValidation.Result r1 = DatabaseAccessor.ReadAllBolig(ref bs);
            InputValidation.Result r2 = DatabaseAccessor.ReadAllPerson(ref ps);
            InputValidation.Result r3 = InputValidation.Generic.City(byInputTilSearch.Text);

            if (r1.Error)
            {
                MessageBox.Show(r1.Message);
            }
            else if (r2.Error)
            {
                MessageBox.Show(r2.Message);
            }
            else if (r3.Error)
            {
                MessageBox.Show(r3.Message);
            }
            else
            {
                string outputTilTxt = "";

                StreamWriter stream = null;
                String filLokal = $@"c:\USERS\{Environment.UserName}\Documents\BoligByMedSælger.txt";
                try
                {
                    foreach (Bolig b in bs)
                    {
                        foreach (Person p in ps)
                        {
                            if (b.City == byInputTilSearch.Text && b.SellerId == p.ID)
                            {
                                outputTilTxt += $"Bolig \r\n";
                                outputTilTxt += $"ID: {b.Id}, ";
                                outputTilTxt += $"Addresse: {b.Address}, ";
                                outputTilTxt += $"PostNr.: {b.Zip}, ";
                                outputTilTxt += $"By: {b.City}, ";
                                outputTilTxt += $"Udbudspris: {b.OfferPrice}. ";
                                outputTilTxt += $"\r\n";
                                outputTilTxt += $"Sælger oplysninger\r\n";
                                outputTilTxt += $"Fornavn: {p.FName}, ";
                                outputTilTxt += $"Efternavn: {p.LName}, ";
                                outputTilTxt += $"Tlf: {p.PhoneNr}, ";
                                outputTilTxt += $"E-mail: {p.Email}. ";
                                outputTilTxt += $"\r\n";
                            }
                        }
                    }
                    if (outputTilTxt == "")
                    {
                        outputTilTxt = "Der findes ikke boliger i den valgte by.";
                        MessageBox.Show("Der findes ikke boliger i den valgte by. ");
                    }
                    stream = new StreamWriter(filLokal); // open file
                    stream.Write(outputTilTxt);
                    MessageBox.Show("Succes! Filen er placeret: " + filLokal);
                }
                catch (IOException x)
                {
                    MessageBox.Show(x.Message);
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void byInputTilSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void printMellemDatoer_Click(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Parse(dateTimePicker1.Value.ToString());
            DateTime date2 = DateTime.Parse(dateTimePicker2.Value.ToString());
            
            Person[] ps = new Person[1];
            Bolig[] bs = new Bolig[1];
            InputValidation.Result r1 = DatabaseAccessor.ReadAllBolig(ref bs);
            InputValidation.Result r2 = DatabaseAccessor.ReadAllPerson(ref ps);
            InputValidation.Result r3 = InputValidation.Bolig.Price(inputBeløbTilWeirdSearch.Text);


            if (r1.Error)
            {
                MessageBox.Show(r1.Message);
            }
            else if (r2.Error)
            {
                MessageBox.Show(r2.Message);
            }
            else if (r3.Error)
            {
                MessageBox.Show(r3.Message);
            }
            else
            {
                int i = 0;
                foreach (Person p in ps)
                {
                    if (p.IsSælger)
                    {
                        i = (int)MathF.Max(i, p.ID);
                    }
                }

                List<Bolig>[] boligList = new List<Bolig>[i + 1];
                for (int j = 0; j < boligList.Length; j++)
                {
                    boligList[j] = new List<Bolig>();
                }

                List<Bolig> boligs = new List<Bolig>(); 
                foreach (Bolig b in bs)
                {
                    if (b.IsSold)
                    {
                        DateTime dt = DateTime.Parse(b.SoldDate);
                        if (date1 <= dt && date2 >= dt)
                        {
                            boligList[b.SellerId].Add(b);
                            if (b.SellingPrice >= Convert.ToInt32(inputBeløbTilWeirdSearch.Text))
                            {
                                boligs.Add(b);
                            }
                        }
                    }
                }
                if (boligs.Count == 0)
                {
                    MessageBox.Show("Der blev ikke fundet boliger.");
                }
                else
                {
                    string output = "";

                    foreach (Bolig c in boligs)
                    {
                        foreach (Person p in ps)
                        {
                            if (p.IsSælger && (p.ID == c.SellerId))
                            {
                                output = output + ("Bolig ID: " + c.Id + ", Address: " + c.Address + ", City: " + c.City + ", PostNr: " + c.Zip) + "\n"
                                + "Boligen tilhøre sælger: " + p.ID + ", Fornavn: " + p.FName + ", Efternavn: " + p.LName + "\n\n";
                            }
                        }
                    }

                    MessageBox.Show(output);
                }
            }
        }
    }
}
