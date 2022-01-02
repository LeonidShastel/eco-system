using eco_system.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eco_system.Forms
{
    public partial class CreateCall : Form
    {
        public Person person_called;

        public CreateCall()
        {
            InitializeComponent();
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            ApiRequests api = new ApiRequests();
            
        }
    }
}
