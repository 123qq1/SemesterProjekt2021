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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            ToolTip OverskriftTooltip= new ToolTip();  
            OverskriftTooltip.AutoPopDelay = 0;
            OverskriftTooltip.InitialDelay = 0;
            OverskriftTooltip.ReshowDelay = 100;
            OverskriftTooltip.ShowAlways = true;
            OverskriftTooltip.SetToolTip(this.OverskriftLabel, "Semesterprojekt skal være et heltal");

            ToolTip ChristofferTooltip= new ToolTip();  
            ChristofferTooltip.AutoPopDelay = 0;
            ChristofferTooltip.InitialDelay = 0;
            ChristofferTooltip.ReshowDelay = 100;
            ChristofferTooltip.ShowAlways = true;
            ChristofferTooltip.SetToolTip(this.ChristofferLabel, "Christoffer mergede den her besked");

            ToolTip GlennTooltip = new ToolTip(); 
            GlennTooltip.AutoPopDelay = 0;
            GlennTooltip.InitialDelay = 0;
            GlennTooltip.ReshowDelay = 100;
            GlennTooltip.ShowAlways = true;
            GlennTooltip.SetToolTip(this.GlennLabel, "Hvorfor løber han?");

            ToolTip JeppeTooltip = new ToolTip();  
            JeppeTooltip.AutoPopDelay = 0;
            JeppeTooltip.InitialDelay = 0;
            JeppeTooltip.ReshowDelay = 100;
            JeppeTooltip.ShowAlways = true;
            JeppeTooltip.SetToolTip(this.JeppeLabel, "\"Playing a game: Path of exile for 9 hours\"");

            ToolTip OliverTooltip = new ToolTip();  
            OliverTooltip.AutoPopDelay = 0;
            OliverTooltip.InitialDelay = 0;
            OliverTooltip.ReshowDelay = 100;
            OliverTooltip.ShowAlways = true;
            OliverTooltip.SetToolTip(this.OliverLabel, "H ar lavet for mange tooltips");
        }
    }
}
