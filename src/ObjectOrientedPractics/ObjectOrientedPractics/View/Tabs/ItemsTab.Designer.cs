namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ItemsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.ItemIDLabel = new System.Windows.Forms.Label();
            this.ItemCostLabel = new System.Windows.Forms.Label();
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.ItemCostTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ItemInfoLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).BeginInit();
            this.ItemsSplitContainer.Panel1.SuspendLayout();
            this.ItemsSplitContainer.Panel2.SuspendLayout();
            this.ItemsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(197, 404);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(37, 13);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 36);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(237, 381);
            this.ItemsListBox.TabIndex = 1;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(47, 341);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 37);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(128, 341);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(76, 37);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ItemsSplitContainer
            // 
            this.ItemsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ItemsSplitContainer.Name = "ItemsSplitContainer";
            // 
            // ItemsSplitContainer.Panel1
            // 
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ItemsListBox);
            // 
            // ItemsSplitContainer.Panel2
            // 
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemsLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.AddItemButton);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.textBox4);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.RemoveItemButton);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemInfoLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.textBox3);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemNameLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemCostTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemIDTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemCostLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemIDLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.SelectedItemLabel);
            this.ItemsSplitContainer.Size = new System.Drawing.Size(553, 448);
            this.ItemsSplitContainer.SplitterDistance = 245;
            this.ItemsSplitContainer.TabIndex = 4;
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(85, 13);
            this.SelectedItemLabel.TabIndex = 0;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(3, 20);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(21, 13);
            this.ItemIDLabel.TabIndex = 1;
            this.ItemIDLabel.Text = "ID:";
            // 
            // ItemCostLabel
            // 
            this.ItemCostLabel.AutoSize = true;
            this.ItemCostLabel.Location = new System.Drawing.Point(3, 46);
            this.ItemCostLabel.Name = "ItemCostLabel";
            this.ItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.ItemCostLabel.TabIndex = 2;
            this.ItemCostLabel.Text = "Cost:";
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Location = new System.Drawing.Point(40, 17);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemIDTextBox.TabIndex = 3;
            // 
            // ItemCostTextBox
            // 
            this.ItemCostTextBox.Location = new System.Drawing.Point(40, 43);
            this.ItemCostTextBox.Name = "ItemCostTextBox";
            this.ItemCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemCostTextBox.TabIndex = 4;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(3, 73);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ItemNameLabel.TabIndex = 5;
            this.ItemNameLabel.Text = "Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 89);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(294, 77);
            this.textBox3.TabIndex = 6;
            // 
            // ItemInfoLabel
            // 
            this.ItemInfoLabel.AutoSize = true;
            this.ItemInfoLabel.Location = new System.Drawing.Point(3, 169);
            this.ItemInfoLabel.Name = "ItemInfoLabel";
            this.ItemInfoLabel.Size = new System.Drawing.Size(63, 13);
            this.ItemInfoLabel.TabIndex = 7;
            this.ItemInfoLabel.Text = "Description:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 185);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(294, 139);
            this.textBox4.TabIndex = 8;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsSplitContainer);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(553, 448);
            this.ItemsSplitContainer.Panel1.ResumeLayout(false);
            this.ItemsSplitContainer.Panel2.ResumeLayout(false);
            this.ItemsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).EndInit();
            this.ItemsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.SplitContainer ItemsSplitContainer;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ItemInfoLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox ItemCostTextBox;
        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.Label ItemCostLabel;
        private System.Windows.Forms.Label ItemIDLabel;
    }
}
