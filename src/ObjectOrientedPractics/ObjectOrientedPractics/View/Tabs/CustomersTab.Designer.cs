namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.CustomersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CustomersButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SelectedCustomerContainer = new System.Windows.Forms.SplitContainer();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.CustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerAddressLabel = new System.Windows.Forms.Label();
            this.CustomerFullNameLabel = new System.Windows.Forms.Label();
            this.CustomerFullNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersSplitContainer)).BeginInit();
            this.CustomersSplitContainer.Panel1.SuspendLayout();
            this.CustomersSplitContainer.Panel2.SuspendLayout();
            this.CustomersSplitContainer.SuspendLayout();
            this.CustomersButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomerContainer)).BeginInit();
            this.SelectedCustomerContainer.Panel1.SuspendLayout();
            this.SelectedCustomerContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersSplitContainer
            // 
            this.CustomersSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.CustomersSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomersSplitContainer.Name = "CustomersSplitContainer";
            // 
            // CustomersSplitContainer.Panel1
            // 
            this.CustomersSplitContainer.Panel1.Controls.Add(this.CustomersButtonsTableLayoutPanel);
            this.CustomersSplitContainer.Panel1.Controls.Add(this.CustomersLabel);
            this.CustomersSplitContainer.Panel1.Controls.Add(this.CustomersListBox);
            // 
            // CustomersSplitContainer.Panel2
            // 
            this.CustomersSplitContainer.Panel2.Controls.Add(this.SelectedCustomerContainer);
            this.CustomersSplitContainer.Size = new System.Drawing.Size(729, 565);
            this.CustomersSplitContainer.SplitterDistance = 361;
            this.CustomersSplitContainer.SplitterWidth = 5;
            this.CustomersSplitContainer.TabIndex = 14;
            // 
            // CustomersButtonsTableLayoutPanel
            // 
            this.CustomersButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersButtonsTableLayoutPanel.ColumnCount = 3;
            this.CustomersButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CustomersButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CustomersButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CustomersButtonsTableLayoutPanel.Controls.Add(this.AddCustomerButton, 0, 0);
            this.CustomersButtonsTableLayoutPanel.Controls.Add(this.RemoveCustomerButton, 1, 0);
            this.CustomersButtonsTableLayoutPanel.Location = new System.Drawing.Point(4, 504);
            this.CustomersButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomersButtonsTableLayoutPanel.Name = "CustomersButtonsTableLayoutPanel";
            this.CustomersButtonsTableLayoutPanel.RowCount = 1;
            this.CustomersButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomersButtonsTableLayoutPanel.Size = new System.Drawing.Size(353, 58);
            this.CustomersButtonsTableLayoutPanel.TabIndex = 13;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCustomerButton.Location = new System.Drawing.Point(4, 3);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(109, 52);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveCustomerButton.Location = new System.Drawing.Point(121, 3);
            this.RemoveCustomerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemoveCustomerButton.Size = new System.Drawing.Size(109, 52);
            this.RemoveCustomerButton.TabIndex = 3;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLabel.Location = new System.Drawing.Point(4, 3);
            this.CustomersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 11;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.IntegralHeight = false;
            this.CustomersListBox.ItemHeight = 15;
            this.CustomersListBox.Location = new System.Drawing.Point(4, 19);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(353, 479);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // SelectedCustomerContainer
            // 
            this.SelectedCustomerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerContainer.Location = new System.Drawing.Point(0, 0);
            this.SelectedCustomerContainer.Name = "SelectedCustomerContainer";
            this.SelectedCustomerContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SelectedCustomerContainer.Panel1
            // 
            this.SelectedCustomerContainer.Panel1.Controls.Add(this.SelectedCustomerLabel);
            this.SelectedCustomerContainer.Panel1.Controls.Add(this.CustomerAddressTextBox);
            this.SelectedCustomerContainer.Panel1.Controls.Add(this.CustomerIDLabel);
            this.SelectedCustomerContainer.Panel1.Controls.Add(this.CustomerAddressLabel);
            this.SelectedCustomerContainer.Panel1.Controls.Add(this.CustomerFullNameLabel);
            this.SelectedCustomerContainer.Panel1.Controls.Add(this.CustomerFullNameTextBox);
            this.SelectedCustomerContainer.Panel1.Controls.Add(this.CustomerIDTextBox);
            this.SelectedCustomerContainer.Size = new System.Drawing.Size(363, 565);
            this.SelectedCustomerContainer.SplitterDistance = 189;
            this.SelectedCustomerContainer.TabIndex = 7;
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(4, 3);
            this.SelectedCustomerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(113, 13);
            this.SelectedCustomerLabel.TabIndex = 0;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // CustomerAddressTextBox
            // 
            this.CustomerAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerAddressTextBox.Location = new System.Drawing.Point(74, 97);
            this.CustomerAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerAddressTextBox.Multiline = true;
            this.CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            this.CustomerAddressTextBox.Size = new System.Drawing.Size(285, 84);
            this.CustomerAddressTextBox.TabIndex = 6;
            this.CustomerAddressTextBox.TextChanged += new System.EventHandler(this.CustomerAddressTextBox_TextChanged);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(4, 34);
            this.CustomerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(21, 15);
            this.CustomerIDLabel.TabIndex = 1;
            this.CustomerIDLabel.Text = "ID:";
            // 
            // CustomerAddressLabel
            // 
            this.CustomerAddressLabel.AutoSize = true;
            this.CustomerAddressLabel.Location = new System.Drawing.Point(4, 97);
            this.CustomerAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerAddressLabel.Name = "CustomerAddressLabel";
            this.CustomerAddressLabel.Size = new System.Drawing.Size(52, 15);
            this.CustomerAddressLabel.TabIndex = 5;
            this.CustomerAddressLabel.Text = "Address:";
            // 
            // CustomerFullNameLabel
            // 
            this.CustomerFullNameLabel.AutoSize = true;
            this.CustomerFullNameLabel.Location = new System.Drawing.Point(4, 64);
            this.CustomerFullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerFullNameLabel.Name = "CustomerFullNameLabel";
            this.CustomerFullNameLabel.Size = new System.Drawing.Size(64, 15);
            this.CustomerFullNameLabel.TabIndex = 2;
            this.CustomerFullNameLabel.Text = "Full Name:";
            // 
            // CustomerFullNameTextBox
            // 
            this.CustomerFullNameTextBox.Location = new System.Drawing.Point(74, 61);
            this.CustomerFullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            this.CustomerFullNameTextBox.Size = new System.Drawing.Size(116, 23);
            this.CustomerFullNameTextBox.TabIndex = 4;
            this.CustomerFullNameTextBox.TextChanged += new System.EventHandler(this.CustomerFullNameTextBox_TextChanged);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(74, 31);
            this.CustomerIDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.ReadOnly = true;
            this.CustomerIDTextBox.Size = new System.Drawing.Size(116, 23);
            this.CustomerIDTextBox.TabIndex = 3;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(729, 565);
            this.CustomersSplitContainer.Panel1.ResumeLayout(false);
            this.CustomersSplitContainer.Panel1.PerformLayout();
            this.CustomersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersSplitContainer)).EndInit();
            this.CustomersSplitContainer.ResumeLayout(false);
            this.CustomersButtonsTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomerContainer.Panel1.ResumeLayout(false);
            this.SelectedCustomerContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomerContainer)).EndInit();
            this.SelectedCustomerContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer CustomersSplitContainer;
        private System.Windows.Forms.TableLayoutPanel CustomersButtonsTableLayoutPanel;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.SplitContainer SelectedCustomerContainer;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.TextBox CustomerAddressTextBox;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label CustomerAddressLabel;
        private System.Windows.Forms.Label CustomerFullNameLabel;
        private System.Windows.Forms.TextBox CustomerFullNameTextBox;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
    }
}
