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
    public partial class PersonalAccount : Form
    {
        Person person;
        public PersonalAccount()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = int.Parse(textBoxId.Text);
                person = Task.Run(() => ApiRequests.GetCurrentPerson(id)).Result;
                if (person != null)
                    UserLogin();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка", "Персольнальный ID должен быть из цифр");
            }
        }
        private void buttonsCall_Click(object sender, EventArgs e)
        {
            string buttonName = ((Button)sender).Name;
            CreateCall createCall = new CreateCall();
            createCall.person_called = person;
            createCall.number = buttonName == "Вызвать МЧС" ? 101 : 103;
            createCall.ShowDialog();
        }
        private void UserLogin()
        {
            textBoxId.Visible = false;
            buttonLogin.Visible = false;

            labelPersonalId.Text = "ID: " + person.id;
            labelPersonalId.Visible = true;
            labelLastname.Text = "Фамилия: " + person.lastname;
            labelLastname.Visible = true;
            labelFirstname.Text = "Имя: " + person.firstname;
            labelFirstname.Visible = true;
            labelPatronymic.Text = "Отчество: " + person.patronymic;
            labelPatronymic.Visible = true;
            labelPhone.Text = "Телефон: " + person.phone;
            labelPhone.Visible = true;
            labelDateOfBirth.Text = "Дата рождения: " + person.date_of_birth;
            labelDateOfBirth.Visible = true;
            labelAddress.Text = "Адрес: " + person.address;
            labelAddress.Visible = true;
            labelPlaceOfWork.Text = "Место работы: " + person.place_of_work;
            labelPlaceOfWork.Visible = true;

            buttonHealthcare.Visible = true;
            buttonMEC.Visible = true;
        }
    }
}
