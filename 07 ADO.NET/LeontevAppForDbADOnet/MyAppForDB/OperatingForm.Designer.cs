namespace MyAppForDB
{
    partial class OperatingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.labelForButtons = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.alterButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.dataEntryPanel = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxCompanyID = new System.Windows.Forms.TextBox();
            this.labelCompanyID = new System.Windows.Forms.Label();
            this.labelForEntry = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteItemsButton = new System.Windows.Forms.Button();
            this.updateItemsButton = new System.Windows.Forms.Button();
            this.insertItemsButton = new System.Windows.Forms.Button();
            this.selectItemsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.textBoxItemCategory = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxItemID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.dataEntryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.buttonsPanel);
            this.tabPage1.Controls.Add(this.dataEntryPanel);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Companies";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonsPanel.Controls.Add(this.labelForButtons);
            this.buttonsPanel.Controls.Add(this.deleteButton);
            this.buttonsPanel.Controls.Add(this.alterButton);
            this.buttonsPanel.Controls.Add(this.insertButton);
            this.buttonsPanel.Controls.Add(this.selectButton);
            this.buttonsPanel.Location = new System.Drawing.Point(504, 328);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(280, 225);
            this.buttonsPanel.TabIndex = 2;
            // 
            // labelForButtons
            // 
            this.labelForButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForButtons.Location = new System.Drawing.Point(3, 0);
            this.labelForButtons.Name = "labelForButtons";
            this.labelForButtons.Size = new System.Drawing.Size(274, 41);
            this.labelForButtons.TabIndex = 4;
            this.labelForButtons.Text = "Кнопки управления\r\nданными в таблице";
            this.labelForButtons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(49, 182);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(185, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "УДАЛИТЬ СТРОКУ";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // alterButton
            // 
            this.alterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.alterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alterButton.ForeColor = System.Drawing.Color.White;
            this.alterButton.Location = new System.Drawing.Point(49, 141);
            this.alterButton.Name = "alterButton";
            this.alterButton.Size = new System.Drawing.Size(185, 23);
            this.alterButton.TabIndex = 2;
            this.alterButton.Text = "ИЗМЕНИТЬ СТРОКУ";
            this.alterButton.UseVisualStyleBackColor = false;
            this.alterButton.Click += new System.EventHandler(this.alterButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.Location = new System.Drawing.Point(49, 99);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(185, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "ВСТАВИТЬ НОВУЮ СТРОКУ";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectButton.ForeColor = System.Drawing.Color.White;
            this.selectButton.Location = new System.Drawing.Point(49, 60);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(185, 23);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "ПОКАЗАТЬ ТАБЛИЦУ";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // dataEntryPanel
            // 
            this.dataEntryPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataEntryPanel.Controls.Add(this.labelCompanyName);
            this.dataEntryPanel.Controls.Add(this.textBoxCompanyName);
            this.dataEntryPanel.Controls.Add(this.textBoxCompanyID);
            this.dataEntryPanel.Controls.Add(this.labelCompanyID);
            this.dataEntryPanel.Controls.Add(this.labelForEntry);
            this.dataEntryPanel.Location = new System.Drawing.Point(9, 328);
            this.dataEntryPanel.Name = "dataEntryPanel";
            this.dataEntryPanel.Size = new System.Drawing.Size(488, 225);
            this.dataEntryPanel.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompanyName.Location = new System.Drawing.Point(18, 99);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(178, 23);
            this.labelCompanyName.TabIndex = 11;
            this.labelCompanyName.Text = "Наименование компании:";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompanyName.Location = new System.Drawing.Point(202, 99);
            this.textBoxCompanyName.Multiline = true;
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(264, 23);
            this.textBoxCompanyName.TabIndex = 8;
            // 
            // textBoxCompanyID
            // 
            this.textBoxCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCompanyID.Location = new System.Drawing.Point(202, 60);
            this.textBoxCompanyID.Multiline = true;
            this.textBoxCompanyID.Name = "textBoxCompanyID";
            this.textBoxCompanyID.Size = new System.Drawing.Size(264, 23);
            this.textBoxCompanyID.TabIndex = 7;
            // 
            // labelCompanyID
            // 
            this.labelCompanyID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompanyID.Location = new System.Drawing.Point(43, 60);
            this.labelCompanyID.Name = "labelCompanyID";
            this.labelCompanyID.Size = new System.Drawing.Size(153, 23);
            this.labelCompanyID.TabIndex = 6;
            this.labelCompanyID.Text = "Код компании:";
            this.labelCompanyID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelForEntry
            // 
            this.labelForEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForEntry.Location = new System.Drawing.Point(-1, 0);
            this.labelForEntry.Name = "labelForEntry";
            this.labelForEntry.Size = new System.Drawing.Size(364, 41);
            this.labelForEntry.TabIndex = 5;
            this.labelForEntry.Text = "Строки для ввода данных таблицы \"Companies\"";
            this.labelForEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.deleteItemsButton);
            this.panel1.Controls.Add(this.updateItemsButton);
            this.panel1.Controls.Add(this.insertItemsButton);
            this.panel1.Controls.Add(this.selectItemsButton);
            this.panel1.Location = new System.Drawing.Point(504, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 225);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кнопки управления\r\nданными в таблице";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteItemsButton
            // 
            this.deleteItemsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteItemsButton.ForeColor = System.Drawing.Color.White;
            this.deleteItemsButton.Location = new System.Drawing.Point(49, 182);
            this.deleteItemsButton.Name = "deleteItemsButton";
            this.deleteItemsButton.Size = new System.Drawing.Size(185, 23);
            this.deleteItemsButton.TabIndex = 3;
            this.deleteItemsButton.Text = "УДАЛИТЬ СТРОКУ";
            this.deleteItemsButton.UseVisualStyleBackColor = false;
            this.deleteItemsButton.Click += new System.EventHandler(this.deleteItemsButton_Click);
            // 
            // updateItemsButton
            // 
            this.updateItemsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updateItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateItemsButton.ForeColor = System.Drawing.Color.White;
            this.updateItemsButton.Location = new System.Drawing.Point(49, 141);
            this.updateItemsButton.Name = "updateItemsButton";
            this.updateItemsButton.Size = new System.Drawing.Size(185, 23);
            this.updateItemsButton.TabIndex = 2;
            this.updateItemsButton.Text = "ИЗМЕНИТЬ СТРОКУ";
            this.updateItemsButton.UseVisualStyleBackColor = false;
            this.updateItemsButton.Click += new System.EventHandler(this.updateItemsButton_Click);
            // 
            // insertItemsButton
            // 
            this.insertItemsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertItemsButton.ForeColor = System.Drawing.Color.White;
            this.insertItemsButton.Location = new System.Drawing.Point(49, 99);
            this.insertItemsButton.Name = "insertItemsButton";
            this.insertItemsButton.Size = new System.Drawing.Size(185, 23);
            this.insertItemsButton.TabIndex = 1;
            this.insertItemsButton.Text = "ВСТАВИТЬ НОВУЮ СТРОКУ";
            this.insertItemsButton.UseVisualStyleBackColor = false;
            this.insertItemsButton.Click += new System.EventHandler(this.insertItemsButton_Click);
            // 
            // selectItemsButton
            // 
            this.selectItemsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectItemsButton.ForeColor = System.Drawing.Color.White;
            this.selectItemsButton.Location = new System.Drawing.Point(49, 60);
            this.selectItemsButton.Name = "selectItemsButton";
            this.selectItemsButton.Size = new System.Drawing.Size(185, 23);
            this.selectItemsButton.TabIndex = 0;
            this.selectItemsButton.Text = "ПОКАЗАТЬ ТАБЛИЦУ";
            this.selectItemsButton.UseVisualStyleBackColor = false;
            this.selectItemsButton.Click += new System.EventHandler(this.selectItemsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxItemPrice);
            this.panel2.Controls.Add(this.textBoxItemCategory);
            this.panel2.Controls.Add(this.textBoxItemName);
            this.panel2.Controls.Add(this.textBoxItemID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(9, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 225);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена продукта:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Категория продукта:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Наименование продукта:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxItemPrice.Location = new System.Drawing.Point(202, 182);
            this.textBoxItemPrice.Multiline = true;
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(264, 23);
            this.textBoxItemPrice.TabIndex = 10;
            // 
            // textBoxItemCategory
            // 
            this.textBoxItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxItemCategory.Location = new System.Drawing.Point(202, 141);
            this.textBoxItemCategory.Multiline = true;
            this.textBoxItemCategory.Name = "textBoxItemCategory";
            this.textBoxItemCategory.Size = new System.Drawing.Size(264, 23);
            this.textBoxItemCategory.TabIndex = 9;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxItemName.Location = new System.Drawing.Point(202, 99);
            this.textBoxItemName.Multiline = true;
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(264, 23);
            this.textBoxItemName.TabIndex = 8;
            // 
            // textBoxItemID
            // 
            this.textBoxItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxItemID.Location = new System.Drawing.Point(202, 60);
            this.textBoxItemID.Multiline = true;
            this.textBoxItemID.Name = "textBoxItemID";
            this.textBoxItemID.Size = new System.Drawing.Size(264, 23);
            this.textBoxItemID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(43, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Код продукта:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(-1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 41);
            this.label8.TabIndex = 5;
            this.label8.Text = "Строки для ввода данных таблицы \"Items\"";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(775, 314);
            this.dataGridView2.TabIndex = 3;
            // 
            // OperatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "OperatingForm";
            this.Text = "OperatingForm";
            this.Load += new System.EventHandler(this.OperatingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.dataEntryPanel.ResumeLayout(false);
            this.dataEntryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button alterButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Panel dataEntryPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelForButtons;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxCompanyID;
        private System.Windows.Forms.Label labelCompanyID;
        private System.Windows.Forms.Label labelForEntry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteItemsButton;
        private System.Windows.Forms.Button updateItemsButton;
        private System.Windows.Forms.Button insertItemsButton;
        private System.Windows.Forms.Button selectItemsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.TextBox textBoxItemCategory;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxItemID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}