﻿using eco_system.Api;
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

namespace eco_system
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("start");
            //Person person = Task.Run(()=>new Api.ApiRequests().GetCurrentPerson(3)).Result;
            //Debug.WriteLine(person.firstname);
            //person.lastname = "Шастель 2";

            //new ApiRequests().GetCurrentCall(101,3);
        }
    }
}