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

            ToolTip IDTooltip = new ToolTip();  //ID TEXTBOX TOOLTIP
            IDTooltip.AutoPopDelay = 0;
            IDTooltip.InitialDelay =0;
            IDTooltip.ReshowDelay = 100;
            IDTooltip.ShowAlways = true;
            IDTooltip.SetToolTip(this.IDTextBox, "Indtast ID, skal være heltal");

            ToolTip TypeTooltip = new ToolTip(); //TYPE COMBOBOX TOOLTIP
            TypeTooltip.AutoPopDelay = 0;
            TypeTooltip.InitialDelay = 0;
            TypeTooltip.ReshowDelay = 100;
            TypeTooltip.ShowAlways = true;
            TypeTooltip.SetToolTip(this.TypeComboBox, "Vælg hvilken type boligen er");

            ToolTip EnergimærkeTooltip = new ToolTip(); //ENERGIMÆRKE TEXTBOX TOOLTIP
            EnergimærkeTooltip.AutoPopDelay = 0;
            EnergimærkeTooltip.InitialDelay = 0;
            EnergimærkeTooltip.ReshowDelay = 100;
            EnergimærkeTooltip.ShowAlways = true;
            EnergimærkeTooltip.SetToolTip(this.EnergyComboBox, "Vælg energimærket for boligen");

            ToolTip InAreaTooltip = new ToolTip(); // INDEAREAL TEXTBOX TOOLTIP
            InAreaTooltip.AutoPopDelay = 0;
            InAreaTooltip.InitialDelay = 0;
            InAreaTooltip.ReshowDelay = 100;
            InAreaTooltip.ShowAlways = true;
            InAreaTooltip.SetToolTip(this.InAreaTextBox, "Indtast indendørs areal, skal være heltal");

            ToolTip OutAreaTooltip = new ToolTip(); // UDEAREAL TEXTBOX TOOLTIP
            OutAreaTooltip.AutoPopDelay = 0;
            OutAreaTooltip.InitialDelay = 0;
            OutAreaTooltip.ReshowDelay = 100;
            OutAreaTooltip.ShowAlways = true;
            OutAreaTooltip.SetToolTip(this.OutAreaTextBox, "Indtast udendørs areal, skal være heltal");

            ToolTip BuiltTooltip = new ToolTip(); // ÅR BYGGET TEXTBOX TOOLTIP
            BuiltTooltip.AutoPopDelay = 0;
            BuiltTooltip.InitialDelay = 0;
            BuiltTooltip.ReshowDelay = 100;
            BuiltTooltip.ShowAlways = true;
            BuiltTooltip.SetToolTip(this.BuiltTextBox, "Indtast året som boligen er bygget i");

            ToolTip RoomsTooltip = new ToolTip(); // ANTAL RUM TEXTBOX TOOLTIP
            RoomsTooltip.AutoPopDelay = 0;
            RoomsTooltip.InitialDelay = 0;
            RoomsTooltip.ReshowDelay = 100;
            RoomsTooltip.ShowAlways = true;
            RoomsTooltip.SetToolTip(this.RoomsTextBox, "Indtast hvor mange rum boligen har");

            ToolTip CityTooltip = new ToolTip(); // BY TEXTBOX TOOLTIP
            CityTooltip.AutoPopDelay = 0;
            CityTooltip.InitialDelay = 0;
            CityTooltip.ReshowDelay = 100;
            CityTooltip.ShowAlways = true;
            CityTooltip.SetToolTip(this.CityTextBox, "Indtast by navn");

            ToolTip ZipTooltip = new ToolTip(); // POST NUMMER TEXTBOX TOOLTIP
            ZipTooltip.AutoPopDelay = 0;
            ZipTooltip.InitialDelay = 0;
            ZipTooltip.ReshowDelay = 100;
            ZipTooltip.ShowAlways = true;
            ZipTooltip.SetToolTip(this.ZipTextBox, "Indtast post nummer");

            ToolTip AddresseTooltip = new ToolTip(); // ADRESSE TEXTBOX TOOLTIP
            AddresseTooltip.AutoPopDelay = 0;
            AddresseTooltip.InitialDelay = 0;
            AddresseTooltip.ReshowDelay = 100;
            AddresseTooltip.ShowAlways = true;
            AddresseTooltip.SetToolTip(this.AddresseTextBox, "Indtast adresse for boligen");

            ToolTip OfferPriceTooltip= new ToolTip(); // UDBUDSPRIS TEXTBOX TOOLTIP
            OfferPriceTooltip.AutoPopDelay = 0;
            OfferPriceTooltip.InitialDelay = 0;
            OfferPriceTooltip.ReshowDelay = 100;
            OfferPriceTooltip.ShowAlways = true;
            OfferPriceTooltip.SetToolTip(this.OfferPriceTextBox, "Indtast udbudsprisen, skal være heltal");

            ToolTip RealtorIDTooltip = new ToolTip(); // EJENDOMSMÆLGER ID TEXTBOX TOOLTIP
            RealtorIDTooltip.AutoPopDelay = 0;
            RealtorIDTooltip.InitialDelay = 0;
            RealtorIDTooltip.ReshowDelay = 100;
            RealtorIDTooltip.ShowAlways = true;
            RealtorIDTooltip.SetToolTip(this.RealtorTextbox, "Indtast ID på ejendomsmælgeren der administrerer boligen");

            ToolTip CreateTooltip= new ToolTip(); // OPRET BUTTON TOOLTIP
            CreateTooltip.AutoPopDelay = 0;
            CreateTooltip.InitialDelay = 0;
            CreateTooltip.ReshowDelay = 100;
            CreateTooltip.ShowAlways = true;
            CreateTooltip.SetToolTip(this.CreateHomeButton, "Indsætter bolig i databasen ud fra alle parametre");

            ToolTip ReadTooltip = new ToolTip(); // FIND BUTTON TOOLTIP
            ReadTooltip.AutoPopDelay = 0;
            ReadTooltip.InitialDelay = 0;
            ReadTooltip.ReshowDelay = 100;
            ReadTooltip.ShowAlways = true;
            ReadTooltip.SetToolTip(this.ReadHomeButton, "Henter information om specefik bolig ud fra ID");

            ToolTip UpdateTooltip = new ToolTip(); // OPDATER BUTTON TOOLTIP
            UpdateTooltip.AutoPopDelay = 0;
            UpdateTooltip.InitialDelay = 0;
            UpdateTooltip.ReshowDelay = 100;
            UpdateTooltip.ShowAlways = true;
            UpdateTooltip.SetToolTip(this.UpdateHomeButton, "Opdaterer salgsprisen for boligen ud fra ID");

            ToolTip SoldTooltip = new ToolTip(); // SÆLG BUTTON TOOLTIP
            SoldTooltip.AutoPopDelay = 0;
            SoldTooltip.InitialDelay = 0;
            SoldTooltip.ReshowDelay = 100;
            SoldTooltip.ShowAlways = true;
            SoldTooltip.SetToolTip(this.SoldHomeButton, "Sælger bolig ud fra ID");

            ToolTip ArchiveTooltip = new ToolTip(); // ARKIVER BUTTON TOOLTIP
            ArchiveTooltip.AutoPopDelay = 0;
            ArchiveTooltip.InitialDelay = 0;
            ArchiveTooltip.ReshowDelay = 100;
            ArchiveTooltip.ShowAlways = true;
            ArchiveTooltip.SetToolTip(this.DeleteHomeButton, "Arkiverer bolig ud fra ID, kan stadigvæk findes i databasen");

            ToolTip DeleteAllTooltip = new ToolTip(); // SLET ALT TEKST BUTTON TOOLTIP
            DeleteAllTooltip.AutoPopDelay = 0;
            DeleteAllTooltip.InitialDelay = 0;
            DeleteAllTooltip.ReshowDelay = 100;
            DeleteAllTooltip.ShowAlways = true;
            DeleteAllTooltip.SetToolTip(this.MessageboxClearButton, "Sletter alt indtastet information i tekstbokse");





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

            //b.RealtorId = 1;
            //b.SellerId = 2;
            //b.BuyerId = 1;
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
                r = DatabaseAccessor.ReadBolig(i, ref b);
                if (!r.Error)
                {
                    TypeComboBox.Text = b.Type;
                    EnergyComboBox.Text = b.EnergyLabels;
                    InAreaTextBox.Text = b.InArea.ToString();
                    OutAreaTextBox.Text = b.OutArea.ToString();
                    BuiltTextBox.Text = b.Built.ToString();
                    RoomsTextBox.Text = b.Rooms.ToString();
                    CityTextBox.Text = b.City;
                    ZipTextBox.Text = b.Zip.ToString();
                    AddresseTextBox.Text = b.Address;
                    OfferPriceTextBox.Text = b.OfferPrice.ToString();
                }
            }
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
            string bIds = IDTextBox.Text;
            InputValidation.Result r = InputValidation.Generic.ID(bIds);
            if (r.Error)
            {
                MessageBox.Show(r.Message);
            }
            else
            {
                if (true)  // Hvis bolig id ikke findes. 
                {
                    MessageBox.Show("Bolig Id findes ikke.");
                }
                else
                {
                    int bId = Convert.ToInt32(IDTextBox.Text);
                    sælgBolig sælgBolig = new sælgBolig(bId);
                    sælgBolig.Show();
                }
            }
        }
    }
}
