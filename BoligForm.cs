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
    public partial class BoligForm : Form
    {
        public BoligForm()
        {
            InitializeComponent();
        }

        private void CreateHomeButton_Click(object sender, EventArgs e)
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
            r = InputValidation.Bolig.Type(TypeComboBox.Text.ToLower());
            if (!r.Error)
                b.Type = TypeComboBox.Text.ToLower();

            // Validate Energy Label
            r = InputValidation.Bolig.EnergyLabel(EnergyComboBox.Text);
            if (!r.Error)
                b.EnergyLabels = EnergyComboBox.Text;

            // Validate InArea
            r = InputValidation.Bolig.Area(InAreaTextBox.Text);
            if (!r.Error)
                b.InArea = Convert.ToInt32(InAreaTextBox.Text);

            // Validate OutArea
            r = InputValidation.Bolig.Area(OutAreaTextBox.Text);
            if (!r.Error)
                b.OutArea = Convert.ToInt32(OutAreaTextBox.Text);

            // Validate Built
            r = InputValidation.Bolig.Built(BuiltTextBox.Text);
            if (!r.Error)
                b.Built = Convert.ToInt32(BuiltTextBox.Text);

            // Validate Rooms
            r = InputValidation.Bolig.Rooms(RoomsTextBox.Text);
            if (!r.Error)
                b.Rooms = Convert.ToInt32(RoomsTextBox.Text);

            // Validate City
            r = InputValidation.Generic.City(CityTextBox.Text);
            if (!r.Error)
                b.City = CityTextBox.Text;
            else
                subActive = false;

            // Validate ZIP
            r = InputValidation.Generic.Zip(ZipTextBox.Text);
            if (!r.Error)
                b.Zip = Convert.ToInt32(ZipTextBox.Text);
            else
                subActive = false;

            // Validate Address
            r = InputValidation.Generic.Address(AddresseTextBox.Text);
            if (!r.Error)
                b.Address = AddresseTextBox.Text;
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
                Result r2 = DatabaseAccessor.CreateBolig(b);
                if (r2.Error) MessageBox.Show("COULD NOT CREATE BOLIG!");
                else
                    MessageBox.Show("Succes!");
            }
            else
                MessageBox.Show("Cannot create Bolig without valid ID.");
        }

        private void ReadHomeButton_Click(object sender, EventArgs e)
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
            {
                Result r2 = DatabaseAccessor.ReadBolig(i, ref b);
                if (!r.Error)
                    MessageBox.Show($"Id: {b.Id}.\nRealtorId: {b.RealtorId}.\nAdresse: {b.Address}");
            }

            IDTextBox.Clear();
        }

        private void UpdateHomeButton_Click(object sender, EventArgs e)
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
            r = InputValidation.Bolig.Type(TypeComboBox.Text.ToLower());
            if (!r.Error)
                b.Type = TypeComboBox.Text.ToLower();
            else
                MessageBox.Show(r.Message);

            // Validate EnergyLabel
            r = InputValidation.Bolig.EnergyLabel(EnergyComboBox.Text);
            if (!r.Error)
                b.EnergyLabels = EnergyComboBox.Text;
            else
                MessageBox.Show(r.Message);

            // Validate InArea
            r = InputValidation.Bolig.Area(InAreaTextBox.Text);
            if (!r.Error)
                b.InArea = Convert.ToInt32(InAreaTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate OutArea
            r = InputValidation.Bolig.Area(OutAreaTextBox.Text);
            if (!r.Error)
                b.OutArea = Convert.ToInt32(OutAreaTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate Built
            r = InputValidation.Bolig.Built(BuiltTextBox.Text);
            if (!r.Error)
                b.Built = Convert.ToInt32(BuiltTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate Rooms
            r = InputValidation.Bolig.Rooms(RoomsTextBox.Text);
            if (!r.Error)
                b.Rooms = Convert.ToInt32(RoomsTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate City
            r = InputValidation.Generic.City(CityTextBox.Text);
            if (!r.Error)
                b.City = CityTextBox.Text;
            else
                MessageBox.Show(r.Message);

            // Validate ZIP
            r = InputValidation.Generic.Zip(ZipTextBox.Text);
            if (!r.Error)
                b.Zip = Convert.ToInt32(ZipTextBox.Text);
            else
                MessageBox.Show(r.Message);

            // Validate Address
            r = InputValidation.Generic.Address(AddresseTextBox.Text);
            if (!r.Error)
                b.Address = AddresseTextBox.Text;
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
                Result r2 = DatabaseAccessor.UpdateBolig(b);
                if (!r2.Error)
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Error in DAL");
            }
            else
                MessageBox.Show("ID not valid. Can't update a Bolig without a valid ID.");
        }

        private void DeleteHomeButton_Click(object sender, EventArgs e)
        {
            // Archive Button
            /* 
             * Takes ID from IDTextBox and asks DAL to archive Bolig
            */
            Result r = InputValidation.Generic.ID(IDTextBox.Text);
            if (!r.Error)
            {
                Result r2 = DatabaseAccessor.ArchiveBolig(Convert.ToInt32(IDTextBox.Text));
                if (!r2.Error)
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("DAL Error");
            }
            else
                MessageBox.Show(r.Message);
        }

        private void MessageboxClearButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            TypeComboBox.ResetText();
            EnergyComboBox.ResetText();
            InAreaTextBox.Clear();
            OutAreaTextBox.Clear();
            BuiltTextBox.Clear();
            RoomsTextBox.Clear();
            CityTextBox.Clear();
            ZipTextBox.Clear();
            AddresseTextBox.Clear();
            OfferPriceTextBox.Clear();
        }

        private void SoldHomeButton_Click(object sender, EventArgs e)
        {
            int bId = Convert.ToInt32(IDTextBox.Text);
            sælgBolig sælgBolig = new sælgBolig(bId);
            sælgBolig.Show();
        }
    }
}
