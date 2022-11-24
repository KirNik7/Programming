namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.components = new System.ComponentModel.Container();
            ObjectOrientedPractics.Model.Address address2 = new ObjectOrientedPractics.Model.Address();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderStatusLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderIdLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextLabel = new System.Windows.Forms.Label();
            this.OrderIdTextBox = new System.Windows.Forms.TextBox();
            this.OrderDateTextBox = new System.Windows.Forms.TextBox();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrdersLabel.Location = new System.Drawing.Point(3, 0);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(45, 15);
            this.OrdersLabel.TabIndex = 0;
            this.OrdersLabel.Text = "Orders";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(ObjectOrientedPractics.Model.Customer);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.customerBindingSource;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(ObjectOrientedPractics.Model.Customer);
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataSource = typeof(ObjectOrientedPractics.Model.Customer);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ObjectOrientedPractics.Model.Order);
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.AutoGenerateColumns = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.OrdersDataGridView.DataSource = this.ordersBindingSource;
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 18);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowTemplate.Height = 25;
            this.OrdersDataGridView.Size = new System.Drawing.Size(500, 543);
            this.OrdersDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Customer Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataSource = typeof(ObjectOrientedPractics.Model.Store);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.storeBindingSource;
            // 
            // storeBindingSource1
            // 
            this.storeBindingSource1.DataSource = typeof(ObjectOrientedPractics.Model.Store);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.storeBindingSource1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OrdersDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.OrdersLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OrderStatusComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.OrderDateTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.OrderIdTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.AmountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.AmountTextLabel);
            this.splitContainer1.Panel2.Controls.Add(this.OrderItemsListBox);
            this.splitContainer1.Panel2.Controls.Add(this.OrderAddressControl);
            this.splitContainer1.Panel2.Controls.Add(this.OrderItemsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.OrderStatusLabel);
            this.splitContainer1.Panel2.Controls.Add(this.OrderDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.OrderIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SelectedOrderLabel);
            this.splitContainer1.Size = new System.Drawing.Size(1049, 564);
            this.splitContainer1.SplitterDistance = 506;
            this.splitContainer1.TabIndex = 2;
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 15;
            this.OrderItemsListBox.Location = new System.Drawing.Point(3, 278);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(533, 139);
            this.OrderItemsListBox.TabIndex = 10;
            // 
            // OrderAddressControl
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 100000;
            address2.Street = "";
            this.OrderAddressControl.Address = address2;
            this.OrderAddressControl.Location = new System.Drawing.Point(-1, 108);
            this.OrderAddressControl.Name = "OrderAddressControl";
            this.OrderAddressControl.Size = new System.Drawing.Size(519, 138);
            this.OrderAddressControl.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderItemsLabel.Location = new System.Drawing.Point(3, 260);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(75, 15);
            this.OrderItemsLabel.TabIndex = 5;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // OrderStatusLabel
            // 
            this.OrderStatusLabel.AutoSize = true;
            this.OrderStatusLabel.Location = new System.Drawing.Point(3, 82);
            this.OrderStatusLabel.Name = "OrderStatusLabel";
            this.OrderStatusLabel.Size = new System.Drawing.Size(42, 15);
            this.OrderStatusLabel.TabIndex = 4;
            this.OrderStatusLabel.Text = "Status:";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(3, 53);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(51, 15);
            this.OrderDateLabel.TabIndex = 3;
            this.OrderDateLabel.Text = "Created:";
            // 
            // OrderIdLabel
            // 
            this.OrderIdLabel.AutoSize = true;
            this.OrderIdLabel.Location = new System.Drawing.Point(3, 24);
            this.OrderIdLabel.Name = "OrderIdLabel";
            this.OrderIdLabel.Size = new System.Drawing.Size(21, 15);
            this.OrderIdLabel.TabIndex = 2;
            this.OrderIdLabel.Text = "ID:";
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(92, 15);
            this.SelectedOrderLabel.TabIndex = 1;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(3, 435);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmountLabel.Size = new System.Drawing.Size(533, 35);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "0,00";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountTextLabel
            // 
            this.AmountTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountTextLabel.Location = new System.Drawing.Point(3, 420);
            this.AmountTextLabel.Name = "AmountTextLabel";
            this.AmountTextLabel.Size = new System.Drawing.Size(533, 15);
            this.AmountTextLabel.TabIndex = 11;
            this.AmountTextLabel.Text = "Amount:";
            this.AmountTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderIdTextBox
            // 
            this.OrderIdTextBox.Location = new System.Drawing.Point(78, 21);
            this.OrderIdTextBox.Name = "OrderIdTextBox";
            this.OrderIdTextBox.Size = new System.Drawing.Size(121, 23);
            this.OrderIdTextBox.TabIndex = 13;
            // 
            // OrderDateTextBox
            // 
            this.OrderDateTextBox.Location = new System.Drawing.Point(78, 50);
            this.OrderDateTextBox.Name = "OrderDateTextBox";
            this.OrderDateTextBox.Size = new System.Drawing.Size(121, 23);
            this.OrderDateTextBox.TabIndex = 14;
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Location = new System.Drawing.Point(78, 79);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(121, 23);
            this.OrderStatusComboBox.TabIndex = 15;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "Order Status";
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Delivery Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Created";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1049, 564);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource storeBindingSource1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private Controls.AddressControl OrderAddressControl;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.TextBox OrderDateTextBox;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountTextLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
    }
}
