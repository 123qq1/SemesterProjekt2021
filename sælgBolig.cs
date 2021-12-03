using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            InputValidation.Result r1 = InputValidation.Generic.ID(indTastKøberId.Text);
            InputValidation.Result r2 = InputValidation.Bolig.Price(indtastSolgtePris.Text);

            int buyerId = Convert.ToInt32(indTastKøberId.Text);
            int soldPrice = Convert.ToInt32(indtastSolgtePris.Text);
            int boligId = this.boligId;
            DateTime dt = solgteDato.Value.Date;

            InputValidation.Result r3 = DatabaseAccessor.ReadBolig(boligId, ref b);
            InputValidation.Result r4 = DatabaseAccessor.ReadPerson(buyerId, ref p);

            if (r1.Error)
            {
                MessageBox.Show(r1.Message);
            }
            else if (r2.Error)
            {
                MessageBox.Show(r2.Message);
            }
            else if (r3.Error)
            {
                MessageBox.Show(r3.Message);
            }
            else if (r4.Error)
            {
                MessageBox.Show(r4.Message);
            }
            else
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
                        MessageBox.Show($"Succes! PERSON KØBER ID:{buyerId} har nu købt bolig ID:{boligId}");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"Dette ID:{buyerId} tilhører ikke en PERSON KØBER jesus.");
                }
            }

        }
    }
}
