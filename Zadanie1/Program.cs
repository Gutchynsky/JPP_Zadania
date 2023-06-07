namespace Zadanie1;

class Zadanie1
{
    /// <summary>
    /// Function that counts the number of letters used to write out all the numbers from 1 to 1000 (inclusive).
    /// </summary>
    private static void Main()
    {
        var totalLetters = 0;
        for (var i = 1; i <= 1000; i++)
        {
            var numberInWords = NumberToWords(i);
            var lettersInNumber = CountLetters(numberInWords);
            totalLetters += lettersInNumber;
        }

        Console.WriteLine("Total letters used: " + totalLetters);
    }

    /// <summary>
    /// Function that converts a number to words.
    /// </summary>
    /// <param name="number">Number to convert.</param>
    /// <returns>Number in words.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="number"/> is not between 1 and 1000 (inclusive).</exception>
    private static string NumberToWords(int number)
    {
        if (number is < 1 or > 1000)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 1000 (inclusive).");
        }

        var words = "";
        
        if (number is 1000)
        {
            words += "one thousand";
            return words;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number <= 0)
        {
            return words;
        }

        if (words != "")
        {
            words += "and ";
        }

        var unitsMap = new[]
        {
            "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
            "eighteen", "nineteen"
        };
        var tensMap = new[]
        {
            "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        if (number < 20)
        {
            words += unitsMap[number];
        }
        else
        {
            // Since we divide integers, we don't need to worry about rounding. 25 / 10 = 2, not 2.5.
            words += tensMap[number / 10];

            if ((number % 10) > 0)
            {
                words += "-" + unitsMap[number % 10];
            }
        }

        return words;
    }

    /// <summary>
    /// Function that counts the number of letters in a string. Spaces are not counted.
    /// </summary>
    /// <param name="words">Words to count letters in.</param>
    /// <returns>Number of letters in <paramref name="words"/>.</returns>
    private static int CountLetters(string words)
    {
        // LINQ expression that counts the number of letters in a string.
        return words.Count(char.IsLetter);
    }
}