namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressIndexTextBox = new System.Windows.Forms.TextBox();
            this.AddressCountryTextBox = new System.Windows.Forms.TextBox();
            this.AddressCityTextBox = new System.Windows.Forms.TextBox();
            this.AddressIndexLabel = new System.Windows.Forms.Label();
            this.AddressCountryLabel = new System.Windows.Forms.Label();
            this.AddressCityLabel = new System.Windows.Forms.Label();
            this.AddressStreetLabel = new System.Windows.Forms.Label();
            this.AddressStreetTextBox = new System.Windows.Forms.TextBox();
            this.AddressBuildingTextBox = new System.Windows.Forms.TextBox();
            this.AddressApartmentTextBox = new System.Windows.Forms.TextBox();
            this.AddressBuildingLabel = new System.Windows.Forms.Label();
            this.AddressApartmentLabel = new System.Windows.Forms.Label();
            this.AddressControlToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.Location = new System.Drawing.Point(3, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(101, 15);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Delivery Address";
            // 
            // AddressIndexTextBox
            // 
            this.AddressIndexTextBox.Location = new System.Drawing.Point(72, 18);
            this.AddressIndexTextBox.Name = "AddressIndexTextBox";
            this.AddressIndexTextBox.Size = new System.Drawing.Size(122, 23);
            this.AddressIndexTextBox.TabIndex = 1;
            this.AddressIndexTextBox.TextChanged += new System.EventHandler(this.AddressIndexTextBox_TextChanged);
            // 
            // AddressCountryTextBox
            // 
            this.AddressCountryTextBox.Location = new System.Drawing.Point(72, 47);
            this.AddressCountryTextBox.Name = "AddressCountryTextBox";
            this.AddressCountryTextBox.Size = new System.Drawing.Size(186, 23);
            this.AddressCountryTextBox.TabIndex = 2;
            this.AddressCountryTextBox.TextChanged += new System.EventHandler(this.AddressCountryTextBox_TextChanged);
            // 
            // AddressCityTextBox
            // 
            this.AddressCityTextBox.Location = new System.Drawing.Point(325, 47);
            this.AddressCityTextBox.Name = "AddressCityTextBox";
            this.AddressCityTextBox.Size = new System.Drawing.Size(186, 23);
            this.AddressCityTextBox.TabIndex = 3;
            this.AddressCityTextBox.TextChanged += new System.EventHandler(this.AddressCityTextBox_TextChanged);
            // 
            // AddressIndexLabel
            // 
            this.AddressIndexLabel.AutoSize = true;
            this.AddressIndexLabel.Location = new System.Drawing.Point(3, 21);
            this.AddressIndexLabel.Name = "AddressIndexLabel";
            this.AddressIndexLabel.Size = new System.Drawing.Size(64, 15);
            this.AddressIndexLabel.TabIndex = 4;
            this.AddressIndexLabel.Text = "Post Index:";
            // 
            // AddressCountryLabel
            // 
            this.AddressCountryLabel.AutoSize = true;
            this.AddressCountryLabel.Location = new System.Drawing.Point(3, 50);
            this.AddressCountryLabel.Name = "AddressCountryLabel";
            this.AddressCountryLabel.Size = new System.Drawing.Size(53, 15);
            this.AddressCountryLabel.TabIndex = 5;
            this.AddressCountryLabel.Text = "Country:";
            // 
            // AddressCityLabel
            // 
            this.AddressCityLabel.AutoSize = true;
            this.AddressCityLabel.Location = new System.Drawing.Point(281, 50);
            this.AddressCityLabel.Name = "AddressCityLabel";
            this.AddressCityLabel.Size = new System.Drawing.Size(31, 15);
            this.AddressCityLabel.TabIndex = 6;
            this.AddressCityLabel.Text = "City:";
            // 
            // AddressStreetLabel
            // 
            this.AddressStreetLabel.AutoSize = true;
            this.AddressStreetLabel.Location = new System.Drawing.Point(3, 79);
            this.AddressStreetLabel.Name = "AddressStreetLabel";
            this.AddressStreetLabel.Size = new System.Drawing.Size(40, 15);
            this.AddressStreetLabel.TabIndex = 7;
            this.AddressStreetLabel.Text = "Street:";
            // 
            // AddressStreetTextBox
            // 
            this.AddressStreetTextBox.Location = new System.Drawing.Point(72, 76);
            this.AddressStreetTextBox.Name = "AddressStreetTextBox";
            this.AddressStreetTextBox.Size = new System.Drawing.Size(439, 23);
            this.AddressStreetTextBox.TabIndex = 8;
            this.AddressStreetTextBox.TextChanged += new System.EventHandler(this.AddressStreetTextBox_TextChanged);
            // 
            // AddressBuildingTextBox
            // 
            this.AddressBuildingTextBox.Location = new System.Drawing.Point(72, 105);
            this.AddressBuildingTextBox.Name = "AddressBuildingTextBox";
            this.AddressBuildingTextBox.Size = new System.Drawing.Size(100, 23);
            this.AddressBuildingTextBox.TabIndex = 9;
            this.AddressBuildingTextBox.TextChanged += new System.EventHandler(this.AddressBuildingTextBox_TextChanged);
            // 
            // AddressApartmentTextBox
            // 
            this.AddressApartmentTextBox.Location = new System.Drawing.Point(276, 105);
            this.AddressApartmentTextBox.Name = "AddressApartmentTextBox";
            this.AddressApartmentTextBox.Size = new System.Drawing.Size(100, 23);
            this.AddressApartmentTextBox.TabIndex = 10;
            this.AddressApartmentTextBox.TextChanged += new System.EventHandler(this.AddressApartmentTextBox_TextChanged);
            // 
            // AddressBuildingLabel
            // 
            this.AddressBuildingLabel.AutoSize = true;
            this.AddressBuildingLabel.Location = new System.Drawing.Point(3, 108);
            this.AddressBuildingLabel.Name = "AddressBuildingLabel";
            this.AddressBuildingLabel.Size = new System.Drawing.Size(54, 15);
            this.AddressBuildingLabel.TabIndex = 11;
            this.AddressBuildingLabel.Text = "Building:";
            // 
            // AddressApartmentLabel
            // 
            this.AddressApartmentLabel.AutoSize = true;
            this.AddressApartmentLabel.Location = new System.Drawing.Point(203, 108);
            this.AddressApartmentLabel.Name = "AddressApartmentLabel";
            this.AddressApartmentLabel.Size = new System.Drawing.Size(67, 15);
            this.AddressApartmentLabel.TabIndex = 12;
            this.AddressApartmentLabel.Text = "Apartment:";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressApartmentLabel);
            this.Controls.Add(this.AddressBuildingLabel);
            this.Controls.Add(this.AddressApartmentTextBox);
            this.Controls.Add(this.AddressBuildingTextBox);
            this.Controls.Add(this.AddressStreetTextBox);
            this.Controls.Add(this.AddressStreetLabel);
            this.Controls.Add(this.AddressCityLabel);
            this.Controls.Add(this.AddressCountryLabel);
            this.Controls.Add(this.AddressIndexLabel);
            this.Controls.Add(this.AddressCityTextBox);
            this.Controls.Add(this.AddressCountryTextBox);
            this.Controls.Add(this.AddressIndexTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(517, 138);
            this.Load += new System.EventHandler(this.AddressControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressIndexTextBox;
        private System.Windows.Forms.TextBox AddressCountryTextBox;
        private System.Windows.Forms.TextBox AddressCityTextBox;
        private System.Windows.Forms.Label AddressIndexLabel;
        private System.Windows.Forms.Label AddressCountryLabel;
        private System.Windows.Forms.Label AddressCityLabel;
        private System.Windows.Forms.Label AddressStreetLabel;
        private System.Windows.Forms.TextBox AddressStreetTextBox;
        private System.Windows.Forms.TextBox AddressBuildingTextBox;
        private System.Windows.Forms.TextBox AddressApartmentTextBox;
        private System.Windows.Forms.Label AddressBuildingLabel;
        private System.Windows.Forms.Label AddressApartmentLabel;
        private System.Windows.Forms.ToolTip AddressControlToolTip;
    }
}
