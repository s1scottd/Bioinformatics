using System;
using System.IO;
using BioLib;

namespace Problem1B
{
    /// <summary>
    /// Returns the most frequent k-mers in a DNAString.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            DNAString dnaString = new DNAString(File.ReadAllText("../../../DnaString.txt"));
            int k = 4;

            var frequentStrings = dnaString.FrequentWords(k);

            foreach(DNAString word in frequentStrings)
            {
                Console.Write($"{word} ");
            }

            Console.WriteLine();
        }
    }
}
