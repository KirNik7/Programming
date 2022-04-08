using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string property, int value)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException(
                    $"Значение поля {property} должно быть положительным");
            }
        }

        public static void AssertOnPositiveValue(string property, double value)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException(
                    $"Значение поля {property} должно быть положительным");
            }
        }

        public static void AssertValueInRange(string property, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException(
                        $"Значение поля {property} должно находиться " +
                        $"в диапозоне от {min} до {max} включительно");
            }
        }

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
    }
}
