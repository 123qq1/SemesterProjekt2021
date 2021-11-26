﻿using System;
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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            bool connectionStatus = DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021");

            PingResult.Text = connectionStatus.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bolig b = new Bolig();

            DatabaseAccessor.ReadBolig(1,ref b);

            b.Zip = 7104;
            b.Rooms = 11;
            b.IsSold = true;

            DatabaseAccessor.UpdateBolig(b);
        }
    }
}
