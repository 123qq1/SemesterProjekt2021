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
        }

        private void CreateHomeButton_Click(object sender, EventArgs e)
        {
            // Create Button
            /* 
             * creates new Person object. if text passes input validation it is entered into the object.
             * if ID is not valid, DAL is not contacted.
            */

            bool success = true;
            bool active = false;
            bool subActive = true;
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
                p.CPR = Convert.ToInt32(CPRTextBox.Text);
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

            p.IsEjendomsmælger = false;
            p.IsKøber = true;
            p.IsSælger = true;

            if (success)
            {
                if (!DatabaseAccessor.CreatePerson(p)) MessageBox.Show("COULD NOT CREATE BOLIG!");
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
                if (DatabaseAccessor.ReadPerson(i, ref p))
                    MessageBox.Show($"Id: {p.ID}.\nfName: {p.FName}.\nAdresse: {p.Address}");

            IDTextBox.Clear();
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
            bool success = false;

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
                p.CPR = Convert.ToInt32(CPRTextBox.Text);
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

            // Send to DAL if conditions met
            if (success)
            {
                if (DatabaseAccessor.UpdatePerson(p))
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
                if (DatabaseAccessor.DeletePerson(Convert.ToInt32(IDTextBox.Text)))
                    MessageBox.Show("Success!");
                else
                    MessageBox.Show("DAL Error");
            else
                MessageBox.Show(r.Message);
        }
    }
}
