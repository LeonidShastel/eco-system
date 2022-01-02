using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eco_system.Api
{
    public class Call
    {
        public int id { get; set; }
        public int call_number { get; set; }
        public string title { get; set; }
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_address { get; set; }
        public string call_time { get; set; }

        public Call(int call_number, string title, int user_id, string user_name, string user_address)
        {
            this.call_number = call_number;
            this.title = title;
            this.user_id = user_id;
            this.user_name = user_name;
            this.user_address = user_address;
        }
    }
}
