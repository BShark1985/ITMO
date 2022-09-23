using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace MyAppForDB
{
    public partial class LoginForm : Form
    {
        DataBase dataBase = new DataBase();
        public LoginForm()
        {
            InitializeComponent();
        }

        public void buttonEnter_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

            connectionStringBuilder.DataSource = @".\MSSQLEXPRESS";
            connectionStringBuilder.InitialCatalog = "LeontevDBforCSApp";
            connectionStringBuilder.UserID = textBoxLogin.Text;                 // login: leontiev
            connectionStringBuilder.Password = textBoxPassword.Text;            // password: Pikerm@1

            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Вы успешно вошли в " + connection.Database, "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OperatingForm operatingForm = new OperatingForm();
                    this.Hide();
                    operatingForm.ShowDialog();
                    this.Show();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

    }
}
