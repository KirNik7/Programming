using System;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
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
                throw new System.ArgumentException(
                    $"Значение поля {property} должно быть положительным");
            }
        }

        /// <summary>
        /// Проверяет, является ли число положительным.
        /// </summary>
        /// <param name="property">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, 
        /// если число меньше нуля.</exception>
        public static void AssertOnPositiveValue(string property, double value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException(
                    $"Значение поля {property} должно быть положительным");
            }
        }

        /// <summary>
        /// Проверяет, находится ли число в определённом диапазоне.
        /// </summary>
        /// <param name="property">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, 
        /// если число находится вне диапазона.</exception>
        public static void AssertValueInRange(string property, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException(
                        $"Значение поля {property} должно находиться " +
                        $"в диапозоне от {min} до {max} включительно");
            }
        }

        /// <summary>
        /// Проверяет, находится ли число в определённом диапазоне.
        /// </summary>
        /// <param name="property">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, 
        /// если число находится вне диапазона.</exception>
        public static void AssertValueInRange(string property, double value, 
                                              double min, double max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException(
                        $"Значение поля {property} должно находиться" +
                        $"в диапозоне от {min} до {max} включительно");
            }
        }

        /// <summary>
		/// Проверят строку на то, что она состоит только из букв англйиского алфавита.
		/// </summary>
		/// <param name="property">Имя свойства, откуда был вызван метод.</param>
		/// <param name="value">Строка.</param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">Выбрасывается, если строка состоит 
		/// не только из букв английского алфавита.</exception>
		public static void AssertStringContainsOnlyLetters(string property, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"Поле {property} должно " +
                    $"содержать только символы английского алфавита.");
            }
        }
    }
}
