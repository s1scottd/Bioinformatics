using System;
using System.IO;
using BioLib;

namespace Problem1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DNAString dnaString = new DNAString(File.ReadAllText("../../../DnaString.txt"));
            DNAString dnaPattern = new DNAString(File.ReadAllText("../../../DnaPattern.txt"));

            int count = dnaString.PatternCount(dnaPattern);

            Console.WriteLine($"{count}");
        }
    }
}
