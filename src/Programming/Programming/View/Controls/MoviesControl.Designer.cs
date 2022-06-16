namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.MovieRatingLabel = new System.Windows.Forms.Label();
            this.MovieDurationTextBox = new System.Windows.Forms.TextBox();
            this.MovieDurationLabel = new System.Windows.Forms.Label();
            this.MovieFindButton = new System.Windows.Forms.Button();
            this.MovieYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieYearLabel = new System.Windows.Forms.Label();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieRatingTextBox.Location = new System.Drawing.Point(236, 197);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieRatingTextBox.TabIndex = 23;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(236, 179);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(44, 15);
            this.MovieRatingLabel.TabIndex = 22;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDurationTextBox.Location = new System.Drawing.Point(236, 153);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieDurationTextBox.TabIndex = 21;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(236, 135);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(56, 15);
            this.MovieDurationLabel.TabIndex = 20;
            this.MovieDurationLabel.Text = "Duration:";
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieFindButton.Location = new System.Drawing.Point(236, 355);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(157, 27);
            this.MovieFindButton.TabIndex = 19;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.MovieFindButton_Click);
            // 
            // MovieYearTextBox
            // 
            this.MovieYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieYearTextBox.Location = new System.Drawing.Point(236, 109);
            this.MovieYearTextBox.Name = "MovieYearTextBox";
            this.MovieYearTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieYearTextBox.TabIndex = 18;
            this.MovieYearTextBox.TextChanged += new System.EventHandler(this.MovieYearTextBox_TextChanged);
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(236, 91);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(32, 15);
            this.MovieYearLabel.TabIndex = 17;
            this.MovieYearLabel.Text = "Year:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGenreTextBox.Location = new System.Drawing.Point(236, 65);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieGenreTextBox.TabIndex = 16;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(236, 47);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(41, 15);
            this.MovieGenreLabel.TabIndex = 15;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieTitleTextBox.Location = new System.Drawing.Point(236, 21);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieTitleTextBox.TabIndex = 14;
            this.MovieTitleTextBox.TextChanged += new System.EventHandler(this.MovieTitleTextBox_TextChanged);
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(236, 3);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(32, 15);
            this.MovieTitleLabel.TabIndex = 13;
            this.MovieTitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 15;
            this.MoviesListBox.Location = new System.Drawing.Point(3, 3);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(227, 379);
            this.MoviesListBox.TabIndex = 12;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieRatingTextBox);
            this.Controls.Add(this.MovieRatingLabel);
            this.Controls.Add(this.MovieDurationTextBox);
            this.Controls.Add(this.MovieDurationLabel);
            this.Controls.Add(this.MovieFindButton);
            this.Controls.Add(this.MovieYearTextBox);
            this.Controls.Add(this.MovieYearLabel);
            this.Controls.Add(this.MovieGenreTextBox);
            this.Controls.Add(this.MovieGenreLabel);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(396, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.Label MovieRatingLabel;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.Label MovieDurationLabel;
        private System.Windows.Forms.Button MovieFindButton;
        private System.Windows.Forms.TextBox MovieYearTextBox;
        private System.Windows.Forms.Label MovieYearLabel;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
