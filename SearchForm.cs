using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using InputValidation;

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
            Result r = DatabaseAccessor.ReadAllBolig(bs);
            string outputTilTxt = "";

            foreach (Bolig j in bs)
            {
                outputTilTxt += $"ID: {j.Id}";
                outputTilTxt += $"Addresse: {j.Address}";
                outputTilTxt += $"PostNr.: {j.Zip}";
                outputTilTxt += $"By: {j.City}";
                outputTilTxt += $"Udbudspris: {j.OfferPrice}";
                outputTilTxt += $"\r\n";
            }

            StreamWriter stream = null;
            String filLokal = $@"c:\USERS\{Environment.UserName}\AllBolig.txt";
            try
            {
                stream = new StreamWriter(filLokal, true); // open file
                stream.Write(outputTilTxt);
                MessageBox.Show(filLokal);
            }
            catch (IOException x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                if(stream != null)
                {
                    stream.Close();
                }
            }
        }
    }
}
