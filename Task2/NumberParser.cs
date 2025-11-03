using System;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {

            ArgumentNullException.ThrowIfNull(stringValue, "stringValue");


            if (string.IsNullOrWhiteSpace(stringValue))
            {
                throw new FormatException("Input string was not in a correct format.");
            }

            stringValue = stringValue.Trim();

            double num = 0;
            int sign = 1;
            int i = 0;

            if (stringValue[0] == '-' || stringValue[0] == '+')
            {
                sign = stringValue[0] == '-' ? -1 : 1;
                i++;
            }

            while (i < stringValue.Length)
            {
                int currentNumber = stringValue[i] - '0';

                if (currentNumber > 9 || currentNumber < 0)
                {
                    throw new FormatException("Input string was not in a correct format.");
                }

                num = num * 10 + currentNumber;
                i++;
            }

            checked
            {

                return (int)(num * sign);

            }

        }
    }
}