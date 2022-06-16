using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Реализует статическую обработку данных о двух прямоугольниках.
    /// </summary>
    public class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли два прямоугольника.
        /// </summary>
        /// <param name="rect1">Первый прямоугольник.</param>
        /// <param name="rect2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если если все условия для 
        /// пересечения выполнены, и false, если нет.</returns>
        public static bool IsCollision(Rectangle rect1, Rectangle rect2)
        {
            return rect1.Center.X < rect2.Center.X + rect2.Width &&
                rect1.Center.X + rect1.Width > rect2.Center.X &&
                rect1.Center.Y < rect2.Center.Y + rect2.Height &&
                rect1.Height + rect1.Center.Y > rect2.Center.Y;
        }

        /// <summary>
        /// Проверяет, пересекаются ли два кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если если условие для 
        /// пересечения выполнено, и false, если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            int dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dX * dX + dY * dY);

            return c < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}