﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TASK_04_04_DataAdapterProgram
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection NorthwindConnection = new SqlConnection("Data Source=DESKTOP-V1MHVOL\\MSSQLEXPRESS;Initial Catalog=Northwnd;Integrated Security=True");
        private SqlDataAdapter SqlDataAdapter1;

        private DataSet NorthwindDataset = new DataSet("Northwind");
        private DataTable CustomersTable = new DataTable("Customers");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Customers", NorthwindConnection);
            NorthwindDataset.Tables.Add(CustomersTable);
            SqlDataAdapter1.Fill(NorthwindDataset.Tables["Customers"]);
            dataGridView1.DataSource = NorthwindDataset.Tables["Customers"];

            SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);
        }

        private void UpdateButton_Click(object sender, EventArgs e) // Кнопка <Save Change>
        {
            NorthwindDataset.EndInit();
            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
        }
    }
}
