﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance.Entities
{
    public partial class Form1 : Form
    {
        BindingList<User_cs> users = new BindingList<User_cs>();

        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.LastName; // label1
            label2.Text = Resource1.FirstName; // label2
            button1.Text = Resource1.Add; // button1
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
            var u = new User_cs()
            {
                LastName = textBox1.Text,
                FirstName = textBox2.Text,
            };
            users.Add(u);
        }


    }
}
