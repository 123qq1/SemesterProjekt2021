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
            MessageBox.Show(DatabaseAccessor.ConnectToDatabase("SemesterProjekt2021").Message);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            UCTestForm_Load(new HomeForm());
            LocationLabel.Text = "Home";
        }

        private void BoligButton_Click(object sender, EventArgs e)
        {
            UCTestForm_Load(new BoligForm());
            LocationLabel.Text = "Bolig";
        }

        private void PersonButton_Click(object sender, EventArgs e)
        {
            UCTestForm_Load(new PersonForm());
            LocationLabel.Text = "Person";
        }

        private void CloseProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        bool maximized = false;

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (!maximized)
            {
                Width = Screen.PrimaryScreen.WorkingArea.Width;
                Height = Screen.PrimaryScreen.WorkingArea.Height;
                maximized = true;
                Location = new Point(0, 0);
            }
            else
            {
                Width = this.DefaultMinimumSize.Width;
                Height = this.DefaultMinimumSize.Height;
                maximized = false;
                Location = new Point(60, 90);
            }

        }

        private void panelheader_Paint(object sender, PaintEventArgs e)  // DET HER ER TOP PANEL I LAYERDTESTFORM, HER SKAL INPUTES MOUSE MOVABILITY
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            UCTestForm_Load(new SearchForm());
            LocationLabel.Text = "Søg";
        }


        // Makes panelheader where people can move window from
        private bool mouseDown;
        private Point lastLocation;

        private void panelheader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelheader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
