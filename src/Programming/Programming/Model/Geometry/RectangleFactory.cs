using System;
using Rectangle = Programming.Model.Classes.Rectangle;
using Point2D = Programming.Model.Classes.Point2D;


namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private const int MaxSizeRectangle = 200;
        private const int Margin = 15;
        public static Rectangle Randomize(int canvasHeight, int canvasWidth)
        {
            Random random = new Random();
            var rectangleHeight = random.Next(1, MaxSizeRectangle);
            var rectangleWidth = random.Next(1, MaxSizeRectangle);
            var rectangleX = random.Next(Margin, canvasWidth - MaxSizeRectangle - Margin);
            var rectangleY = random.Next(Margin, canvasHeight - MaxSizeRectangle - Margin);
            var rectanglePosition = new Point2D(rectangleX, rectangleY);

            return new Rectangle(
                rectangleHeight,
                rectangleWidth,
                "Green",
                rectanglePosition
                );
        }
    }
}