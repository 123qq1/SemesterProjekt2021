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
    public partial class TestPrice : Form
    {
        public TestPrice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            Bolig b = new Bolig();
            b.InArea = 20;
            b.OutArea = 50;
            b.Rooms = 5;
            int rP = 0;
            InputValidation.Result r = PriceSetter.AproximateBoligPris(b,ref rP);

            MessageBox.Show(rP.ToString());
        }

        private void TestPrice_Load(object sender, EventArgs e)
        {
            DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021");
        }
    }
}
