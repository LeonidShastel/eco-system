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
        public AdministrationForm()
        {
            InitializeComponent();

            Person[] persons = Task.Run(() => new ApiRequests().GetUsers()).Result;

            if (persons != null && persons.Length > 0)
            {
                foreach (Person person in persons)
                {
                    string[] row = { person.id.ToString(), person.firstname, person.lastname, person.patronymic, person.phone, person.date_of_birth, person.address, person.place_of_work };

                    people_grib_view.Rows.Add(row);
                }
            }
        }
    }
}
