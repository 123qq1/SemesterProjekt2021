using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputValidation;

namespace SemesterProjekt2021
{
    public partial class Form1 : Form
    {
        string error = "Validation error";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create Button
            /* 
             * creates new Bolig object. if text passes input validation it is entered into the object.
             * if ID is not valid, DAL is not contacted.
            */
            
            bool success = true;
            bool active = false;
            bool subActive = true;
            Bolig b = new Bolig();

            // Validate ID
            if (InputValidation.Generic.ID(IDTextBox.Text))
                b.Id = Convert.ToInt32(IDTextBox.Text);
            else
            {
                MessageBox.Show(error + "\nID");
                success = false;
            }

            // Validate Type
            if (InputValidation.Bolig.Type(TypeTextBox.Text)) 
                b.Type = TypeTextBox.Text;

            // Validate Energy Label
            if (InputValidation.Bolig.EnergyLabel(EnergiMærkeTextBox.Text))
                b.EnergyLabels = EnergiMærkeTextBox.Text;

            // Validate InArea
            if (InputValidation.Bolig.InArea(IndeArealTextBox.Text)) 
                b.InArea = Convert.ToInt32(IndeArealTextBox.Text);
            
            // Validate OutArea
            if (InputValidation.Bolig.OutArea(UdeArealTextBox.Text)) 
                b.OutArea = Convert.ToInt32(UdeArealTextBox.Text);
            
            // Validate Built
            if (InputValidation.Bolig.Built(ÅrByggetTextBox.Text))
                b.Built = Convert.ToInt32(ÅrByggetTextBox.Text);

            // Validate Rooms
            if (InputValidation.Bolig.Rooms(AntalRumTextBox.Text)) 
                b.Rooms = Convert.ToInt32(AntalRumTextBox.Text);

            // Validate City
            if (InputValidation.Generic.City(ByTextBox.Text))
                b.City = ByTextBox.Text;
            else
                subActive = false;

            // Validate ZIP
            if (InputValidation.Generic.Zip(PostNummerBox.Text))
                b.Zip = Convert.ToInt32(PostNummerBox.Text);
            else
                subActive = false;

            // Validate Address
            if (InputValidation.Generic.Address(AdresseTextBox.Text))
                b.Address = AdresseTextBox.Text;
            else
                subActive = false;

            // check if active
            if (subActive)
                active = true;


            b.RealtorId = 1;
            b.SellerId = 2;
            b.BuyerId = 1;
            b.OfferPrice = 0;
            b.SellingPrice = 0;
            b.Active = active;
            b.IsSold = false;
            b.SoldDate = " ";

            if (success)
            {
                if (!DatabaseAccessor.CreateBolig(b)) MessageBox.Show("COULD NOT CREATE BOLIG!");
                else
                    MessageBox.Show("Succes!");
            }
            else
                MessageBox.Show("Cannot create Bolig without valid ID.");
            
        }

        private void ArkiverButton_Click(object sender, EventArgs e)
        {
            if (InputValidation.Generic.ID(IDTextBox.Text))
                if (DatabaseAccessor.ArchiveBolig(Convert.ToInt32(IDTextBox.Text)))
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("DAL Error");
            else
                MessageBox.Show(error + "\nID is not an integer.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021")) MessageBox.Show("CAN'T CONNECT TO DATABASE YOU MONGOOSE");
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Bolig b = new Bolig();
            int i = 0;

            if (InputValidation.Generic.ID(IDTextBox.Text))
                i = Convert.ToInt32(IDTextBox.Text);
            else
                MessageBox.Show(error + "\nID");
            
            if (i != 0)
                if (DatabaseAccessor.ReadBolig(i, ref b))
                    MessageBox.Show($"Id: {b.Id}.\nRealtorId: {b.RealtorId}.\nAdresse: {b.Address}");

            IDTextBox.Clear();
        }

        private void OpdaterButton_Click(object sender, EventArgs e)
        {
            Bolig b = new Bolig();

            if (InputValidation.Generic.ID(IDTextBox.Text)) b.Id = Convert.ToInt32(IDTextBox.Text);
            else
                MessageBox.Show(error + "\nID");

            if (InputValidation.Bolig.Type(TypeTextBox.Text)) b.Type = TypeTextBox.Text;
            else
                MessageBox.Show(error + "\nType");

            if (InputValidation.Bolig.EnergyLabel(EnergiMærkeTextBox.Text)) b.EnergyLabels = EnergiMærkeTextBox.Text;
            else
                MessageBox.Show(error + "\nEnergyLabel");

            if (InputValidation.Bolig.InArea(IndeArealTextBox.Text)) b.InArea = Convert.ToInt32(IndeArealTextBox.Text);
            else
                MessageBox.Show(error + "\nInArea");

            if (InputValidation.Bolig.OutArea(UdeArealTextBox.Text)) b.OutArea = Convert.ToInt32(UdeArealTextBox.Text);
            else
                MessageBox.Show(error + "\nOutArea");

            if (InputValidation.Bolig.Built(ÅrByggetTextBox.Text)) b.Built = Convert.ToInt32(ÅrByggetTextBox.Text);
            else
                MessageBox.Show(error + "\nBuilt");

            if (InputValidation.Bolig.Rooms(AntalRumTextBox.Text)) b.Rooms = Convert.ToInt32(AntalRumTextBox.Text);
            else
                MessageBox.Show(error + "\nRooms");

            if (InputValidation.Generic.City(ByTextBox.Text)) b.City = ByTextBox.Text;
            else
                MessageBox.Show(error + "\nCity");

            if (InputValidation.Generic.Zip(PostNummerBox.Text)) b.Zip = Convert.ToInt32(PostNummerBox.Text);
            else
                MessageBox.Show(error + "\nZip");

            if (InputValidation.Generic.Address(AdresseTextBox.Text)) b.Address = AdresseTextBox.Text;

            b.RealtorId = 1;
            b.SellerId = 2;
            b.BuyerId = 1;
            b.OfferPrice = 0;
            b.SellingPrice = 0;
            b.Active = true;
            b.IsSold = false;
            b.SoldDate = " ";

            if (DatabaseAccessor.UpdateBolig(b))
                MessageBox.Show("Success");
            else
                MessageBox.Show("Error in DAL");
        }
    }
}
