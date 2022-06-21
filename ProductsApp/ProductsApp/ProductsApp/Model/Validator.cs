using System;

namespace ProductsApp.Model
{
    /// <summary>
    /// Предоставляет методы для валидации данных.
    /// </summary>
    internal class Validator
    {
        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится 
        /// вне диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в диапазоне от {min} до {max}");
            }
        }

        /// <summary>
        /// Проверяет, является ли число положительным.
        /// </summary>
        /// <param name="property">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, 
        /// если число меньше нуля.</exception>
        public static void AssertOnPositiveValue(string property, int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"Значение поля {property} должно быть положительным");
            }
        }
    }
}
