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
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();

            ToolTip IDTooltip = new ToolTip(); // ID TEXTBOX TOOLTIP
            IDTooltip.AutoPopDelay = 0;
            IDTooltip.InitialDelay = 0;
            IDTooltip.ReshowDelay = 100;
            IDTooltip.ShowAlways = true;
            IDTooltip.SetToolTip(this.IDTextBox, "Indtast ID, skal være heltal");

            ToolTip NextIDTooltip = new ToolTip(); // NÆSTE ID BUTTON TOOLTIP
            NextIDTooltip.AutoPopDelay = 0;
            NextIDTooltip.InitialDelay = 0;
            NextIDTooltip.ReshowDelay = 100;
            NextIDTooltip.ShowAlways = true;
            NextIDTooltip.SetToolTip(this.ValidPersonID, "Henter et ledigt ID fra databasen");

            ToolTip CPRTooltip = new ToolTip(); // CPR TEXTBOX TOOLTIP
            CPRTooltip.AutoPopDelay = 0;
            CPRTooltip.InitialDelay = 0;
            CPRTooltip.ReshowDelay = 100;
            CPRTooltip.ShowAlways = true;
            CPRTooltip.SetToolTip(this.CPRTextBox, "Indtast CPR nummer");

            ToolTip EmailTooltip = new ToolTip(); // EMAIL TEXTBOX TOOLTIP
            EmailTooltip.AutoPopDelay = 0;
            EmailTooltip.InitialDelay = 0;
            EmailTooltip.ReshowDelay = 100;
            EmailTooltip.ShowAlways = true;
            EmailTooltip.SetToolTip(this.EmailTextBox, "Indtast email");

            ToolTip PhoneTooltip = new ToolTip(); // TELEFON NUMMER TEXTBOX TOOLTIP
            PhoneTooltip.AutoPopDelay = 0;
            PhoneTooltip.InitialDelay = 0;
            PhoneTooltip.ReshowDelay = 100;
            PhoneTooltip.ShowAlways = true;
            PhoneTooltip.SetToolTip(this.PhoneNumberTextBox, "Indtast telefon nummer");

            ToolTip FNameTooltip = new ToolTip(); // FORNAVN TEXTBOX TOOLTIP
            FNameTooltip.AutoPopDelay = 0;
            FNameTooltip.InitialDelay = 0;
            FNameTooltip.ReshowDelay = 100;
            FNameTooltip.ShowAlways = true;
            FNameTooltip.SetToolTip(this.FNameTextBox, "Indtast fornavn");

            ToolTip LNameTooltip = new ToolTip(); // EFTERNAVN TEXTBOX TOOLTIP
            LNameTooltip.AutoPopDelay = 0;
            LNameTooltip.InitialDelay = 0;
            LNameTooltip.ReshowDelay = 100;
            LNameTooltip.ShowAlways = true;
            LNameTooltip.SetToolTip(this.LNameTextBox, "Indtast efternavn");

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

            ToolTip AdresseTooltip = new ToolTip(); // ADDRESSE TEXTBOX TOOLTIP
            AdresseTooltip.AutoPopDelay = 0;
            AdresseTooltip.InitialDelay = 0;
            AdresseTooltip.ReshowDelay = 100;
            AdresseTooltip.ShowAlways = true;
            AdresseTooltip.SetToolTip(this.AddresseTextBox, "Indtast addresse for personen");

            ToolTip BuyerTooltip= new ToolTip(); // KØBER CHECKBOX TOOLTIP
            BuyerTooltip.AutoPopDelay = 0;
            BuyerTooltip.InitialDelay = 0;
            BuyerTooltip.ReshowDelay = 100;
            BuyerTooltip.ShowAlways = true;
            BuyerTooltip.SetToolTip(this.BuyerCheckbox, "Markerer om personen er en køber");

            ToolTip SellerTooltip = new ToolTip(); // SÆLGER CHECKBOX TOOLTIP
            SellerTooltip.AutoPopDelay = 0;
            SellerTooltip.InitialDelay = 0;
            SellerTooltip.ReshowDelay = 100;
            SellerTooltip.ShowAlways = true;
            SellerTooltip.SetToolTip(this.SellerCheckbox, "Markerer om personen er en sælger");

            ToolTip RealtorTooltip = new ToolTip(); // EJENDOMSMÆLGER CHECKBOX TOOLTIP
            RealtorTooltip.AutoPopDelay = 0;
            RealtorTooltip.InitialDelay = 0;
            RealtorTooltip.ReshowDelay = 100;
            RealtorTooltip.ShowAlways = true;
            RealtorTooltip.SetToolTip(this.RealtorCheckbox, "Markerer om personen er en ejendomsmælger");

            ToolTip CreateTooltip = new ToolTip(); // OPRET TEXTBOX TOOLTIP
            CreateTooltip.AutoPopDelay = 0;
            CreateTooltip.InitialDelay = 0;
            CreateTooltip.ReshowDelay = 100;
            CreateTooltip.ShowAlways = true;
            CreateTooltip.SetToolTip(this.CreatePersonButton, "Opretter person ud fra alle parametre");

            ToolTip ReadTooltip = new ToolTip(); // FIND TEXTBOX TOOLTIP
            ReadTooltip.AutoPopDelay = 0;
            ReadTooltip.InitialDelay = 0;
            ReadTooltip.ReshowDelay = 100;
            ReadTooltip.ShowAlways = true;
            ReadTooltip.SetToolTip(this.ReadPersonButton, "Finder information om person ud fra ID");

            ToolTip UpdateTooltip = new ToolTip(); // OPDATER TEXTBOX TOOLTIP
            UpdateTooltip.AutoPopDelay = 0;
            UpdateTooltip.InitialDelay = 0;
            UpdateTooltip.ReshowDelay = 100;
            UpdateTooltip.ShowAlways = true;
            UpdateTooltip.SetToolTip(this.UpdatePersonButton, "Opdaterer information om person ud fra ID");

            ToolTip DeleteTooltip = new ToolTip(); // SLET TEXTBOX TOOLTIP
            DeleteTooltip.AutoPopDelay = 0;
            DeleteTooltip.InitialDelay = 0;
            DeleteTooltip.ReshowDelay = 100;
            DeleteTooltip.ShowAlways = true;
            DeleteTooltip.SetToolTip(this.DeletePersonButton, "Sletter information om person ud fra ID");

            ToolTip DeleteAllTooltip = new ToolTip(); // SLET ALT TEKSTs BUTTON TOOLTIP
            DeleteAllTooltip.AutoPopDelay = 0;
            DeleteAllTooltip.InitialDelay = 0;
            DeleteAllTooltip.ReshowDelay = 100;
            DeleteAllTooltip.ShowAlways = true;
            DeleteAllTooltip.SetToolTip(this.MessageboxClearButton, "Sletter alt indtastet information");



        }

        private void CreateHomeButton_Click(object sender, EventArgs e)
        {
            // Create Button
            /* 
             * creates new Person object. if text passes input validation it is entered into the object.
             * if ID is not valid, DAL is not contacted.
            */

            bool success = true;
            bool subsuccess = true;
            Person p = new Person();
            Result r = null;
            string text = null;

            // Validate ID
            text = IDTextBox.Text;
            if (!Validate(p, text, "ID"))
                subsuccess = false;
            

            // Validate CPR
            text = CPRTextBox.Text;
            if (!Validate(p, text, "CPR"))
                subsuccess = false;

            // Validate Email
            text = EmailTextBox.Text;
            if (!Validate(p, text, "Email"))
                success = false;

            // Validate PhoneNr
            text = PhoneNumberTextBox.Text;
            if (!Validate(p, text, "PhoneNr"))
                success = false;

            // Validate fName
            text = FNameTextBox.Text;
            if (!Validate(p, text, "FName"))
                success = false;

            // Validate lNane
            text = LNameTextBox.Text;
            if (!Validate(p, text, "LName"))
                success = false;

            // Validate City
            text = CityTextBox.Text;
            if (!Validate(p, text, "City"))
                success = false;

            // Validate ZIP
            text = ZipTextBox.Text;
            if (!Validate(p, text, "ZIP"))
                success = false;

            // Validate Address
            text = AddresseTextBox.Text;
            if (!Validate(p, text, "Address"))
                success = false;

            if (RealtorCheckbox.Checked == true) 
                p.IsEjendomsmælger = true;

            if (BuyerCheckbox.Checked == true)
                p.IsKøber = true;

            if (SellerCheckbox.Checked == true)
                p.IsSælger = true;

            if (success && subsuccess)
            {
                r = DatabaseAccessor.CreatePerson(p);
                if (!r.Error)
                    MessageBox.Show($"Succes!\nOprettede Person med ID = {p.ID}");
                else
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
            }
            else if (success && !subsuccess)
                MessageBox.Show("Kan ikke oprette Person uden et gyldigt ID og CPR-nummer.");
            
        }

        private void ReadHomeButton_Click(object sender, EventArgs e)
        {
            // Find Button
            /* 
             * Takes ID from IDTextBox and asks DAL to fill in Person object
             * Displays Person data in Message Box
             * Should display more data and in different format, to be fixed once GUI supports it.
            */
            Result r = InputValidation.Generic.ID(IDTextBox.Text);
            Person p = new Person();
            int i = 0;

            if (IDTextBox.Text == "") // Worlds biggest band-aid, unsure if error message will show properly. ID not given, fucks not given(as far as I know).
            {
                MessageBox.Show("Intet ID angivet.");
            }
            else if (!r.Error)
                i = Convert.ToInt32(IDTextBox.Text);
            else
                MessageBox.Show("Error: " + r.Type + "\n" + r.Message);

            if (i != 0)
            {
                r = DatabaseAccessor.ReadPerson(i, ref p);
                if (!r.Error)
                {
                    CPRTextBox.Text = p.CPR.ToString();
                    EmailTextBox.Text = p.Email;
                    if (p.PhoneNr != -1)
                        PhoneNumberTextBox.Text = p.PhoneNr.ToString();
                    FNameTextBox.Text = p.FName;
                    LNameTextBox.Text = p.LName;
                    CityTextBox.Text = p.City;
                    if (p.Zip != -1)
                        ZipTextBox.Text = p.Zip.ToString();
                    AddresseTextBox.Text = p.Address;
                    RealtorCheckbox.Checked = p.IsEjendomsmælger;
                    SellerCheckbox.Checked = p.IsSælger;
                    BuyerCheckbox.Checked = p.IsKøber;
                }
                else
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
            }
        }

        private void UpdatePersonButton_Click(object sender, EventArgs e)
        {
            // Update Button
            /* 
             * Creates Person from available information. ID is must, as a reference for the database.
             * Person object is send to DAL, which updates information in the database.
             * If a TextBox is empty, the given field should not update - to be addressed.
            */
            Person p = new Person();
            Result r = null;
            bool success = true;
            string text = null;

            // Validate ID
            text = IDTextBox.Text;
            if (text == "")
            {
                success = false;
                MessageBox.Show("Intet ID angivet.");
            }
            else
            {
                if (!Validate(p, text, "ID"))
                    success = false;
            }

            // Validate Email
            text = EmailTextBox.Text;
            if (!Validate(p, text, "Email"))
                success = false;

            // Validate PhoneNr
            text = PhoneNumberTextBox.Text;
            if (!Validate(p, text, "PhoneNr"))
                success = false;

            // Validate fName
            text = FNameTextBox.Text;
            if (!Validate(p, text, "FName"))
                success = false;

            // Validate lNane
            text = LNameTextBox.Text;
            if (!Validate(p, text, "LName"))
                success = false;

            // Validate City
            text = CityTextBox.Text;
            if (!Validate(p, text, "City"))
                success = false;

            // Validate ZIP
            text = ZipTextBox.Text;
            if (!Validate(p, text, "ZIP"))
                success = false;

            // Validate Address
            text = AddresseTextBox.Text;
            if (!Validate(p, text, "Address"))
                success = false;

            if (RealtorCheckbox.Checked == true)
                p.IsEjendomsmælger = true;

            if (BuyerCheckbox.Checked == true)
                p.IsKøber = true;

            if (SellerCheckbox.Checked == true)
                p.IsSælger = true;

            // Send to DAL if conditions met
            if (success)
            {
                Result r2 = DatabaseAccessor.UpdatePerson(p);
                if (!r2.Error)
                    MessageBox.Show($"Succes!\nOpdaterede Person med ID = {p.ID}");
                else
                    MessageBox.Show("Error: " + r2.Type + "\n" + r2.Message);
            }
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            // Delete Button
            /* 
             * Takes ID from IDTextBox and asks DAL to delete Person
            */

            Result r = InputValidation.Generic.ID(IDTextBox.Text);

            if (IDTextBox.Text == "") // Worlds biggest band-aid, unsure if error message will show properly. This is a band aid emoji 🩹 (as far as I know).
            {
                MessageBox.Show("Intet ID angivet.");
            }
            else if (!r.Error)
            {
                Result r2 = DatabaseAccessor.DeletePerson(Convert.ToInt32(IDTextBox.Text));
                if (!r2.Error)
                    MessageBox.Show($"Succes!\nSlettede Person med ID = {IDTextBox.Text}");
                else
                    MessageBox.Show("Error: " + r2.Type + "\n" + r2.Message);
            }
            else
                MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
        }

        private void MessageboxClearButton_Click(object sender, EventArgs e)
        {
            IDTextBox.Clear();
            CPRTextBox.Clear();
            EmailTextBox.Clear();
            PhoneNumberTextBox.Clear();
            FNameTextBox.Clear();
            LNameTextBox.Clear();
            CityTextBox.Clear();
            ZipTextBox.Clear();
            AddresseTextBox.Clear();
            BuyerCheckbox.Checked = false;
            SellerCheckbox.Checked = false;
            RealtorCheckbox.Checked = false;
        }

        private bool Validate(Person p, string text, string type)
        {
            bool output = true;
            Result r = null;

            if (type != "ID" && text != "")
            {
                r = VbyType(text, type);
                if (!r.Error)
                    AssertByType(p, text, type);
                else
                {
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
                    output = false;
                }
            }
            else if ((type == "ID" || type == "CPR") && text != "")
            {
                r = VbyType(text, type);
                if (!r.Error)
                    AssertByType(p, text, type);
                else
                {
                    MessageBox.Show("Error: " + r.Type + "\n" + r.Message);
                    output = false;
                }
            }
            else if ((type == "ID" || type == "CPR") && text == "")
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

                case "CPR":
                    r = InputValidation.Person.CPR(text);
                    break;

                case "Email":
                    r = InputValidation.Person.Email(text);
                    break;

                case "PhoneNr":
                    r = InputValidation.Person.PhoneNr(text);
                    break;

                case "FName":
                    r = InputValidation.Person.Name(text);
                    break;

                case "LName":
                    r = InputValidation.Person.Name(text);
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
            }

            return r;
        }

        private void AssertByType(Person p, string text, string type)
        {
            switch (type)
            {
                case "ID":
                    p.ID = Convert.ToInt32(text);
                    break;

                case "CPR":
                    p.CPR = Convert.ToInt64(text);
                    break;

                case "Email":
                    p.Email = text;
                    break;

                case "PhoneNr":
                    p.PhoneNr = Convert.ToInt32(text);
                    break;

                case "FName":
                    p.FName = text;
                    break;

                case "LName":
                    p.LName = text;
                    break;

                case "City":
                    p.City = text;
                    break;

                case "ZIP":
                    p.Zip = Convert.ToInt32(text);
                    break;

                case "Address":
                    p.Address = text;
                    break;
            }
        }

        private void ValidPersonID_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = DatabaseAccessor.ValidPersonID().ToString();
        }
    }
}
