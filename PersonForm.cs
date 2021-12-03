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

            ToolTip ZipTooltip = new ToolTip(); // POST NUMMER TEXTBOX TOOLTIP
            ZipTooltip.AutoPopDelay = 0;
            ZipTooltip.InitialDelay = 0;
            ZipTooltip.ReshowDelay = 100;
            ZipTooltip.ShowAlways = true;
            ZipTooltip.SetToolTip(this.ZipTextBox, "Indsæt post nummer");

            ToolTip AdresseTooltip = new ToolTip(); // ADDRESSE TEXTBOX TOOLTIP
            AdresseTooltip.AutoPopDelay = 0;
            AdresseTooltip.InitialDelay = 0;
            AdresseTooltip.ReshowDelay = 100;
            AdresseTooltip.ShowAlways = true;
            AdresseTooltip.SetToolTip(this.AddresseTextBox, "Indsæt addresse");

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
            DeleteAllTooltip.SetToolTip(this.MessageboxClearButton, "Sletter alt indtastet information i tekstbokse");



        }

        private void CreateHomeButton_Click(object sender, EventArgs e)
        {
            // Create Button
            /* 
             * creates new Person object. if text passes input validation it is entered into the object.
             * if ID is not valid, DAL is not contacted.
            */

            bool success = true;
            Person p = new Person();
            Result r = null;

            // Validate ID
            r = InputValidation.Generic.ID(IDTextBox.Text);
            if (!r.Error)
                p.ID = Convert.ToInt32(IDTextBox.Text);
            else
            {
                MessageBox.Show(r.Message);
                success = false;
            }

            // Validate CPR
            r = InputValidation.Person.CPR(CPRTextBox.Text);
            if (!r.Error)
                p.CPR = Convert.ToInt64(CPRTextBox.Text);
            else
            {
                MessageBox.Show(r.Message);
                success = false;
            }

            // Validate Email
            r = InputValidation.Person.Email(EmailTextBox.Text);
            if (!r.Error)
                p.Email = EmailTextBox.Text;

            // Validate PhoneNr
            r = InputValidation.Person.PhoneNr(PhoneNumberTextBox.Text);
            if (!r.Error)
                p.PhoneNr = Convert.ToInt32(PhoneNumberTextBox.Text);

            // Validate fName
            r = InputValidation.Person.Name(FNameTextBox.Text);
            if (!r.Error)
                p.FName = FNameTextBox.Text;

            // Validate lNane
            r = InputValidation.Person.Name(LNameTextBox.Text);
            if (!r.Error)
                p.LName = LNameTextBox.Text;

            // Validate City
            r = InputValidation.Generic.City(CityTextBox.Text);
            if (!r.Error)
                p.City = CityTextBox.Text;

            // Validate ZIP
            r = InputValidation.Generic.Zip(ZipTextBox.Text);
            if (!r.Error)
                p.Zip = Convert.ToInt32(ZipTextBox.Text);

            // Validate Address
            r = InputValidation.Generic.Address(AddresseTextBox.Text);
            if (!r.Error)
                p.Address = AddresseTextBox.Text;

            if (RealtorCheckbox.Checked == true) 
                p.IsEjendomsmælger = true;

            if (BuyerCheckbox.Checked == true)
                p.IsKøber = true;

            if (SellerCheckbox.Checked == true)
                p.IsSælger = true;

            if (success)
            {
                Result r2 = DatabaseAccessor.CreatePerson(p);
                if (r2.Error) MessageBox.Show("COULD NOT CREATE BOLIG!");
                else
                    MessageBox.Show("Succes!");
            }
            else
                MessageBox.Show("Cannot create Person without valid ID and CPR.");
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

            if (!r.Error)
                i = Convert.ToInt32(IDTextBox.Text);
            else
                MessageBox.Show(r.Message);

            if (i != 0)
            {
                r = DatabaseAccessor.ReadPerson(i, ref p);
                if (!r.Error)
                {
                    CPRTextBox.Text = p.CPR.ToString();
                    EmailTextBox.Text = p.Email;
                    PhoneNumberTextBox.Text = p.PhoneNr.ToString();
                    FNameTextBox.Text = p.FName;
                    LNameTextBox.Text = p.LName;
                    CityTextBox.Text = p.City;
                    ZipTextBox.Text = p.Zip.ToString();
                    AddresseTextBox.Text = p.Address;

                    if (p.IsEjendomsmælger)
                        RealtorCheckbox.Checked = true;

                    if (p.IsKøber)
                        BuyerCheckbox.Checked = true;

                    if (p.IsSælger)
                        SellerCheckbox.Checked = true;
                }
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

            // Validate ID
            r = InputValidation.Generic.ID(IDTextBox.Text);
            if (!r.Error)
                p.ID = Convert.ToInt32(IDTextBox.Text);
            else
            {
                MessageBox.Show(r.Message);
                success = false;
            }

            // Validate Email
            r = InputValidation.Person.Email(EmailTextBox.Text);
            if (!r.Error)
                p.Email = EmailTextBox.Text;

            // Validate PhoneNr
            r = InputValidation.Person.PhoneNr(PhoneNumberTextBox.Text);
            if (!r.Error)
                p.PhoneNr = Convert.ToInt32(PhoneNumberTextBox.Text);

            // Validate fName
            r = InputValidation.Person.Name(FNameTextBox.Text);
            if (!r.Error && FNameTextBox.Text != "")
                p.FName = FNameTextBox.Text;

            // Validate lNane
            r = InputValidation.Person.Name(LNameTextBox.Text);
            if (!r.Error && LNameTextBox.Text != "")
                p.LName = LNameTextBox.Text;

            // Validate City
            r = InputValidation.Generic.City(CityTextBox.Text);
            if (!r.Error)
                p.City = CityTextBox.Text;

            // Validate ZIP
            r = InputValidation.Generic.Zip(ZipTextBox.Text);
            if (!r.Error)
                p.Zip = Convert.ToInt32(ZipTextBox.Text);

            // Validate Address
            r = InputValidation.Generic.Address(AddresseTextBox.Text);
            if (!r.Error)
                p.Address = AddresseTextBox.Text;

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
                    MessageBox.Show("Success");
                else
                    MessageBox.Show("Error in DAL");
            }
            else
                MessageBox.Show("ID not valid. Can't update a Bolig without a valid ID.");
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            // Delete Button
            /* 
             * Takes ID from IDTextBox and asks DAL to delete Person
            */

            Result r = InputValidation.Generic.ID(IDTextBox.Text);
            if (!r.Error)
            {
                Result r2 = DatabaseAccessor.DeletePerson(Convert.ToInt32(IDTextBox.Text));
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
    }
}
