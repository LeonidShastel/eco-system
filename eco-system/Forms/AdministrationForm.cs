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
    public partial class AdministrationForm : Form
    {
        private ListView mPeopleListView;
        public AdministrationForm()
        {
            InitializeComponent();

            mPeopleListView = people_list_view;

            Person[] persons = Task.Run(() => new ApiRequests().GetUsers()).Result;

            if (persons != null && persons.Length > 0)
            {
                foreach (Person person in persons)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(person.id);
                }
            }
        }
    }
}
