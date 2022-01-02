using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eco_system.Api;

namespace eco_system.Forms
{
    public partial class InfoOrganization : Form
    {
        public int number_organization = 0;
        ApiRequests api = new ApiRequests();
        public InfoOrganization()
        {
            InitializeComponent();
        }
        public void GetInfoCalls()
        {
            Call[] calls;
            calls = Task.Run(()=> api.GetCallsOrganiztion(number_organization)).Result;
            if (calls!=null)
            {
                foreach (Call call in calls)
                    dataGridViewCalls.Rows.Add(call.id, call.title, call.user_address, call_time);
            }
        }
    }
}
