﻿namespace Programming.View.Controls
{
    partial class SeasonHandleControl
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
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonNamesComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.ClearColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(152, 17);
            this.GoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(88, 27);
            this.GoButton.TabIndex = 11;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonNamesComboBox
            // 
            this.SeasonNamesComboBox.FormattingEnabled = true;
            this.SeasonNamesComboBox.Location = new System.Drawing.Point(4, 17);
            this.SeasonNamesComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SeasonNamesComboBox.Name = "SeasonNamesComboBox";
            this.SeasonNamesComboBox.Size = new System.Drawing.Size(140, 23);
            this.SeasonNamesComboBox.TabIndex = 13;
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(4, 0);
            this.ChooseSeasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.ChooseSeasonLabel.TabIndex = 12;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // ClearColorButton
            // 
            this.ClearColorButton.Location = new System.Drawing.Point(246, 17);
            this.ClearColorButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClearColorButton.Name = "ClearColorButton";
            this.ClearColorButton.Size = new System.Drawing.Size(88, 27);
            this.ClearColorButton.TabIndex = 14;
            this.ClearColorButton.Text = "Очистить";
            this.ClearColorButton.UseVisualStyleBackColor = true;
            this.ClearColorButton.Click += new System.EventHandler(this.ClearColorButton_Click);
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearColorButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.SeasonNamesComboBox);
            this.Controls.Add(this.ChooseSeasonLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(334, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox SeasonNamesComboBox;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.Button ClearColorButton;
    }
}