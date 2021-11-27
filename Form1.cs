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
            string error = "Validation error";
            Bolig b = new Bolig();

            if (InputValidation.Validate.Generic.ID(textBox3.Text)) b.Id = Convert.ToInt32(textBox3.Text);
            else
                MessageBox.Show(error + "\nID");

            if (InputValidation.Validate.Bolig.Type(textBox2.Text)) b.Type = textBox2.Text;
            else
                MessageBox.Show(error + "\nType");

            if (InputValidation.Validate.Bolig.EnergyLabel(textBox4.Text)) b.EnergyLabels = textBox4.Text;
            else
                MessageBox.Show(error + "\nEnergyLabel");

            if (InputValidation.Validate.Bolig.InArea(textBox5.Text)) b.InArea = Convert.ToInt32(textBox5.Text);
            else
                MessageBox.Show(error + "\nInArea");

            if (InputValidation.Validate.Bolig.OutArea(textBox6.Text)) b.OutArea = Convert.ToInt32(textBox6.Text);
            else
                MessageBox.Show(error + "\nOutArea");

            if (InputValidation.Validate.Bolig.Built(textBox1.Text)) b.Built = Convert.ToInt32(textBox1.Text);
            else
                MessageBox.Show(error + "\nBuilt");

            if (InputValidation.Validate.Bolig.Rooms(textBox7.Text)) b.Rooms = Convert.ToInt32(textBox7.Text);
            else
                MessageBox.Show(error + "\nRooms");

            if (InputValidation.Validate.Generic.City(textBox8.Text)) b.City = textBox8.Text;
            else
                MessageBox.Show(error + "\nCity");

            if (InputValidation.Validate.Generic.Zip(textBox9.Text)) b.Zip = Convert.ToInt32(textBox9.Text);
            else
                MessageBox.Show(error + "\nZip");

            if (InputValidation.Validate.Generic.Address(textBox10.Text)) b.Address = textBox10.Text;

            b.RealtorId = 1;
            b.SellerId = 2;
            b.BuyerId = 1;
            b.OfferPrice = 0;
            b.SellingPrice = 0;
            b.Active = true;
            b.IsSold = false;
            b.SoldDate = " ";

            if (!DatabaseAccessor.CreateBolig(b)) MessageBox.Show("COULD NOT CREATE BOLIG!");
            else
                MessageBox.Show("Succes!");
        }

        private void ArkiverButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessor.ArchiveBolig(Convert.ToInt32(IDTextBox.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021")) MessageBox.Show("CAN'T CONNECT TO DATABASE YOU MONGOOSE");
        }
    }
}
