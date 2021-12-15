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
    public partial class sælgBolig : Form
    {
        private int boligId;
        public sælgBolig(int boligId)
        {
            InitializeComponent();
            this.boligId = boligId;
        }

        private void indTastKøberId_TextChanged(object sender, EventArgs e)
        {

        }

        private void indtastSolgtePris_TextChanged(object sender, EventArgs e)
        {

        }

        private void sælgBoligButton_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            Bolig b = new Bolig();
            bool success = true;
            int buyerId = 0;
            int soldPrice = 0;
            int boligId = this.boligId;
            Result r = new Result();
            DateTime dt = solgteDato.Value.Date;

            r = InputValidation.Generic.ID(indTastKøberId.Text);
            if (!r.Error)
                buyerId = Convert.ToInt32(indTastKøberId.Text);
            else
            {
                success = false;
                MessageBox.Show(r.Message);
            }

            r = InputValidation.Bolig.Price(indtastSolgtePris.Text);
            if (!r.Error)
                soldPrice = Convert.ToInt32(indtastSolgtePris.Text);
            else
            {
                success = false;
                MessageBox.Show(r.Message);
            }

            r = DatabaseAccessor.ReadBolig(boligId, ref b);
            if (r.Error)
            {
                success = false;
                MessageBox.Show(r.Message);
            }

            r = DatabaseAccessor.ReadPerson(buyerId, ref p);
            if (r.Error)
            {
                success = false;
                MessageBox.Show(r.Message);
            }

            if (success)
            {
                if (p.IsKøber)
                {
                    InputValidation.Result r5 = DatabaseAccessor.SellBolig(boligId, buyerId, soldPrice, dt.ToString());
                    if (r5.Error)
                    {
                        MessageBox.Show(r5.Message);
                    }
                    else
                    {
                        MessageBox.Show($"Succes! PERSON med ID = {buyerId} har nu købt boligen med ID = {boligId}");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"Dette ID = {buyerId} tilhører ikke en Køber.");
                }
            }

        }
    }
}
