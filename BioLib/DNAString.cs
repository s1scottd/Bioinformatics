using System;
using System.Collections.Generic;

namespace BioLib
{
    public class DNAString
    {
        //*************
        // Properties *
        //*************
        public string Text { get; set; }
        public int Length => Text.Length;

        //*********************
        // Operator OVerloads *
        //*********************
        public char this[int i] => Text[i];


        //**********************
        // Constructor methods *
        //**********************

        public DNAString() => Text = "";

        public DNAString(string dnaString) => Text = dnaString;

        //**********
        // Methods *
        //**********

        /// <summary>
        /// Returns the number of times the DNA Pattern occurs in
        /// the DNA String
        /// </summary>
        /// <param name="dnaPattern"></param>
        /// <returns></returns>
        public int PatternCount(DNAString dnaPattern)
        {
            var count = 0;
            for (var i = 0; i <= Text.Length - dnaPattern.Length; i++)
                if (Text.Substring(i, dnaPattern.Length).Equals(dnaPattern.Text))
                    count++;
            return count;
        }

        /// <summary>
        /// Returns the most frequent k-mers in a DNAString
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public List<DNAString> FrequentWords(int length)
        {
            var frequentPatterns = new List<DNAString>();


            return frequentPatterns;
        }

        //******************
        // Helper Methods  *
        //******************

        /// <summary>
        /// Converts a DNAString to a number
        /// </summary>
        /// <returns></returns>
        public int PatternToNumber()
        {
            if (Length == 0)
                return 0;

            char symbol = this[Length - 1];
            DNAString prefix = this.SubString(0, Length - 1);

            return (4 * prefix.PatternToNumber()) + SymbolToNumber(symbol);
        }

        public DNAString SubString(int start)
        {
            return new DNAString(Text.Substring(start));
        }

        public DNAString SubString(int start, int length)
        {
            return new DNAString(Text.Substring(start, length));
        }

        //******************
        // Private methods *
        //******************

        /// <summary>
        /// Convert a nucleotide monomer to an integer representation
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        private static int SymbolToNumber(char symbol) => char.ToUpper(symbol) switch
        {
            'A' => 0,
            'C' => 1,
            'G' => 2,
            'T' => 3,
            _ => -1,
        };

        /// <summary>
        /// Convert an integer to a nucleotide monomer that it represents
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        private static char NumberToSymbol(int i) => i switch
        {
            0 => 'A',
            1 => 'C',
            2 => 'G',
            3 => 'T',
            _ => '?',
        };
    }
}
