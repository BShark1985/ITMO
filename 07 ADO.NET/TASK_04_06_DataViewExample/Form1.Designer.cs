namespace TASK_04_06_DataViewExample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.SetDataViewPropertiesButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.GetOrdersButton = new System.Windows.Forms.Button();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.customersTableAdapter1 = new TASK_04_06_DataViewExample.NORTHWNDDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new TASK_04_06_DataViewExample.NORTHWNDDataSetTableAdapters.OrdersTableAdapter();
            this.northwndDataSet1 = new TASK_04_06_DataViewExample.NORTHWNDDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.CustomersGrid.Location = new System.Drawing.Point(0, 0);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.Size = new System.Drawing.Size(290, 450);
            this.CustomersGrid.TabIndex = 0;
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(296, 12);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(177, 20);
            this.SortTextBox.TabIndex = 1;
            this.SortTextBox.Text = "CustomerID";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(296, 51);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(177, 20);
            this.FilterTextBox.TabIndex = 2;
            this.FilterTextBox.Text = "City = \'London\'";
            // 
            // SetDataViewPropertiesButton
            // 
            this.SetDataViewPropertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetDataViewPropertiesButton.Location = new System.Drawing.Point(296, 94);
            this.SetDataViewPropertiesButton.Name = "SetDataViewPropertiesButton";
            this.SetDataViewPropertiesButton.Size = new System.Drawing.Size(158, 23);
            this.SetDataViewPropertiesButton.TabIndex = 3;
            this.SetDataViewPropertiesButton.Text = "SetDataViewProperties";
            this.SetDataViewPropertiesButton.UseVisualStyleBackColor = true;
            this.SetDataViewPropertiesButton.Click += new System.EventHandler(this.SetDataViewPropertiesButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRowButton.Location = new System.Drawing.Point(296, 133);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(75, 23);
            this.AddRowButton.TabIndex = 4;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // GetOrdersButton
            // 
            this.GetOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetOrdersButton.Location = new System.Drawing.Point(296, 174);
            this.GetOrdersButton.Name = "GetOrdersButton";
            this.GetOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.GetOrdersButton.TabIndex = 5;
            this.GetOrdersButton.Text = "Get Orders";
            this.GetOrdersButton.UseVisualStyleBackColor = true;
            this.GetOrdersButton.Click += new System.EventHandler(this.GetOrdersButton_Click);
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.OrdersGrid.Location = new System.Drawing.Point(493, 0);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.Size = new System.Drawing.Size(307, 450);
            this.OrdersGrid.TabIndex = 6;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // northwndDataSet1
            // 
            this.northwndDataSet1.DataSetName = "NORTHWNDDataSet";
            this.northwndDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.GetOrdersButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.SetDataViewPropertiesButton);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Button SetDataViewPropertiesButton;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button GetOrdersButton;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private NORTHWNDDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NORTHWNDDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private NORTHWNDDataSet northwndDataSet1;
    }
}

