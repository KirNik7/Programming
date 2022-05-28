namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangleLabel = new System.Windows.Forms.Label();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.YRectangleLabel = new System.Windows.Forms.Label();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.XRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.RectangleColorLabel = new System.Windows.Forms.Label();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectangleHeightLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.IdRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.YRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.YRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.XRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.XRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleFindButton);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleHeightTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleHeightLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(420, 416);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Location = new System.Drawing.Point(248, 260);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.ReadOnly = true;
            this.IdRectangleTextBox.Size = new System.Drawing.Size(157, 23);
            this.IdRectangleTextBox.TabIndex = 13;
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.AutoSize = true;
            this.IdRectangleLabel.Location = new System.Drawing.Point(248, 242);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(21, 15);
            this.IdRectangleLabel.TabIndex = 12;
            this.IdRectangleLabel.Text = "ID:";
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Location = new System.Drawing.Point(248, 216);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(157, 23);
            this.YRectangleTextBox.TabIndex = 11;
            // 
            // YRectangleLabel
            // 
            this.YRectangleLabel.AutoSize = true;
            this.YRectangleLabel.Location = new System.Drawing.Point(248, 198);
            this.YRectangleLabel.Name = "YRectangleLabel";
            this.YRectangleLabel.Size = new System.Drawing.Size(17, 15);
            this.YRectangleLabel.TabIndex = 10;
            this.YRectangleLabel.Text = "Y:";
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Location = new System.Drawing.Point(248, 172);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(157, 23);
            this.XRectangleTextBox.TabIndex = 9;
            // 
            // XRectangleLabel
            // 
            this.XRectangleLabel.AutoSize = true;
            this.XRectangleLabel.Location = new System.Drawing.Point(248, 154);
            this.XRectangleLabel.Name = "XRectangleLabel";
            this.XRectangleLabel.Size = new System.Drawing.Size(17, 15);
            this.XRectangleLabel.TabIndex = 8;
            this.XRectangleLabel.Text = "X:";
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Location = new System.Drawing.Point(248, 378);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(157, 23);
            this.RectangleFindButton.TabIndex = 7;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(248, 128);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.ReadOnly = true;
            this.RectangleColorTextBox.Size = new System.Drawing.Size(157, 23);
            this.RectangleColorTextBox.TabIndex = 6;
            // 
            // RectangleColorLabel
            // 
            this.RectangleColorLabel.AutoSize = true;
            this.RectangleColorLabel.Location = new System.Drawing.Point(248, 110);
            this.RectangleColorLabel.Name = "RectangleColorLabel";
            this.RectangleColorLabel.Size = new System.Drawing.Size(39, 15);
            this.RectangleColorLabel.TabIndex = 5;
            this.RectangleColorLabel.Text = "Color:";
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(248, 84);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(157, 23);
            this.RectangleWidthTextBox.TabIndex = 4;
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(248, 66);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(42, 15);
            this.RectangleWidthLabel.TabIndex = 3;
            this.RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleHeightTextBox
            // 
            this.RectangleHeightTextBox.Location = new System.Drawing.Point(248, 40);
            this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            this.RectangleHeightTextBox.Size = new System.Drawing.Size(157, 23);
            this.RectangleHeightTextBox.TabIndex = 2;
            // 
            // RectangleHeightLabel
            // 
            this.RectangleHeightLabel.AutoSize = true;
            this.RectangleHeightLabel.Location = new System.Drawing.Point(248, 22);
            this.RectangleHeightLabel.Name = "RectangleHeightLabel";
            this.RectangleHeightLabel.Size = new System.Drawing.Size(46, 15);
            this.RectangleHeightLabel.TabIndex = 1;
            this.RectangleHeightLabel.Text = "Height:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(15, 22);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(227, 379);
            this.RectanglesListBox.TabIndex = 0;
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(420, 416);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.Label IdRectangleLabel;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.Label YRectangleLabel;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.Label XRectangleLabel;
        private System.Windows.Forms.Button RectangleFindButton;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
        private System.Windows.Forms.Label RectangleColorLabel;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.Label RectangleWidthLabel;
        private System.Windows.Forms.TextBox RectangleHeightTextBox;
        private System.Windows.Forms.Label RectangleHeightLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
