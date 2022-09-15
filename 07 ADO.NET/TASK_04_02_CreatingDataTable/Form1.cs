using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_04_02_CreatingDataTable
{
    public partial class Form1 : Form
    {
        private DataTable CustomersTable = new DataTable("Customers");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableGrid.DataSource = CustomersTable;

            CustomersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
            CustomersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactName", Type.GetType("System.String"));
            CustomersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Address", Type.GetType("System.String"));
            CustomersTable.Columns.Add("City", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Country", Type.GetType("System.String"));
            CustomersTable.Columns.Add("Phone", Type.GetType("System.String"));

            //DataColumn[] KeyColumns = new DataColumn[1];  //столбец CustomerID как первичный ключ
            //KeyColumns[0] = CustomersTable.Columns["CustomerID"];
            //CustomersTable.PrimaryKey = KeyColumns;

            CustomersTable.Columns["CustomerID"].AllowDBNull = false; // запрещаем NULL
            CustomersTable.Columns["CompanyName"].AllowDBNull = false;
        }

        private void AddRowButton_Click(object sender, EventArgs e)  // Кнопка <AddRow>
        {
            try
            {
                DataRow CustRow = CustomersTable.NewRow();
            Object[] CustRecord =  {"1", "ALFKI", "Alfreds Futterkiste, Maria Anders",
                "Sales Representative", "Obere Str. 57", "Berlin", "Germany", "030-0074321, 030-0076545"};
            CustRow.ItemArray = CustRecord;

            CustomersTable.Rows.Add(CustRow);
        }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.ToString());
            }
}
    }
}
