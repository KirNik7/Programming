using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Programming.Model.Classes.Rectangle;
using Point2D = Programming.Model.Classes.Point2D;
using Programming.View;


namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        public static Rectangle Randomize(int canvasHeight, int canvasWidth)
        {
            Random random = new Random();
            var rectangleHeight = random.Next(1, 200);
            var rectangleWidth = random.Next(1, 200);
            var rectangleX = random.Next(15, canvasWidth - 200 - 15);
            var rectangleY = random.Next(15, canvasHeight - 200 - 15);
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