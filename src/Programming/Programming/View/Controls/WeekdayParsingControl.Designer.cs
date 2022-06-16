namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TryParsingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.AutoSize = true;
            this.OutputWeekdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(4, 44);
            this.OutputWeekdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(0, 15);
            this.OutputWeekdayLabel.TabIndex = 12;
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(266, 16);
            this.ParseWeekdayButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(88, 27);
            this.ParseWeekdayButton.TabIndex = 11;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.ParseWeekdayButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(4, 18);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(255, 23);
            this.WeekdayTextBox.TabIndex = 9;
            // 
            // TryParsingLabel
            // 
            this.TryParsingLabel.AutoSize = true;
            this.TryParsingLabel.Location = new System.Drawing.Point(0, 0);
            this.TryParsingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TryParsingLabel.Name = "TryParsingLabel";
            this.TryParsingLabel.Size = new System.Drawing.Size(127, 15);
            this.TryParsingLabel.TabIndex = 10;
            this.TryParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutputWeekdayLabel);
            this.Controls.Add(this.ParseWeekdayButton);
            this.Controls.Add(this.WeekdayTextBox);
            this.Controls.Add(this.TryParsingLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(354, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label TryParsingLabel;
    }
}
