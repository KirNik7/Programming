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
            this.RemoveProductImagePictureBox = new System.Windows.Forms.PictureBox();
            this.AddProductImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ProductCountInStockLabel = new System.Windows.Forms.Label();
            this.ProductImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductManufacturerLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ProductCountInStockTextBox = new System.Windows.Forms.TextBox();
            this.ProductManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.ProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveProductImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(12, 12);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(235, 277);
            this.ProductsListBox.TabIndex = 0;
            this.ProductsListBox.SelectedIndexChanged += new System.EventHandler(this.ProductsListBox_SelectedIndexChanged);
            // 
            // ProductGroupBox
            // 
            this.ProductGroupBox.Controls.Add(this.RemoveProductImagePictureBox);
            this.ProductGroupBox.Controls.Add(this.AddProductImagePictureBox);
            this.ProductGroupBox.Controls.Add(this.ProductCountInStockLabel);
            this.ProductGroupBox.Controls.Add(this.ProductImagePictureBox);
            this.ProductGroupBox.Controls.Add(this.ProductCategoryLabel);
            this.ProductGroupBox.Controls.Add(this.ProductManufacturerLabel);
            this.ProductGroupBox.Controls.Add(this.ProductNameLabel);
            this.ProductGroupBox.Controls.Add(this.ProductCategoryComboBox);
            this.ProductGroupBox.Controls.Add(this.ProductCountInStockTextBox);
            this.ProductGroupBox.Controls.Add(this.ProductManufacturerTextBox);
            this.ProductGroupBox.Controls.Add(this.ProductNameTextBox);
            this.ProductGroupBox.Location = new System.Drawing.Point(253, 12);
            this.ProductGroupBox.Name = "ProductGroupBox";
            this.ProductGroupBox.Size = new System.Drawing.Size(397, 274);
            this.ProductGroupBox.TabIndex = 1;
            this.ProductGroupBox.TabStop = false;
            this.ProductGroupBox.Text = "Selected Product";
            // 
            // RemoveProductImagePictureBox
            // 
            this.RemoveProductImagePictureBox.Image = global::ProductsApp.Properties.Resources.remove_image_32x32;
            this.RemoveProductImagePictureBox.Location = new System.Drawing.Point(351, 227);
            this.RemoveProductImagePictureBox.Name = "RemoveProductImagePictureBox";
            this.RemoveProductImagePictureBox.Size = new System.Drawing.Size(39, 39);
            this.RemoveProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveProductImagePictureBox.TabIndex = 9;
            this.RemoveProductImagePictureBox.TabStop = false;
            this.RemoveProductImagePictureBox.Click += new System.EventHandler(this.RemoveProductImagePictureBox_Click);
            this.RemoveProductImagePictureBox.MouseEnter += new System.EventHandler(this.RemoveProductImagePictureBox_MouseEnter);
            this.RemoveProductImagePictureBox.MouseLeave += new System.EventHandler(this.RemoveProductImagePictureBox_MouseLeave);
            // 
            // AddProductImagePictureBox
            // 
            this.AddProductImagePictureBox.Image = global::ProductsApp.Properties.Resources.add_image_32x32;
            this.AddProductImagePictureBox.ImageLocation = "";
            this.AddProductImagePictureBox.Location = new System.Drawing.Point(306, 227);
            this.AddProductImagePictureBox.Name = "AddProductImagePictureBox";
            this.AddProductImagePictureBox.Size = new System.Drawing.Size(39, 39);
            this.AddProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddProductImagePictureBox.TabIndex = 8;
            this.AddProductImagePictureBox.TabStop = false;
            this.AddProductImagePictureBox.Click += new System.EventHandler(this.AddProductImagePictureBox_Click);
            this.AddProductImagePictureBox.MouseEnter += new System.EventHandler(this.AddProductImagePictureBox_MouseEnter);
            this.AddProductImagePictureBox.MouseLeave += new System.EventHandler(this.AddProductImagePictureBox_MouseLeave);
            // 
            // ProductCountInStockLabel
            // 
            this.ProductCountInStockLabel.AutoSize = true;
            this.ProductCountInStockLabel.Location = new System.Drawing.Point(6, 74);
            this.ProductCountInStockLabel.Name = "ProductCountInStockLabel";
            this.ProductCountInStockLabel.Size = new System.Drawing.Size(78, 13);
            this.ProductCountInStockLabel.TabIndex = 7;
            this.ProductCountInStockLabel.Text = "Count in stock:";
            // 
            // ProductImagePictureBox
            // 
            this.ProductImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductImagePictureBox.Location = new System.Drawing.Point(240, 71);
            this.ProductImagePictureBox.Name = "ProductImagePictureBox";
            this.ProductImagePictureBox.Size = new System.Drawing.Size(150, 150);
            this.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImagePictureBox.TabIndex = 5;
            this.ProductImagePictureBox.TabStop = false;
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Location = new System.Drawing.Point(32, 100);
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
            this.ProductCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(90, 97);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(144, 21);
            this.ProductCategoryComboBox.TabIndex = 3;
            this.ProductCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductCategoryComboBox_SelectedIndexChanged);
            // 
            // ProductCountInStockTextBox
            // 
            this.ProductCountInStockTextBox.Location = new System.Drawing.Point(90, 71);
            this.ProductCountInStockTextBox.Name = "ProductCountInStockTextBox";
            this.ProductCountInStockTextBox.Size = new System.Drawing.Size(144, 20);
            this.ProductCountInStockTextBox.TabIndex = 2;
            this.ProductCountInStockTextBox.TextChanged += new System.EventHandler(this.ProductInStockTextBox_TextChanged);
            // 
            // ProductManufacturerTextBox
            // 
            this.ProductManufacturerTextBox.Location = new System.Drawing.Point(90, 45);
            this.ProductManufacturerTextBox.Name = "ProductManufacturerTextBox";
            this.ProductManufacturerTextBox.Size = new System.Drawing.Size(300, 20);
            this.ProductManufacturerTextBox.TabIndex = 1;
            this.ProductManufacturerTextBox.TextChanged += new System.EventHandler(this.ProductManufacturerTextBox_TextChanged);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(90, 19);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(300, 20);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Image = global::ProductsApp.Properties.Resources.add_24x24;
            this.AddPictureBox.Location = new System.Drawing.Point(12, 295);
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
            this.RemovePictureBox.Location = new System.Drawing.Point(57, 295);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(39, 39);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemovePictureBox.TabIndex = 3;
            this.RemovePictureBox.TabStop = false;
            this.RemovePictureBox.Click += new System.EventHandler(this.RemovePictureBox_Click);
            this.RemovePictureBox.MouseEnter += new System.EventHandler(this.RemovePictureBox_MouseEnter);
            this.RemovePictureBox.MouseLeave += new System.EventHandler(this.RemovePictureBox_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 346);
            this.Controls.Add(this.RemovePictureBox);
            this.Controls.Add(this.AddPictureBox);
            this.Controls.Add(this.ProductGroupBox);
            this.Controls.Add(this.ProductsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ProductGroupBox.ResumeLayout(false);
            this.ProductGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveProductImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.GroupBox ProductGroupBox;
        private System.Windows.Forms.Label ProductCountInStockLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductManufacturerLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.TextBox ProductCountInStockTextBox;
        private System.Windows.Forms.TextBox ProductManufacturerTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.PictureBox RemovePictureBox;
        private System.Windows.Forms.PictureBox ProductImagePictureBox;
        private System.Windows.Forms.PictureBox RemoveProductImagePictureBox;
        private System.Windows.Forms.PictureBox AddProductImagePictureBox;
    }
}

