namespace ProductsApp.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.ProductGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductInStockLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductManufacturerLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ProductInStockTextBox = new System.Windows.Forms.TextBox();
            this.ProductManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(12, 38);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(235, 329);
            this.ProductsListBox.TabIndex = 0;
            this.ProductsListBox.SelectedIndexChanged += new System.EventHandler(this.ProductsListBox_SelectedIndexChanged);
            // 
            // ProductGroupBox
            // 
            this.ProductGroupBox.Controls.Add(this.ProductInStockLabel);
            this.ProductGroupBox.Controls.Add(this.ProductCategoryLabel);
            this.ProductGroupBox.Controls.Add(this.ProductManufacturerLabel);
            this.ProductGroupBox.Controls.Add(this.ProductNameLabel);
            this.ProductGroupBox.Controls.Add(this.ProductCategoryComboBox);
            this.ProductGroupBox.Controls.Add(this.ProductInStockTextBox);
            this.ProductGroupBox.Controls.Add(this.ProductManufacturerTextBox);
            this.ProductGroupBox.Controls.Add(this.ProductNameTextBox);
            this.ProductGroupBox.Location = new System.Drawing.Point(253, 38);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.Size = new System.Drawing.Size(535, 127);
            this.ProductGroupBox.TabIndex = 1;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Selected Product";
            // 
            // ProductInStockLabel
            // 
            this.ProductInStockLabel.AutoSize = true;
            this.ProductInStockLabel.Location = new System.Drawing.Point(36, 101);
            this.ProductInStockLabel.Name = "ProductInStockLabel";
            this.ProductInStockLabel.Size = new System.Drawing.Size(48, 13);
            this.ProductInStockLabel.TabIndex = 7;
            this.ProductInStockLabel.Text = "In stock:";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Location = new System.Drawing.Point(32, 74);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.ProductCategoryLabel.TabIndex = 6;
            this.ProductCategoryLabel.Text = "Category:";
            // 
            // ProductManufacturerLabel
            // 
            this.ProductManufacturerLabel.AutoSize = true;
            this.ProductManufacturerLabel.Location = new System.Drawing.Point(11, 48);
            this.ProductManufacturerLabel.Name = "ProductManufacturerLabel";
            this.ProductManufacturerLabel.Size = new System.Drawing.Size(73, 13);
            this.ProductManufacturerLabel.TabIndex = 5;
            this.ProductManufacturerLabel.Text = "Manufacturer:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(46, 22);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Name:";
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(90, 71);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(168, 21);
            this.ProductCategoryComboBox.TabIndex = 3;
            this.ProductCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductCategoryComboBox_SelectedIndexChanged);
            // 
            // ProductInStockTextBox
            // 
            this.ProductInStockTextBox.Location = new System.Drawing.Point(90, 98);
            this.ProductInStockTextBox.Name = "ProductInStockTextBox";
            this.ProductInStockTextBox.Size = new System.Drawing.Size(168, 20);
            this.ProductInStockTextBox.TabIndex = 2;
            this.ProductInStockTextBox.TextChanged += new System.EventHandler(this.ProductInStockTextBox_TextChanged);
            // 
            // ProductManufacturerTextBox
            // 
            this.ProductManufacturerTextBox.Location = new System.Drawing.Point(90, 45);
            this.ProductManufacturerTextBox.Name = "ProductManufacturerTextBox";
            this.ProductManufacturerTextBox.Size = new System.Drawing.Size(439, 20);
            this.ProductManufacturerTextBox.TabIndex = 1;
            this.ProductManufacturerTextBox.TextChanged += new System.EventHandler(this.ProductManufacturerTextBox_TextChanged);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(90, 19);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(439, 20);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Image = global::ProductsApp.Properties.Resources.add_24x24;
            this.AddPictureBox.Location = new System.Drawing.Point(12, 373);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(39, 39);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPictureBox.TabIndex = 2;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            this.AddPictureBox.MouseEnter += new System.EventHandler(this.AddPictureBox_MouseEnter);
            this.AddPictureBox.MouseLeave += new System.EventHandler(this.AddPictureBox_MouseLeave);
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.Image = global::ProductsApp.Properties.Resources.cross_circle_24x24;
            this.RemovePictureBox.Location = new System.Drawing.Point(57, 373);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(39, 39);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemovePictureBox.TabIndex = 3;
            this.RemovePictureBox.TabStop = false;
            this.RemovePictureBox.Click += new System.EventHandler(this.RemovePictureBox_Click);
            this.RemovePictureBox.MouseEnter += new System.EventHandler(this.RemovePictureBox_MouseEnter);
            this.RemovePictureBox.MouseLeave += new System.EventHandler(this.RemovePictureBox_MouseLeave);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(12, 15);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(62, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(185, 20);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.RemovePictureBox);
            this.Controls.Add(this.AddPictureBox);
            this.Controls.Add(this.ProductGroupBox);
            this.Controls.Add(this.ProductsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ProductsApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ProductGroupBox.ResumeLayout(false);
            this.ProductGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.Label ProductInStockLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductManufacturerLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.TextBox ProductInStockTextBox;
        private System.Windows.Forms.TextBox ProductManufacturerTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.PictureBox RemovePictureBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}

