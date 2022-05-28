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
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
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
            this.MoviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieFindButton);
            this.MoviesGroupBox.Controls.Add(this.MovieYearTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieYearLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieTitleTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieTitleLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(418, 416);
            this.MoviesGroupBox.TabIndex = 2;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieRatingTextBox.Location = new System.Drawing.Point(248, 216);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieRatingTextBox.TabIndex = 11;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(248, 198);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(44, 15);
            this.MovieRatingLabel.TabIndex = 10;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDurationTextBox.Location = new System.Drawing.Point(248, 172);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieDurationTextBox.TabIndex = 9;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(248, 154);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(56, 15);
            this.MovieDurationLabel.TabIndex = 8;
            this.MovieDurationLabel.Text = "Duration:";
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieFindButton.Location = new System.Drawing.Point(248, 378);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(157, 23);
            this.MovieFindButton.TabIndex = 7;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.MovieFindButton_Click);
            // 
            // MovieYearTextBox
            // 
            this.MovieYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieYearTextBox.Location = new System.Drawing.Point(248, 128);
            this.MovieYearTextBox.Name = "MovieYearTextBox";
            this.MovieYearTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieYearTextBox.TabIndex = 6;
            this.MovieYearTextBox.TextChanged += new System.EventHandler(this.MovieYearTextBox_TextChanged);
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(248, 110);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(33, 15);
            this.MovieYearLabel.TabIndex = 5;
            this.MovieYearLabel.Text = "Year:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGenreTextBox.Location = new System.Drawing.Point(248, 84);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieGenreTextBox.TabIndex = 4;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(248, 66);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(41, 15);
            this.MovieGenreLabel.TabIndex = 3;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieTitleTextBox.Location = new System.Drawing.Point(248, 40);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(157, 23);
            this.MovieTitleTextBox.TabIndex = 2;
            this.MovieTitleTextBox.TextChanged += new System.EventHandler(this.MovieTitleTextBox_TextChanged);
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(248, 22);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(33, 15);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 15;
            this.MoviesListBox.Location = new System.Drawing.Point(15, 22);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(227, 379);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(418, 416);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MoviesGroupBox;
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
