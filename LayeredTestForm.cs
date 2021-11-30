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
    public partial class LayeredTestForm : Form
    {

        public LayeredTestForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UCTestForm_Load(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void UCTestForm_Load(object sender, EventArgs e)
        {
            UCTestForm_Load(new HomeForm());
            DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021");
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            UCTestForm_Load(new HomeForm());
        }

        private void BoligButton_Click(object sender, EventArgs e)
        {
            UCTestForm_Load(new BoligForm());
        }

        private void PersonButton_Click(object sender, EventArgs e)
        {
            UCTestForm_Load(new PersonForm());
        }

        private void CloseProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized) 
                WindowState = FormWindowState.Normal;
        }

        private void panelheader_Paint(object sender, PaintEventArgs e)  // DET HER ER TOP PANEL I LAYERDTESTFORM, HER SKAL INPUTES MOUSE MOVABILITY
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            UCTestForm_Load(new SearchForm());
        }
    }
}
