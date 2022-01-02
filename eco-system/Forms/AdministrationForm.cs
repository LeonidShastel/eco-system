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
using eco_system.Api;

namespace eco_system.Forms
{
    public partial class AdministrationForm : Form
    {
        public AdministrationForm()
        {
            InitializeComponent();

            updatePersonList();
        }

        private void updatePersonList()
        {
            people_grid_view.Rows.Clear();

            Person[] persons = Task.Run(() => ApiRequests.GetUsers()).Result;

            if (persons != null && persons.Length > 0)
            {
                foreach (Person person in persons)
                {
                    string[] row = { person.id.ToString(), person.firstname, person.lastname, person.patronymic, person.phone, person.date_of_birth, person.address, person.place_of_work };

                    people_grid_view.Rows.Add(row);

                    Debug.WriteLine($"Пользователь добавлен: {row}");
                }
            }
        }

        private Person getSelectedPerson()
        {
            DataGridViewSelectedCellCollection collection = people_grid_view.SelectedCells;
            
            Person person;
            
            if (collection != null && collection.Count > 0)
            {
                DataGridViewCell cell = collection[0];

                if (cell != null)
                {
                    int rowIndex = cell.RowIndex;
                    int personId = int.Parse(people_grid_view.Rows[rowIndex].Cells[0].Value.ToString());

                    person = Task.Run(() => ApiRequests.GetCurrentPerson(personId)).Result;
                }
                else person = null;
            }
            else person = null;
            
            return person;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            updatePersonList();
        }

        private void edit_person_button_Click(object sender, EventArgs e)
        {
            Person person = getSelectedPerson();

            if (person != null)
            {
                Form editPerson = new EditPerson(person);
                editPerson.ShowDialog();
            } else
            {
                MessageBox.Show("Ни один из пользователей не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void delete_person_button_Click(object sender, EventArgs e)
        {
            Person person = getSelectedPerson();

            if (person != null)
            {
                bool isPersonDeleted = Task.Run(() => ApiRequests.DeletePerson(person.id)).Result;

                Debug.WriteLine($"Пользователь с ID = {person.id} удален? -> {isPersonDeleted}");

                updatePersonList();
            } else
            {
                MessageBox.Show("Ни один из пользователей не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_person_button_Click(object sender, EventArgs e)
        {
            Form editPerson = new EditPerson(null);
            editPerson.ShowDialog();
        }
    }
}
