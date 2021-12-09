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

            ToolTip NextIDTooltip = new ToolTip();  //NÆSTE ID BUTTON TOOLTIP
            NextIDTooltip.AutoPopDelay = 0;
            NextIDTooltip.InitialDelay = 0;
            NextIDTooltip.ReshowDelay = 100;
            NextIDTooltip.ShowAlways = true;
            NextIDTooltip.SetToolTip(this.ValidBoligID, "Henter et ledigt ID fra databasen");

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

            ToolTip ZipTooltip = new ToolTip(); // POSTNUMMER TEXTBOX TOOLTIP
            ZipTooltip.AutoPopDelay = 0;
            ZipTooltip.InitialDelay = 0;
            ZipTooltip.ReshowDelay = 100;
            ZipTooltip.ShowAlways = true;
            ZipTooltip.SetToolTip(this.ZipTextBox, "Indtast postnummer");

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

            ToolTip SellerTooltip = new ToolTip(); // SÆLGER ID TEXTBOX TOOLTIP
            SellerTooltip.AutoPopDelay = 0;
            SellerTooltip.InitialDelay = 0;
            SellerTooltip.ReshowDelay = 100;
            SellerTooltip.ShowAlways = true;
            SellerTooltip.SetToolTip(this.SellerIDTextbox, "Indtast ID på person der sælger boligen");

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

            ToolTip PriceEvalTooltip = new ToolTip(); // VURDER BUTTON TOOLTIP
            PriceEvalTooltip.AutoPopDelay = 0;
            PriceEvalTooltip.InitialDelay = 0;
            PriceEvalTooltip.ReshowDelay = 100;
            PriceEvalTooltip.ShowAlways = true;
            PriceEvalTooltip.SetToolTip(this.PriceEvalButton, "Laver en prisvurdering ud fra alle solgte boliger");

            ToolTip DeleteAllTooltip = new ToolTip(); // SLET ALT TEKST BUTTON TOOLTIP
            DeleteAllTooltip.AutoPopDelay = 0;
            DeleteAllTooltip.InitialDelay = 0;
            DeleteAllTooltip.ReshowDelay = 100;
            DeleteAllTooltip.ShowAlways = true;
            DeleteAllTooltip.SetToolTip(this.MessageboxClearButton, "Sletter alt indtastet information");

            ToolTip ActiveTooltip= new ToolTip(); // AKTIV CHECKBOX TOOLTIP
            ActiveTooltip.AutoPopDelay = 0;
            ActiveTooltip.InitialDelay = 0;
            ActiveTooltip.ReshowDelay = 100;
            ActiveTooltip.ShowAlways = true;
            ActiveTooltip.SetToolTip(this.ActiveCheckbox, "Markerer om boligen er på markedet");





        }

        private void CreateHomeButton_Click(object sender, EventArgs e)
        {
            // Create Button
            /* 
             * creates new Bolig object. if text passes input validation it is entered into the object.
             * if ID is not valid, DAL is not contacted.
            */

            bool success = true;
            Bolig b = new Bolig();
            Result r = null;
            string text = null;

            // Validate ID
            text = IDTextBox.Text;
            if (text == "")
            {
                success = false;
                MessageBox.Show("No ID given.");
            }
            else
            {
                if (!Validate(b, text, "ID"))
                    success = false;
            }

            // Validate Type
            text = TypeComboBox.Text.ToLower();
            if (!Validate(b, text, "Type"))
                success = false;

            // Validate Energy Label
            text = EnergyComboBox.Text;
            if (!Validate(b, text, "Energy"))
                success = false;

            // Validate InArea
            text = InAreaTextBox.Text;
            if (!Validate(b, text, "InArea"))
                success = false;


            // Validate OutArea
            text = OutAreaTextBox.Text;
            if (!Validate(b, text, "OutArea"))
                success = false;

            // Validate Built
            text = BuiltTextBox.Text;
            if (!Validate(b, text, "Built"))
                success = false;

            // Validate Rooms
            text = RoomsTextBox.Text;
            if (!Validate(b, text, "Rooms"))
                success = false;

            // Validate City
            text = CityTextBox.Text;
            if (!Validate(b, text, "City"))
                success = false;

            // Validate ZIP
            text = ZipTextBox.Text;
            if (!Validate(b, text, "ZIP"))
                success = false;

            // Validate Address
            text = AddresseTextBox.Text;
            if (!Validate(b, text, "Address"))
                success = false;

            // Validate OfferPrice
            text = OfferPriceTextBox.Text;
            if (!Validate(b, text, "OfferPrice"))
                success = false;

            // Validate EjendomsmæglerID
            text = RealtorTextbox.Text;
            if (!Validate(b, text, "RealtorID"))
                success = false;

            // Validate SælgerID
            text = SellerIDTextbox.Text;
            if (!Validate(b, text, "SellerID"))
                success = false;

            if (ActiveCheckbox.Checked == true)
                b.Active = true;

            b.IsSold = false;

            if (success)
            {
                Result r2 = DatabaseAccessor.CreateBolig(b);
                if (!r2.Error) 
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("Error: " + r2.Type + "\n" + r2.Message);
            }
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


            if (IDTextBox.Text == "") // Worlds biggest band-aid, unsure if error message will show properly. No, this does not cause a memory-leak (as far as I know).
            {
                MessageBox.Show("ID not given.");
            }
            else if (!r.Error)
                i = Convert.ToInt32(IDTextBox.Text);
            else
                MessageBox.Show("Error: " + r.Type + "\n" + r.Message);

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
                    RealtorTextbox.Text = b.RealtorId.ToString();
                    SellerIDTextbox.Text = b.SellerId.ToString();
                    ActiveCheckbox.Checked = b.Active;
                }
                else
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
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
            string text = null;

            // Validate ID
            // Check if Bolig exists? if not, ask to create?
            if (IDTextBox.Text != "")
            {
                r = InputValidation.Generic.ID(IDTextBox.Text);
                if (!r.Error)
                {
                    success = true;
                    b.Id = Convert.ToInt32(IDTextBox.Text);
                }
                else
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
            }
            else
                MessageBox.Show("ID not given.\nCan't update a Bolig without knowing which Bolig to update.");


            // Validate ID
            text = IDTextBox.Text;
            if (!Validate(b, text, "ID"))
                success = false;

            // Validate Type
            text = TypeComboBox.Text.ToLower();
            if (!Validate(b, text, "Type"))
                success = false;

            // Validate Energy Label
            text = EnergyComboBox.Text;
            if (!Validate(b, text, "Energy"))
                success = false;

            // Validate InArea
            text = InAreaTextBox.Text;
            if (!Validate(b, text, "InArea"))
                success = false;


            // Validate OutArea
            text = OutAreaTextBox.Text;
            if (!Validate(b, text, "OutArea"))
                success = false;

            // Validate Built
            text = BuiltTextBox.Text;
            if (!Validate(b, text, "Built"))
                success = false;

            // Validate Rooms
            text = RoomsTextBox.Text;
            if (!Validate(b, text, "Rooms"))
                success = false;

            // Validate City
            text = CityTextBox.Text;
            if (!Validate(b, text, "City"))
                success = false;

            // Validate ZIP
            text = ZipTextBox.Text;
            if (!Validate(b, text, "ZIP"))
                success = false;

            // Validate Address
            text = AddresseTextBox.Text;
            if (!Validate(b, text, "Address"))
                success = false;

            // Validate OfferPrice
            text = OfferPriceTextBox.Text;
            if (!Validate(b, text, "OfferPrice"))
                success = false;

            // Validate EjendomsmæglerID
            text = RealtorTextbox.Text;
            if (!Validate(b, text, "RealtorID"))
                success = false;

            // Validate SælgerID
            text = SellerIDTextbox.Text;
            if (!Validate(b, text, "SellerID"))
                success = false;

            if (ActiveCheckbox.Checked)
                b.Active = true;


            // Send to DAL if conditions met
            if (success)
            {
                r = DatabaseAccessor.UpdateBolig(b);
                if (!r.Error)
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
            }
        }

        private void DeleteHomeButton_Click(object sender, EventArgs e)
        {
            // Archive Button
            /* 
             * Takes ID from IDTextBox and asks DAL to archive Bolig
            */

            Result r = null;

            if (IDTextBox.Text != "")
            {
                r = InputValidation.Generic.ID(IDTextBox.Text);
                if (!r.Error)
                {
                    Result r2 = DatabaseAccessor.ArchiveBolig(Convert.ToInt32(IDTextBox.Text));
                    if (!r2.Error)
                        MessageBox.Show("Success!");
                    else
                        MessageBox.Show("Error: " + r2.Type + "\n" + r2.Message);
                }
                else
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
            }
            else
                MessageBox.Show("Cannot delete Bolig when no ID is given.");
            
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
            RealtorTextbox.Clear();
            SellerIDTextbox.Clear();
            ActiveCheckbox.Checked = false;
        }

        private void SoldHomeButton_Click(object sender, EventArgs e)
        {
            string bIds = IDTextBox.Text;
            InputValidation.Result r1 = InputValidation.Generic.ID(bIds);

            if (IDTextBox.Text == "") // Worlds biggest band-aid, unsure if error message will show properly. If I delete this, the program will still run (as far as I know).
            {
                MessageBox.Show("ID not given.");
            }
            else if (r1.Error)
            {
                MessageBox.Show("Error: " + r1.Type + "\n" + r1.Message);
            }
            else
            {
                int boligId = Convert.ToInt32(bIds);
                Bolig b = new Bolig();

                InputValidation.Result r2 = DatabaseAccessor.ReadBolig(boligId, ref b);

                if (r2.Error)
                {
                    MessageBox.Show("Error: " + r2.Type + "\n" + r2.Message);
                }
                else
                {
                    sælgBolig sælgBolig = new sælgBolig(boligId);
                    sælgBolig.Show();
                }
            }
        }

        private bool Validate(Bolig b, string text, string type)
        {
            bool output = true;
            Result r = null;

            if (type != "ID" && text != "")
            {
                r = VbyType(text, type);
                if (!r.Error)
                    AssertByType(b, text, type);
                else
                {
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
                    output = false;
                }
            }
            else if (type == "ID" && text != "")
            {
                r = VbyType(text, type);
                if (!r.Error)
                    AssertByType(b, text, type);
                else
                {
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
                    output = false;
                }
            }
            else if (type == "ID" && text == "")
                output = false;

            return output;
        }

        private Result VbyType(string text, string type)
        {
            Result r = null;

            switch (type)
            {
                case "ID":
                    r = InputValidation.Generic.ID(text);
                    break;

                case "Type":
                    r = InputValidation.Bolig.Type(text);
                    break;

                case "Energy":
                    r = InputValidation.Bolig.EnergyLabel(text);
                    break;

                case "InArea":
                    r = InputValidation.Bolig.Area(text);
                    break;

                case "OutArea":
                    r = InputValidation.Bolig.Area(text);
                    break;

                case "Built":
                    r = InputValidation.Bolig.Built(text);
                    break;

                case "Rooms":
                    r = InputValidation.Bolig.Rooms(text);
                    break;

                case "City":
                    r = InputValidation.Generic.City(text);
                    break;

                case "ZIP":
                    r = InputValidation.Generic.Zip(text);
                    break;

                case "Address":
                    r = InputValidation.Generic.Address(text);
                    break;

                case "OfferPrice":
                    r = InputValidation.Bolig.Price(text);
                    break;

                case "RealtorID":
                    r = InputValidation.Generic.ID(text);
                    break;

                case "SellerID":
                    r = InputValidation.Generic.ID(text);
                    break;
            }

            if (r == null)
                r = new Result("ValidationType", "Unknown Validation type.");

            return r;
        }

        private void AssertByType(Bolig b, string text, string type)
        {
            switch (type)
            {
                case "ID":
                    b.Id = Convert.ToInt32(text);
                    break;

                case "Type":
                    b.Type = text;
                    break;

                case "Energy":
                    b.EnergyLabels = text;
                    break;

                case "InArea":
                    b.InArea = Convert.ToInt32(text);
                    break;

                case "OutArea":
                    b.OutArea = Convert.ToInt32(text);
                    break;

                case "Built":
                    b.Built = Convert.ToInt32(text);
                    break;

                case "Rooms":
                    b.Rooms = Convert.ToInt32(text);
                    break;

                case "City":
                    b.City = text;
                    break;

                case "ZIP":
                    b.Zip = Convert.ToInt32(text);
                    break;

                case "Address":
                    b.Address = text;
                    break;

                case "OfferPrice":
                    b.OfferPrice = Convert.ToInt32(text);
                    break;

                case "RealtorID":
                    b.RealtorId = Convert.ToInt32(text);
                    break;

                case "SellerID":
                    b.SellerId = Convert.ToInt32(text);
                    break;
            }
        }

        private void PriceEvalButton_Click(object sender, EventArgs e)
        {
            Result r = null;
            Bolig b = new Bolig();
            bool success = true;
            string text = null;
            int recommendedPrice = 0;

            if (RoomsTextBox.Text != "" && InAreaTextBox.Text != "" && OutAreaTextBox.Text != "")
            {
                // Validate Rooms
                text = RoomsTextBox.Text;
                if (!Validate(b, text, "Rooms"))
                    success = false;

                // Validate InArea
                text = InAreaTextBox.Text;
                if (!Validate(b, text, "InArea"))
                    success = false;


                // Validate OutArea
                text = OutAreaTextBox.Text;
                if (!Validate(b, text, "OutArea"))
                    success = false;

                if (success)
                {
                    r = PriceSetter.AproximateBoligPris(b, ref recommendedPrice);
                    if (!r.Error)
                        OfferPriceTextBox.Text = recommendedPrice.ToString();
                    else
                        MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
                }
                else
                    MessageBox.Show("Cannot calculate price without valid input for InArea, OutArea and Rooms.");
            }
            else
                MessageBox.Show("Cannot evaluate the price of the current Bolig without data on Rooms, In and Out Area.");
        }

        private void ValidBoligID_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = DatabaseAccessor.ValidBoligID().ToString();
        }
    }
}
