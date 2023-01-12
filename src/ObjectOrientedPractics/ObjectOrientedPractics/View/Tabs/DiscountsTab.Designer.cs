namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CalcualteButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ProductsAmountDigitLabel = new System.Windows.Forms.Label();
            this.DiscountAmountDigitLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(3, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(33, 15);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Info:";
            // 
            // CalcualteButton
            // 
            this.CalcualteButton.Location = new System.Drawing.Point(3, 18);
            this.CalcualteButton.Name = "CalcualteButton";
            this.CalcualteButton.Size = new System.Drawing.Size(97, 41);
            this.CalcualteButton.TabIndex = 1;
            this.CalcualteButton.Text = "Calcualte";
            this.CalcualteButton.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(106, 18);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(97, 41);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(209, 18);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(97, 41);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(360, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(107, 15);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Products Amount:";
            // 
            // ProductsAmountDigitLabel
            // 
            this.ProductsAmountDigitLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductsAmountDigitLabel.Location = new System.Drawing.Point(360, 18);
            this.ProductsAmountDigitLabel.Name = "ProductsAmountDigitLabel";
            this.ProductsAmountDigitLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductsAmountDigitLabel.Size = new System.Drawing.Size(107, 35);
            this.ProductsAmountDigitLabel.TabIndex = 7;
            this.ProductsAmountDigitLabel.Text = "0,00";
            this.ProductsAmountDigitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscountAmountDigitLabel
            // 
            this.DiscountAmountDigitLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountAmountDigitLabel.Location = new System.Drawing.Point(360, 71);
            this.DiscountAmountDigitLabel.Name = "DiscountAmountDigitLabel";
            this.DiscountAmountDigitLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DiscountAmountDigitLabel.Size = new System.Drawing.Size(107, 35);
            this.DiscountAmountDigitLabel.TabIndex = 9;
            this.DiscountAmountDigitLabel.Text = "0,00";
            this.DiscountAmountDigitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountAmountLabel.Location = new System.Drawing.Point(360, 53);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(107, 15);
            this.DiscountAmountLabel.TabIndex = 8;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscountAmountDigitLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.ProductsAmountDigitLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CalcualteButton);
            this.Controls.Add(this.InfoLabel);
            this.Name = "DiscountsTab";
            this.Size = new System.Drawing.Size(473, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button CalcualteButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label ProductsAmountDigitLabel;
        private System.Windows.Forms.Label DiscountAmountDigitLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
    }
}
