using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_system.Api
{
    public class Person
    {
        public int id { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string patronymic { get; set; }
        public string phone { get; set; }
        public string date_of_birth { get; set; }
        public string address { get; set; }
        public string place_of_work { get; set; }

        public Person(string firstname, string lastname, string patronymic, string phone, string date_of_birth, string address, string place_of_work)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.patronymic = patronymic;
            this.phone = phone;
            this.date_of_birth = date_of_birth;
            this.address = address;
            this.place_of_work = place_of_work;
        }
    }
}
