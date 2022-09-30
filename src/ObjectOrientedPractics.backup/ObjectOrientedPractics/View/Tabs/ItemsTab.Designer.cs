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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ItemInfoTextBox = new System.Windows.Forms.TextBox();
            this.ItemInfoLabel = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemCostTextBox = new System.Windows.Forms.TextBox();
            this.ItemIDTextBox = new System.Windows.Forms.TextBox();
            this.ItemCostLabel = new System.Windows.Forms.Label();
            this.ItemIDLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ItemsButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).BeginInit();
            this.ItemsSplitContainer.Panel1.SuspendLayout();
            this.ItemsSplitContainer.Panel2.SuspendLayout();
            this.ItemsSplitContainer.SuspendLayout();
            this.ItemsButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.IntegralHeight = false;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 19);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(304, 412);
            this.ItemsListBox.TabIndex = 1;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddItemButton.Location = new System.Drawing.Point(3, 3);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(95, 44);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveItemButton.Location = new System.Drawing.Point(104, 3);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemoveItemButton.Size = new System.Drawing.Size(95, 44);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ItemInfoTextBox
            // 
            this.ItemInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemInfoTextBox.Location = new System.Drawing.Point(3, 205);
            this.ItemInfoTextBox.Multiline = true;
            this.ItemInfoTextBox.Name = "ItemInfoTextBox";
            this.ItemInfoTextBox.Size = new System.Drawing.Size(305, 159);
            this.ItemInfoTextBox.TabIndex = 8;
            // 
            // ItemInfoLabel
            // 
            this.ItemInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemInfoLabel.AutoSize = true;
            this.ItemInfoLabel.Location = new System.Drawing.Point(3, 189);
            this.ItemInfoLabel.Name = "ItemInfoLabel";
            this.ItemInfoLabel.Size = new System.Drawing.Size(63, 13);
            this.ItemInfoLabel.TabIndex = 7;
            this.ItemInfoLabel.Text = "Description:";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemNameTextBox.Location = new System.Drawing.Point(3, 101);
            this.ItemNameTextBox.Multiline = true;
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(305, 73);
            this.ItemNameTextBox.TabIndex = 6;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(3, 85);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ItemNameLabel.TabIndex = 5;
            this.ItemNameLabel.Text = "Name:";
            // 
            // ItemCostTextBox
            // 
            this.ItemCostTextBox.Location = new System.Drawing.Point(52, 53);
            this.ItemCostTextBox.Name = "ItemCostTextBox";
            this.ItemCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemCostTextBox.TabIndex = 4;
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Location = new System.Drawing.Point(52, 27);
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemIDTextBox.TabIndex = 3;
            // 
            // ItemCostLabel
            // 
            this.ItemCostLabel.AutoSize = true;
            this.ItemCostLabel.Location = new System.Drawing.Point(3, 56);
            this.ItemCostLabel.Name = "ItemCostLabel";
            this.ItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.ItemCostLabel.TabIndex = 2;
            this.ItemCostLabel.Text = "Cost:";
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(3, 30);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(21, 13);
            this.ItemIDLabel.TabIndex = 1;
            this.ItemIDLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 3);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(85, 13);
            this.SelectedItemLabel.TabIndex = 0;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 3);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(37, 13);
            this.ItemsLabel.TabIndex = 11;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsSplitContainer
            // 
            this.ItemsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ItemsSplitContainer.Name = "ItemsSplitContainer";
            // 
            // ItemsSplitContainer.Panel1
            // 
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ItemsButtonsTableLayoutPanel);
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ItemsLabel);
            this.ItemsSplitContainer.Panel1.Controls.Add(this.ItemsListBox);
            // 
            // ItemsSplitContainer.Panel2
            // 
            this.ItemsSplitContainer.Panel2.Controls.Add(this.SelectedItemLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemIDLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemCostLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemIDTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemCostTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemInfoTextBox);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemNameLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemInfoLabel);
            this.ItemsSplitContainer.Panel2.Controls.Add(this.ItemNameTextBox);
            this.ItemsSplitContainer.Size = new System.Drawing.Size(625, 490);
            this.ItemsSplitContainer.SplitterDistance = 310;
            this.ItemsSplitContainer.TabIndex = 12;
            // 
            // ItemsButtonsTableLayoutPanel
            // 
            this.ItemsButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsButtonsTableLayoutPanel.ColumnCount = 3;
            this.ItemsButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ItemsButtonsTableLayoutPanel.Controls.Add(this.AddItemButton, 0, 0);
            this.ItemsButtonsTableLayoutPanel.Controls.Add(this.RemoveItemButton, 1, 0);
            this.ItemsButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 437);
            this.ItemsButtonsTableLayoutPanel.Name = "ItemsButtonsTableLayoutPanel";
            this.ItemsButtonsTableLayoutPanel.RowCount = 1;
            this.ItemsButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsButtonsTableLayoutPanel.Size = new System.Drawing.Size(304, 50);
            this.ItemsButtonsTableLayoutPanel.TabIndex = 13;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsSplitContainer);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(625, 490);
            this.ItemsSplitContainer.Panel1.ResumeLayout(false);
            this.ItemsSplitContainer.Panel1.PerformLayout();
            this.ItemsSplitContainer.Panel2.ResumeLayout(false);
            this.ItemsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsSplitContainer)).EndInit();
            this.ItemsSplitContainer.ResumeLayout(false);
            this.ItemsButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.TextBox ItemInfoTextBox;
        private System.Windows.Forms.Label ItemInfoLabel;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox ItemCostTextBox;
        private System.Windows.Forms.TextBox ItemIDTextBox;
        private System.Windows.Forms.Label ItemCostLabel;
        private System.Windows.Forms.Label ItemIDLabel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.SplitContainer ItemsSplitContainer;
        private System.Windows.Forms.TableLayoutPanel ItemsButtonsTableLayoutPanel;
    }
}
