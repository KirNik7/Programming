using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemColor = System.Drawing.Color;
using Rectangle = Programming.Model.Classes.Rectangle;
using Programming.Model.Geometry;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        private const int MaxSizeRectangle = 200;

        private readonly SystemColor _errorBackColor = SystemColor.LightPink;

        private readonly SystemColor _correctBackColor = SystemColor.White;

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle;

        private const int CountElements = 5;

        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();
            RectanglesListBox.SelectedIndex = 0;
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int indexMaxWidth = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            if (indexRectangle != -1)
            {
                _currentRectangle = _rectangles[indexRectangle];
                RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
                RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
                RectangleColorTextBox.Text = _currentRectangle.Color.ToString();
                XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
                YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private List<Rectangle> CreateRectangles()
        {
            List<Rectangle> rectangles = new List<Rectangle>(CountElements);
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangle = RectangleFactory.Randomize(MaxSizeRectangle, MaxSizeRectangle);
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = int.Parse(RectangleHeightTextBox.Text);
                RectangleHeightTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                RectangleHeightTextBox.BackColor = _errorBackColor;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = _errorBackColor;
            }
        }

        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = int.Parse(XRectangleTextBox.Text);
                XRectangleTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                XRectangleTextBox.BackColor = _errorBackColor;
            }
        }

        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YRectangleTextBox.Text);
                YRectangleTextBox.BackColor = _correctBackColor;
            }
            catch
            {
                YRectangleTextBox.BackColor = _errorBackColor;
            }
        }
    }
}
