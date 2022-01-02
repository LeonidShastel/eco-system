using eco_system.Api;
using eco_system.Forms;
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
using eco_system.Forms;

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
            string buttonName = ((Button)sender).Name;

            Form formToRun = null;
            switch (buttonName)
            {
                case "buttonAdministration":
                    formToRun = new AdministrationForm();
                    break;
                case "buttonMEC":
                    InfoOrganization organization_mec = new InfoOrganization();
                    organization_mec.number_organization = 101;
                    organization_mec.GetInfoCalls();
                    organization_mec.ShowDialog();
                    break;
                case "buttonHealthcare":
                    InfoOrganization organization_zdr = new InfoOrganization();
                    organization_zdr.number_organization = 103;
                    organization_zdr.GetInfoCalls();
                    organization_zdr.ShowDialog();
                    break;
                case "buttonPersonalAccount":
                    formToRun = new PersonalAccount();
                    formToRun.ShowDialog();
                    break;
            }

            if (formToRun != null) formToRun.ShowDialog();
        }
    }
}
