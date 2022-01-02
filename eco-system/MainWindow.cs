using eco_system.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eco_system
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onActionsClick(object sender, EventArgs e)
        {
            string buttonName = ((Button)sender).Name.ToLower();

            switch (buttonName)
            {
                case "buttonAdministration": 

                    break;
                case "buttonMEC": 
                    
                    break;
                case "buttonHealthcare": 
                    
                    break;
                case "buttonPersonalAccount": 
                    
                    break;
            }

        }
    }
}
