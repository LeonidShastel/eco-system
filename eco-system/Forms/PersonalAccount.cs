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
    public partial class PersonalAccount : Form
    {
        ApiRequests api = new ApiRequests();
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
                person = Task.Run(()=>api.GetCurrentPerson(id)).Result;
                UserLogin();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка", "Персольнальный ID должен быть из цифр");
            }
        }
        private void UserLogin()
        {
            textBoxId.Visible = false;
            buttonLogin.Visible = false;


            labelLastname.Text = "Фамилия: " + person.lastname;
            labelFirstname.Text = "Имя: " + person.firstname;
            labelPatronymic.Text = "Отчество: " + person.patronymic;
            labelPhone.Text = "Телефон: " + person.phone;
            labelDateOfBirth.Text = "Дата рождения: " + person.date_of_birth;
            labelAddress.Text = "Адрес: " + person.address;
            labelPlaceOfWork.Text = "Место работы: " + person.place_of_work;
        }
    }
}
