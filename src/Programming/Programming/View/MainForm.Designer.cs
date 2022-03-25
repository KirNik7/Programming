
namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.SeasonHandleComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ItsWeekdayLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.RectangleColorLabel = new System.Windows.Forms.Label();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(863, 429);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(440, 293);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(413, 130);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonHandleButton
            // 
            this.SeasonHandleButton.Location = new System.Drawing.Point(198, 41);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonHandleButton.TabIndex = 2;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            this.SeasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // SeasonHandleComboBox
            // 
            this.SeasonHandleComboBox.FormattingEnabled = true;
            this.SeasonHandleComboBox.Location = new System.Drawing.Point(16, 41);
            this.SeasonHandleComboBox.Name = "SeasonHandleComboBox";
            this.SeasonHandleComboBox.Size = new System.Drawing.Size(175, 23);
            this.SeasonHandleComboBox.TabIndex = 1;
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(16, 23);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.ChooseSeasonLabel.TabIndex = 0;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ItsWeekdayLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(8, 293);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(426, 130);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ItsWeekdayLabel
            // 
            this.ItsWeekdayLabel.AutoSize = true;
            this.ItsWeekdayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItsWeekdayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ItsWeekdayLabel.Location = new System.Drawing.Point(16, 71);
            this.ItsWeekdayLabel.Name = "ItsWeekdayLabel";
            this.ItsWeekdayLabel.Size = new System.Drawing.Size(0, 15);
            this.ItsWeekdayLabel.TabIndex = 3;
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.Location = new System.Drawing.Point(277, 41);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(75, 23);
            this.WeekdayParsingButton.TabIndex = 2;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            this.WeekdayParsingButton.Click += new System.EventHandler(this.WeekdayParsingButton_Click);
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(16, 41);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(255, 23);
            this.WeekdayParsingTextBox.TabIndex = 1;
            // 
            // WeekdayParsingLabel
            // 
            this.WeekdayParsingLabel.AutoSize = true;
            this.WeekdayParsingLabel.Location = new System.Drawing.Point(16, 23);
            this.WeekdayParsingLabel.Name = "WeekdayParsingLabel";
            this.WeekdayParsingLabel.Size = new System.Drawing.Size(127, 15);
            this.WeekdayParsingLabel.TabIndex = 0;
            this.WeekdayParsingLabel.Text = "Type value for parsing:";
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumsGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumsGroupBox.Controls.Add(this.ChooseEnumsLabel);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Location = new System.Drawing.Point(8, 7);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(845, 280);
            this.EnumsGroupBox.TabIndex = 0;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Enabled = false;
            this.IntValueTextBox.Location = new System.Drawing.Point(372, 37);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(125, 23);
            this.IntValueTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(372, 19);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(194, 19);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ChooseValueLabel.TabIndex = 3;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumsLabel
            // 
            this.ChooseEnumsLabel.AutoSize = true;
            this.ChooseEnumsLabel.Location = new System.Drawing.Point(16, 19);
            this.ChooseEnumsLabel.Name = "ChooseEnumsLabel";
            this.ChooseEnumsLabel.Size = new System.Drawing.Size(121, 15);
            this.ChooseEnumsLabel.TabIndex = 2;
            this.ChooseEnumsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(194, 37);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(158, 229);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Location = new System.Drawing.Point(16, 37);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(156, 229);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(871, 457);
            this.TabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(863, 429);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
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
            this.MoviesGroupBox.Location = new System.Drawing.Point(435, 7);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(418, 416);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(248, 216);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(160, 23);
            this.MovieRatingTextBox.TabIndex = 11;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(248, 198);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(44, 15);
            this.MovieRatingLabel.TabIndex = 10;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Location = new System.Drawing.Point(248, 172);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(160, 23);
            this.MovieDurationTextBox.TabIndex = 9;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(248, 154);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(56, 15);
            this.MovieDurationLabel.TabIndex = 8;
            this.MovieDurationLabel.Text = "Duration:";
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Location = new System.Drawing.Point(248, 378);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(160, 23);
            this.MovieFindButton.TabIndex = 7;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.MovieFindButton_Click);
            // 
            // MovieYearTextBox
            // 
            this.MovieYearTextBox.Location = new System.Drawing.Point(248, 128);
            this.MovieYearTextBox.Name = "MovieYearTextBox";
            this.MovieYearTextBox.Size = new System.Drawing.Size(160, 23);
            this.MovieYearTextBox.TabIndex = 6;
            this.MovieYearTextBox.TextChanged += new System.EventHandler(this.MovieYearTextBox_TextChanged);
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(248, 110);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(33, 15);
            this.MovieYearLabel.TabIndex = 5;
            this.MovieYearLabel.Text = "Year:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(248, 84);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(160, 23);
            this.MovieGenreTextBox.TabIndex = 4;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(248, 66);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(41, 15);
            this.MovieGenreLabel.TabIndex = 3;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(248, 40);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(160, 23);
            this.MovieTitleTextBox.TabIndex = 2;
            this.MovieTitleTextBox.TextChanged += new System.EventHandler(this.MovieTitleTextBox_TextChanged);
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(248, 22);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(33, 15);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 15;
            this.MoviesListBox.Location = new System.Drawing.Point(15, 22);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(227, 379);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectangleFindButton);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleLengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleLengthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(8, 7);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(420, 416);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Location = new System.Drawing.Point(248, 378);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(160, 23);
            this.RectangleFindButton.TabIndex = 7;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            this.RectangleFindButton.Click += new System.EventHandler(this.RectangleFindButton_Click);
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Location = new System.Drawing.Point(248, 128);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(160, 23);
            this.RectangleColorTextBox.TabIndex = 6;
            this.RectangleColorTextBox.TextChanged += new System.EventHandler(this.RectangleColorTextBox_TextChanged);
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
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(160, 23);
            this.RectangleWidthTextBox.TabIndex = 4;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
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
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(248, 40);
            this.RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            this.RectangleLengthTextBox.Size = new System.Drawing.Size(160, 23);
            this.RectangleLengthTextBox.TabIndex = 2;
            this.RectangleLengthTextBox.TextChanged += new System.EventHandler(this.RectangleLengthTextBox_TextChanged);
            // 
            // RectangleLengthLabel
            // 
            this.RectangleLengthLabel.AutoSize = true;
            this.RectangleLengthLabel.Location = new System.Drawing.Point(248, 22);
            this.RectangleLengthLabel.Name = "RectangleLengthLabel";
            this.RectangleLengthLabel.Size = new System.Drawing.Size(47, 15);
            this.RectangleLengthLabel.TabIndex = 1;
            this.RectangleLengthLabel.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(15, 22);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(227, 379);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 457);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(887, 496);
            this.MinimumSize = new System.Drawing.Size(887, 496);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Demo";
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumsLabel;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label WeekdayParsingLabel;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.Label ItsWeekdayLabel;
        private System.Windows.Forms.Button WeekdayParsingButton;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
        private System.Windows.Forms.Button SeasonHandleButton;
        private System.Windows.Forms.ComboBox SeasonHandleComboBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.Button RectangleFindButton;
        private System.Windows.Forms.TextBox RectangleColorTextBox;
        private System.Windows.Forms.Label RectangleColorLabel;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.Label RectangleWidthLabel;
        private System.Windows.Forms.TextBox RectangleLengthTextBox;
        private System.Windows.Forms.Label RectangleLengthLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.Button MovieFindButton;
        private System.Windows.Forms.TextBox MovieYearTextBox;
        private System.Windows.Forms.Label MovieYearLabel;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.Label MovieGenreLabel;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.Label MovieDurationLabel;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.Label MovieRatingLabel;
    }
}

