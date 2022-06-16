namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.HeightSelectedRectangleLabel = new System.Windows.Forms.Label();
            this.WidthSelectedRectangleLabel = new System.Windows.Forms.Label();
            this.YSelectedRectangleLabel = new System.Windows.Forms.Label();
            this.XSelectedRectangleLabel = new System.Windows.Forms.Label();
            this.IdSelectedRectangleLabel = new System.Windows.Forms.Label();
            this.HeightSelectedRectangleTextBox = new System.Windows.Forms.TextBox();
            this.WidthSelectedRectangleTextBox = new System.Windows.Forms.TextBox();
            this.YSelectedRectangleTextBox = new System.Windows.Forms.TextBox();
            this.XSelectedRectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdSelectedRectangleTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RemoveRectanglePictureBox = new System.Windows.Forms.PictureBox();
            this.AddRectanglePictureBox = new System.Windows.Forms.PictureBox();
            this.AddingRectanglesListBox = new System.Windows.Forms.ListBox();
            this.AddedRectanglesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveRectanglePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRectanglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(260, 3);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(600, 423);
            this.CanvasPanel.TabIndex = 32;
            // 
            // HeightSelectedRectangleLabel
            // 
            this.HeightSelectedRectangleLabel.AutoSize = true;
            this.HeightSelectedRectangleLabel.Location = new System.Drawing.Point(10, 368);
            this.HeightSelectedRectangleLabel.Name = "HeightSelectedRectangleLabel";
            this.HeightSelectedRectangleLabel.Size = new System.Drawing.Size(46, 15);
            this.HeightSelectedRectangleLabel.TabIndex = 31;
            this.HeightSelectedRectangleLabel.Text = "Height:";
            // 
            // WidthSelectedRectangleLabel
            // 
            this.WidthSelectedRectangleLabel.AutoSize = true;
            this.WidthSelectedRectangleLabel.Location = new System.Drawing.Point(14, 339);
            this.WidthSelectedRectangleLabel.Name = "WidthSelectedRectangleLabel";
            this.WidthSelectedRectangleLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthSelectedRectangleLabel.TabIndex = 30;
            this.WidthSelectedRectangleLabel.Text = "Width:";
            // 
            // YSelectedRectangleLabel
            // 
            this.YSelectedRectangleLabel.AutoSize = true;
            this.YSelectedRectangleLabel.Location = new System.Drawing.Point(39, 310);
            this.YSelectedRectangleLabel.Name = "YSelectedRectangleLabel";
            this.YSelectedRectangleLabel.Size = new System.Drawing.Size(17, 15);
            this.YSelectedRectangleLabel.TabIndex = 29;
            this.YSelectedRectangleLabel.Text = "Y:";
            // 
            // XSelectedRectangleLabel
            // 
            this.XSelectedRectangleLabel.AutoSize = true;
            this.XSelectedRectangleLabel.Location = new System.Drawing.Point(39, 281);
            this.XSelectedRectangleLabel.Name = "XSelectedRectangleLabel";
            this.XSelectedRectangleLabel.Size = new System.Drawing.Size(17, 15);
            this.XSelectedRectangleLabel.TabIndex = 28;
            this.XSelectedRectangleLabel.Text = "X:";
            // 
            // IdSelectedRectangleLabel
            // 
            this.IdSelectedRectangleLabel.AutoSize = true;
            this.IdSelectedRectangleLabel.Location = new System.Drawing.Point(36, 252);
            this.IdSelectedRectangleLabel.Name = "IdSelectedRectangleLabel";
            this.IdSelectedRectangleLabel.Size = new System.Drawing.Size(20, 15);
            this.IdSelectedRectangleLabel.TabIndex = 27;
            this.IdSelectedRectangleLabel.Text = "Id:";
            // 
            // HeightSelectedRectangleTextBox
            // 
            this.HeightSelectedRectangleTextBox.Location = new System.Drawing.Point(62, 365);
            this.HeightSelectedRectangleTextBox.Name = "HeightSelectedRectangleTextBox";
            this.HeightSelectedRectangleTextBox.Size = new System.Drawing.Size(100, 23);
            this.HeightSelectedRectangleTextBox.TabIndex = 26;
            this.HeightSelectedRectangleTextBox.TextChanged += new System.EventHandler(this.HeightSelectedRectangleTextBox_TextChanged);
            // 
            // WidthSelectedRectangleTextBox
            // 
            this.WidthSelectedRectangleTextBox.Location = new System.Drawing.Point(62, 336);
            this.WidthSelectedRectangleTextBox.Name = "WidthSelectedRectangleTextBox";
            this.WidthSelectedRectangleTextBox.Size = new System.Drawing.Size(100, 23);
            this.WidthSelectedRectangleTextBox.TabIndex = 25;
            this.WidthSelectedRectangleTextBox.TextChanged += new System.EventHandler(this.WidthSelectedRectangleTextBox_TextChanged);
            // 
            // YSelectedRectangleTextBox
            // 
            this.YSelectedRectangleTextBox.Location = new System.Drawing.Point(62, 307);
            this.YSelectedRectangleTextBox.Name = "YSelectedRectangleTextBox";
            this.YSelectedRectangleTextBox.Size = new System.Drawing.Size(100, 23);
            this.YSelectedRectangleTextBox.TabIndex = 24;
            this.YSelectedRectangleTextBox.TextChanged += new System.EventHandler(this.YSelectedRectangleTextBox_TextChanged);
            // 
            // XSelectedRectangleTextBox
            // 
            this.XSelectedRectangleTextBox.Location = new System.Drawing.Point(62, 278);
            this.XSelectedRectangleTextBox.Name = "XSelectedRectangleTextBox";
            this.XSelectedRectangleTextBox.Size = new System.Drawing.Size(100, 23);
            this.XSelectedRectangleTextBox.TabIndex = 23;
            this.XSelectedRectangleTextBox.TextChanged += new System.EventHandler(this.XSelectedRectangleTextBox_TextChanged);
            // 
            // IdSelectedRectangleTextBox
            // 
            this.IdSelectedRectangleTextBox.Location = new System.Drawing.Point(62, 249);
            this.IdSelectedRectangleTextBox.Name = "IdSelectedRectangleTextBox";
            this.IdSelectedRectangleTextBox.ReadOnly = true;
            this.IdSelectedRectangleTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdSelectedRectangleTextBox.TabIndex = 22;
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(10, 231);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRectangleLabel.TabIndex = 21;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RemoveRectanglePictureBox
            // 
            this.RemoveRectanglePictureBox.BackgroundImage = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectanglePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveRectanglePictureBox.Location = new System.Drawing.Point(139, 200);
            this.RemoveRectanglePictureBox.Name = "RemoveRectanglePictureBox";
            this.RemoveRectanglePictureBox.Size = new System.Drawing.Size(75, 24);
            this.RemoveRectanglePictureBox.TabIndex = 20;
            this.RemoveRectanglePictureBox.TabStop = false;
            this.RemoveRectanglePictureBox.Click += new System.EventHandler(this.RemoveRectanglePictureBox_Click);
            this.RemoveRectanglePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemoveRectanglePictureBox_MouseDown);
            this.RemoveRectanglePictureBox.MouseEnter += new System.EventHandler(this.RemoveRectanglePictureBox_MouseEnter);
            this.RemoveRectanglePictureBox.MouseLeave += new System.EventHandler(this.RemoveRectanglePictureBox_MouseLeave);
            this.RemoveRectanglePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveRectanglePictureBox_MouseUp);
            // 
            // AddRectanglePictureBox
            // 
            this.AddRectanglePictureBox.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectanglePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddRectanglePictureBox.Location = new System.Drawing.Point(45, 200);
            this.AddRectanglePictureBox.Name = "AddRectanglePictureBox";
            this.AddRectanglePictureBox.Size = new System.Drawing.Size(75, 24);
            this.AddRectanglePictureBox.TabIndex = 19;
            this.AddRectanglePictureBox.TabStop = false;
            this.AddRectanglePictureBox.Click += new System.EventHandler(this.AddRectanglePictureBox_Click);
            this.AddRectanglePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddRectanglePictureBox_MouseDown);
            this.AddRectanglePictureBox.MouseEnter += new System.EventHandler(this.AddRectanglePictureBox_MouseEnter);
            this.AddRectanglePictureBox.MouseLeave += new System.EventHandler(this.AddRectanglePictureBox_MouseLeave);
            this.AddRectanglePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddRectanglePictureBox_MouseUp);
            // 
            // AddingRectanglesListBox
            // 
            this.AddingRectanglesListBox.FormattingEnabled = true;
            this.AddingRectanglesListBox.ItemHeight = 15;
            this.AddingRectanglesListBox.Location = new System.Drawing.Point(10, 25);
            this.AddingRectanglesListBox.Name = "AddingRectanglesListBox";
            this.AddingRectanglesListBox.Size = new System.Drawing.Size(243, 169);
            this.AddingRectanglesListBox.TabIndex = 18;
            this.AddingRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.AddingRectanglesListBox_SelectedIndexChanged);
            // 
            // AddedRectanglesLabel
            // 
            this.AddedRectanglesLabel.AutoSize = true;
            this.AddedRectanglesLabel.Location = new System.Drawing.Point(10, 7);
            this.AddedRectanglesLabel.Name = "AddedRectanglesLabel";
            this.AddedRectanglesLabel.Size = new System.Drawing.Size(67, 15);
            this.AddedRectanglesLabel.TabIndex = 17;
            this.AddedRectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.HeightSelectedRectangleLabel);
            this.Controls.Add(this.WidthSelectedRectangleLabel);
            this.Controls.Add(this.YSelectedRectangleLabel);
            this.Controls.Add(this.XSelectedRectangleLabel);
            this.Controls.Add(this.IdSelectedRectangleLabel);
            this.Controls.Add(this.HeightSelectedRectangleTextBox);
            this.Controls.Add(this.WidthSelectedRectangleTextBox);
            this.Controls.Add(this.YSelectedRectangleTextBox);
            this.Controls.Add(this.XSelectedRectangleTextBox);
            this.Controls.Add(this.IdSelectedRectangleTextBox);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RemoveRectanglePictureBox);
            this.Controls.Add(this.AddRectanglePictureBox);
            this.Controls.Add(this.AddingRectanglesListBox);
            this.Controls.Add(this.AddedRectanglesLabel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(863, 429);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveRectanglePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRectanglePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Label HeightSelectedRectangleLabel;
        private System.Windows.Forms.Label WidthSelectedRectangleLabel;
        private System.Windows.Forms.Label YSelectedRectangleLabel;
        private System.Windows.Forms.Label XSelectedRectangleLabel;
        private System.Windows.Forms.Label IdSelectedRectangleLabel;
        private System.Windows.Forms.TextBox HeightSelectedRectangleTextBox;
        private System.Windows.Forms.TextBox WidthSelectedRectangleTextBox;
        private System.Windows.Forms.TextBox YSelectedRectangleTextBox;
        private System.Windows.Forms.TextBox XSelectedRectangleTextBox;
        private System.Windows.Forms.TextBox IdSelectedRectangleTextBox;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.PictureBox RemoveRectanglePictureBox;
        private System.Windows.Forms.PictureBox AddRectanglePictureBox;
        private System.Windows.Forms.ListBox AddingRectanglesListBox;
        private System.Windows.Forms.Label AddedRectanglesLabel;
    }
}
