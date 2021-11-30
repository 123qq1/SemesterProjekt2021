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
            Result r = null;

            // Validate ID
            r = InputValidation.Generic.ID(IDTextBox.Text);
            if (!r.Error)
                b.Id = Convert.ToInt32(IDTextBox.Text);
            else
            {
                MessageBox.Show(r.Message);
                success = false;
            }

            // Validate Type
            r = InputValidation.Bolig.Type(TypeTextBox.Text);
            if (!r.Error)
                b.Type = TypeTextBox.Text;

            // Validate Energy Label
            r = InputValidation.Bolig.EnergyLabel(EnergiMærkeTextBox.Text);
            if (!r.Error)
                b.EnergyLabels = EnergiMærkeTextBox.Text;

            // Validate InArea
            r = InputValidation.Bolig.Area(IndeArealTextBox.Text);
            if (!r.Error) 
                b.InArea = Convert.ToInt32(IndeArealTextBox.Text);

            // Validate OutArea
            r = InputValidation.Bolig.Area(UdeArealTextBox.Text);
            if (!r.Error) 
                b.OutArea = Convert.ToInt32(UdeArealTextBox.Text);

            // Validate Built
            r = InputValidation.Bolig.Built(ÅrByggetTextBox.Text);
            if (!r.Error)
                b.Built = Convert.ToInt32(ÅrByggetTextBox.Text);

            // Validate Rooms
            r = InputValidation.Bolig.Rooms(AntalRumTextBox.Text);
            if (!r.Error) 
                b.Rooms = Convert.ToInt32(AntalRumTextBox.Text);

            // Validate City
            r = InputValidation.Generic.City(ByTextBox.Text);
            if (!r.Error)
                b.City = ByTextBox.Text;
            else
                subActive = false;

            // Validate ZIP
            r = InputValidation.Generic.Zip(PostNummerBox.Text);
            if (!r.Error)
                b.Zip = Convert.ToInt32(PostNummerBox.Text);
            else
                subActive = false;

            // Validate Address
            r = InputValidation.Generic.Address(AdresseTextBox.Text);
            if (!r.Error)
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
            // Archive Button
            /* 
             * Takes ID from IDTextBox and asks DAL to archive Bolig
            */
            Result r = InputValidation.Generic.ID(IDTextBox.Text);
            if (!r.Error)
                if (DatabaseAccessor.ArchiveBolig(Convert.ToInt32(IDTextBox.Text)))
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("DAL Error");
            else
                MessageBox.Show(r.Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021"))
                MessageBox.Show("CAN'T CONNECT TO DATABASE YOU MONGOOSE");
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            // Find Button
            /* 
             * Takes ID from IDTextBox and asks DAL to fill in Bolig object
             * Displays Bolig data in Message Box
             * Should display more data and in different format, to be fixed once GUI supports it.
            */
            Result r = InputValidation.Generic.ID(IDTextBox.Text);
            Bolig b = new Bolig();
            int i = 0;

            if (!r.Error)
                i = Convert.ToInt32(IDTextBox.Text);
            else
                MessageBox.Show(r.Message);
            
            if (i != 0)
                if (DatabaseAccessor.ReadBolig(i, ref b))
                    MessageBox.Show($"Id: {b.Id}.\nRealtorId: {b.RealtorId}.\nAdresse: {b.Address}");

            IDTextBox.Clear();
        }

        private void OpdaterButton_Click(object sender, EventArgs e)
        {
            // Update Button
            /* 
             * Creates Bolig from available information. ID is must, as a reference for the database.
             * Bolig object is send to DAL, which updates information in the database.
             * If a TextBox is empty, the given field should not update - to be addressed.
            */
            Bolig b = new Bolig();
            Result r = null;
            bool success = false;

            // Validate ID
            // Check if Bolig exists? if not, ask to create?
            r = InputValidation.Generic.ID(IDTextBox.Text);
            if (!r.Error)
            {
                success = true;
                b.Id = Convert.ToInt32(IDTextBox.Text);
            }
            else
                MessageBox.Show(r.Message);

            // Validate Type
            r = InputValidation.Bolig.Type(TypeTextBox.Text);
            if (!r.Error)
                b.Type = TypeTextBox.Text;
            else
                MessageBox.Show(r.Message);

            // Validate EnergyLabel
            r = InputValidation.Bolig.EnergyLabel(EnergiMærkeTextBox.Text);
            if (!r.Error)
                b.EnergyLabels = EnergiMærkeTextBox.Text;
            else
                MessageBox.Show(r.Message);

            // Validate InArea
            r = InputValidation.Bolig.Area(IndeArealTextBox.Text);
            if (!r.Error)
                b.InArea = Convert.ToInt32(IndeArealTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate OutArea
            r = InputValidation.Bolig.Area(UdeArealTextBox.Text);
            if (!r.Error) 
                b.OutArea = Convert.ToInt32(UdeArealTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate Built
            r = InputValidation.Bolig.Built(ÅrByggetTextBox.Text);
            if (!r.Error)
                b.Built = Convert.ToInt32(ÅrByggetTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate Rooms
            r = InputValidation.Bolig.Rooms(AntalRumTextBox.Text);
            if (!r.Error) 
                b.Rooms = Convert.ToInt32(AntalRumTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate City
            r = InputValidation.Generic.City(ByTextBox.Text);
            if (!r.Error) 
                b.City = ByTextBox.Text;
            else
                MessageBox.Show(r.Message);

            // Validate ZIP
            r = InputValidation.Generic.Zip(PostNummerBox.Text);
            if (!r.Error) 
                b.Zip = Convert.ToInt32(PostNummerBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate Address
            r = InputValidation.Generic.Address(AdresseTextBox.Text);
            if (!r.Error)
                b.Address = AdresseTextBox.Text;
            else
                MessageBox.Show(r.Message);

            // tmp attributes, to be implemented fully
            b.RealtorId = 1;
            b.SellerId = 2;
            b.BuyerId = 1;
            b.OfferPrice = 0;
            b.SellingPrice = 0;
            b.Active = true;
            b.IsSold = false;
            b.SoldDate = " ";

            // Send to DAL if conditions met
            if (success)
            {
                if (DatabaseAccessor.UpdateBolig(b))
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Error in DAL");
            }
            else
                MessageBox.Show("ID not valid. Can't update a Bolig without a valid ID.");
        }
    }
}
