using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для валидации данных.
    /// </summary>
    public class ValueValidator
    {
        /// <summary>
        /// Проверяет количество символов в заданной строке.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLength">Максимальное количество символов в строке.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если количество
        /// символов в строке превышает максимальное.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть меньше {maxLength} символов");
            }
        }

        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится 
        /// вне диапазона.</exception>
        public static void AssertValueInRange(double value, 
                                              double min, 
                                              double max, 
                                              string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в диапазоне от {min} до {max}");
            }
        }
    }
}
