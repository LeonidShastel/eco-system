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
        public int number;

        public CreateCall()
        {
            InitializeComponent();
        }

        private void buttonCall_Click(object sender, EventArgs e)
        {
            ApiRequests api = new ApiRequests();
            Call call = new Call(number, textBoxInfo.Text, person_called.id,person_called.lastname+" "+person_called.firstname+" "+person_called.patronymic,person_called.address);
           
            Call new_call = Task.Run(()=>api.CreateCall(call)).Result;

            if (new_call != null)
            {
                MessageBox.Show("Звонок", "Звонок создан, ожидайте!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Звонок", "Ошибка создания");
                this.Close();
            }
        }
    }
}
