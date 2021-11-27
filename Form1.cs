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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArkiverButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessor.ArchiveBolig(Convert.ToInt32(IDTextBox.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021");
        }
    }
}
