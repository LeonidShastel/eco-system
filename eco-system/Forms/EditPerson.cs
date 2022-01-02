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

namespace eco_system.Forms
{
    public partial class EditPerson : Form
    {
        Person mEditedPerson; 
        
        public EditPerson(Person person)
        {
            InitializeComponent();

            mEditedPerson = person;

            if (mEditedPerson != null)
            {
                name_textbox.Text = person.firstname;
                surname_textbox.Text = person.lastname;
                patronymic_textbox.Text = person.patronymic;
                number_textbox.Text = person.phone;
                date_birth_textbox.Text = person.date_of_birth;
                address_text_box.Text = person.address;
                work_textbox.Text = person.place_of_work;
            } else
            {
                save_button.Text = "Добавить";
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            mEditedPerson = new Person(name_textbox.Text, surname_textbox.Text, patronymic_textbox.Text, number_textbox.Text, 
                date_birth_textbox.Text, address_text_box.Text, work_textbox.Text);

            bool isTaskCompleted;

            if (mEditedPerson.id != 0)
            {
                isTaskCompleted = (Task.Run(() => ApiRequests.UpdatePerson(mEditedPerson)).Result != null);
                Debug.WriteLine("Update");
            } else
            {
                isTaskCompleted = (Task.Run(() => ApiRequests.CreatePerson(mEditedPerson)).Result != null);
                Debug.WriteLine("Create");
            }

            Debug.WriteLine($"Операция выполнена успешно? -> {isTaskCompleted}");
        }
    }
}
