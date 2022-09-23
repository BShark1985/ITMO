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

namespace MyAppForDB
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class OperatingForm : Form
    {
        DataBase dataBase = new DataBase();
        public OperatingForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()  // создаем поля таблицы COMPANIES
        {
            dataGridView1.Columns.Add("CompanyID", "Код компании");
            dataGridView1.Columns.Add("CompanyName", "Наименование компании");            
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1));
        }
        private void RefreshDataGrid(DataGridView dgw)  // для вывода таблицы COMPANIES на экран
        {
            dgw.Rows.Clear();
            string queryString = $"select * from [dbo].[Companies]";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();            
        }
        private void ClearDataGridView()  // очищаем поле DataGridView во вкладке COMPANIES
        {
            this.dataGridView1.Rows.Clear();  // удаление всех строк
            int count = this.dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                this.dataGridView1.Columns.RemoveAt(0);
            }
        }



        private void OperatingForm_Load(object sender, EventArgs e)
        {
            
        }

        private void selectButton_Click(object sender, EventArgs e)  // ПОКАЗЫВАЕМ или ОБНОВЛЯЕМ отображение таблицы COMPANIES
        {
            ClearDataGridView();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        
        private void insertButton_Click(object sender, EventArgs e) // ВСТАВКА новой строки в COMPANIES
        {
            dataBase.openConnection();

            int companyID;
            var companyName = textBoxCompanyName.Text;

            if(int.TryParse(textBoxCompanyID.Text, out companyID))
            {
                var addQuery = $"insert into [dbo].[Companies] (CompanyID, CompanyName) values ('{companyID}', '{companyName}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Код компании должен иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataBase.closeConnection();
        }

        private void deleteButton_Click(object sender, EventArgs e)  // УДАЛЕНИЕ строки в COMPANIES
        {
            dataBase.openConnection();

            int companyID;
            var companyName = textBoxCompanyName;

            if (int.TryParse(textBoxCompanyID.Text, out companyID))
            {
                var deleteQuery = $"delete from [dbo].[Companies] where CompanyID = {companyID}";

                var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Код компании должен иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataBase.closeConnection();
        }
                
        private void alterButton_Click(object sender, EventArgs e)  // ИЗМЕНЕНИЕ строки в COMPANIES
        {
            dataBase.openConnection();

            int companyID;
            var companyName = textBoxCompanyName.Text;

            if (int.TryParse(textBoxCompanyID.Text, out companyID))
            {
                var updateQuery = $"update [dbo].[Companies] set CompanyName = '{companyName}' where CompanyID = {companyID}";

                var command = new SqlCommand(updateQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Код компании должен иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataBase.closeConnection();
        }


        // Работа с вкладкой ITEMS \/\/\/\/\/


        private void ReadSingleRowItems(DataGridView dgw2, IDataRecord record)
        {
            dgw2.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3));
        }
        private void RefreshDataGridItems(DataGridView dgw2)  // для вывода таблицы ITEMS на экран
        {
            dgw2.Rows.Clear();
            string queryString = $"select * from [dbo].[Items]";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowItems(dgw2, reader);
            }
            reader.Close();
        }
        private void ClearDataGridViewItem()  // очищаем поле DataGridView во вкладке Items
        {
            this.dataGridView2.Rows.Clear();  // удаление всех строк
            int count = this.dataGridView2.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                this.dataGridView2.Columns.RemoveAt(0);
            }
        }
        private void selectItemsButton_Click(object sender, EventArgs e)
        {
            ClearDataGridViewItem();
            dataGridView2.Columns.Add("ItemsID", "Код продукта");
            dataGridView2.Columns.Add("ItemsName", "Наименование продукта");
            dataGridView2.Columns.Add("ItemsPrice", "Цена продукта");
            dataGridView2.Columns.Add("ItemsCategory", "Категория продукта");            
            RefreshDataGridItems(dataGridView2);
        }

        private void insertItemsButton_Click(object sender, EventArgs e)  // ВСТАВКА новой строки в ITEMS
        {
            dataBase.openConnection();

            int itemID;
            var itemName = textBoxItemName.Text;
            int itemPrice;
            var itemCategory = textBoxItemCategory.Text;


            if (int.TryParse(textBoxItemID.Text, out itemID))
            {
                if (int.TryParse(textBoxItemPrice.Text, out itemPrice))
                {
                    var addItemsQuery = $"insert into [dbo].[Items] (ItemsID, ItemsName, ItemsPrice, ItemsCategory) values ('{itemID}', '{itemName}', '{itemPrice}', '{itemCategory}')";

                    var command = new SqlCommand(addItemsQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Цена продукта должна иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Код продукта должен иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataBase.closeConnection();
        }

        private void deleteItemsButton_Click(object sender, EventArgs e)  // УДАЛЕНИЕ строки в ITEMS
        {
            dataBase.openConnection();

            int itemID;

            if (int.TryParse(textBoxItemID.Text, out itemID))
            {
                var deleteItemQuery = $"delete from [dbo].[Items] where ItemsID = {itemID}";

                var command = new SqlCommand(deleteItemQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Код товара должен иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataBase.closeConnection();
        }

        private void updateItemsButton_Click(object sender, EventArgs e)  // ИЗМЕНЕНИЕ строки в ITEMS
        {
            dataBase.openConnection();

            int itemID;
            var itemName = textBoxItemName.Text;
            int itemPrice;
            var itemCategory = textBoxItemCategory.Text;

            if (int.TryParse(textBoxItemID.Text, out itemID))
            {
                if (int.TryParse(textBoxItemPrice.Text, out itemPrice))
                {
                    var updateItemsQuery = $"update [dbo].[Items] set ItemsName = '{itemName}', ItemsPrice = '{itemPrice}', ItemsCategory = '{itemCategory}' where ItemsID = {itemID}";

                    var command = new SqlCommand(updateItemsQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Цена продукта должна иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Код продукта должен иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataBase.closeConnection();
        }
    }
}
