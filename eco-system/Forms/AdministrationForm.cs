﻿using System;
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
            int rowIndex = people_grid_view.SelectedCells[0].RowIndex;
            int personId = int.Parse(people_grid_view.Rows[rowIndex].Cells[0].Value.ToString());

            Person person = Task.Run(() => ApiRequests.GetCurrentPerson(personId)).Result;

            return person;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            updatePersonList();
        }

        private void edit_person_button_Click(object sender, EventArgs e)
        {
            Form editPerson = new EditPerson(getSelectedPerson());
        }

        private void delete_person_button_Click(object sender, EventArgs e)
        {
            int rowIndex = people_grid_view.SelectedCells[0].RowIndex;
            int personId = int.Parse(people_grid_view.Rows[rowIndex].Cells[0].Value.ToString());

            bool isPersonDeleted = Task.Run(() => ApiRequests.DeletePerson(personId)).Result;

            Debug.WriteLine($"Пользователь с ID = {personId} удален? -> {isPersonDeleted}");

            updatePersonList();
        }

        private void add_person_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
