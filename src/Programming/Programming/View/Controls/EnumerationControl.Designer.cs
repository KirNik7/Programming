namespace Programming.View.Controls
{
    partial class EnumerationControl
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
            this.ChooseEnumLabel = new System.Windows.Forms.Label();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChooseEnumLabel
            // 
            this.ChooseEnumLabel.AutoSize = true;
            this.ChooseEnumLabel.Location = new System.Drawing.Point(4, 0);
            this.ChooseEnumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseEnumLabel.Name = "ChooseEnumLabel";
            this.ChooseEnumLabel.Size = new System.Drawing.Size(121, 15);
            this.ChooseEnumLabel.TabIndex = 7;
            this.ChooseEnumLabel.Text = "Choose enumeration:";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(368, 0);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 11;
            this.IntValueLabel.Text = "Int value:";
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.ItemHeight = 15;
            this.EnumListBox.Location = new System.Drawing.Point(4, 18);
            this.EnumListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(174, 229);
            this.EnumListBox.TabIndex = 6;
            this.EnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(368, 18);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(107, 23);
            this.IntValueTextBox.TabIndex = 10;
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.ItemHeight = 15;
            this.ValueListBox.Location = new System.Drawing.Point(186, 18);
            this.ValueListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(174, 229);
            this.ValueListBox.TabIndex = 8;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(186, 0);
            this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ChooseValueLabel.TabIndex = 9;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // EnumerationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChooseEnumLabel);
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.EnumListBox);
            this.Controls.Add(this.IntValueTextBox);
            this.Controls.Add(this.ValueListBox);
            this.Controls.Add(this.ChooseValueLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EnumerationControl";
            this.Size = new System.Drawing.Size(479, 251);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseEnumLabel;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.Label ChooseValueLabel;
    }
}
