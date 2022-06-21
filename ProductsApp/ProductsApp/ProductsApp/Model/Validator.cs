using System;

namespace ProductsApp.Model
{
    internal class Validator
    {
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"{propertyName} должно быть в деапазоне от {min} до {max}");
            }
        }

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
