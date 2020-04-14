using System;
using System.IO;
using BioLib;

namespace Problem1A
{
    /// <summary>
    /// Returns the number of times the DNA Pattern occurs in
    /// the DNA String
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            DNAString dnaString = new DNAString(File.ReadAllText("../../../DnaString.txt"));
            DNAString dnaPattern = new DNAString(File.ReadAllText("../../../DnaPattern.txt"));

            var count = 0;

            var length = dnaString.Length;
            var patLength = dnaPattern.Length;

            for (var i = 0; i <= dnaString.Length - dnaPattern.Length; i++)
                if (dnaString.Substring(i, dnaPattern.Length).Equals(dnaPattern))
                    count++;

            Console.WriteLine($"{count}");
        }
    }
}
