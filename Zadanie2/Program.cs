namespace Zadanie2;

internal class Zadanie2
{
    /// <summary>
    /// Function that finds the starting number under one million that produces the longest Collatz chain.
    /// </summary>
    private static void Main()
    {
        const int limit = 1000000;
        var longestChain = 0;
        var startingNumber = 0;

        for (var i = 1; i <= limit; i++)
        {
            var chainLength = GetCollatzChainLength(i);

            if (chainLength <= longestChain) continue;
            longestChain = chainLength;
            startingNumber = i;
        }

        Console.WriteLine("Starting number with the longest chain: " + startingNumber);
        Console.WriteLine("Chain length: " + longestChain);
    }

    /// <summary>
    /// Function that returns the length of the Collatz chain for a given number.
    /// </summary>
    /// <param name="number">Number to check.</param>
    /// <returns>Length of the Collatz chain.</returns>
    private static int GetCollatzChainLength(long number)
    {
        var chainLength = 1;

        while (number != 1)
        {
            // If the number is even, divide it by two. Otherwise, multiply it by three and add one.
            if (number % 2 == 0)
            {
                // number = number / 2;
                number /= 2;
            }
            else
            {
                number = 3 * number + 1;
            }

            chainLength++;
        }

        return chainLength;
    }
}