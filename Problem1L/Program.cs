using System;
using System.IO;
using BioLib;

namespace Problem1L
{
    /// <summary>
    /// Converts a DNAString to a number
    /// </summary>
    /// <returns></returns>
    class Program
    {
        /// <summary>
        /// Convert a nucleotide monomer to an integer representation
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        private static uint SymbolToNumber(char symbol) => char.ToUpper(symbol) switch
        {
            'A' => 0,
            'C' => 1,
            'G' => 2,
            'T' => 3,
            _ => throw new ArgumentOutOfRangeException(),
        };

        public static ulong PatternToNumber(DNAString dnaString)
        {
            if (dnaString.Length == 0)
                return 0;

            char symbol = dnaString[dnaString.Length - 1];

            DNAString prefix = dnaString.Substring(0, dnaString.Length - 1);

            Console.WriteLine($"{prefix.Text} {symbol}");

            return (4 * PatternToNumber(prefix)) + SymbolToNumber(symbol);
        }

        static void Main(string[] args)
        {
            DNAString dnaString = new DNAString(File.ReadAllText("../../../DnaString.txt"));

            try
            {
                var number = PatternToNumber(dnaString);

                Console.WriteLine($"{number}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }
    }
}
