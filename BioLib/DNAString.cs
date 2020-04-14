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
        // Operator Overloads *
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

        public bool Equals(DNAString dnaString)
        {
            return Text.Equals(dnaString.Text);
        }

        public DNAString Substring(int start)
        {
            return new DNAString(Text.Substring(start));
        }

        public DNAString Substring(int start, int length)
        {
            return new DNAString(Text.Substring(start, length));
        }

        //******************
        // Helper Methods  *
        //******************

        /// <summary>
        /// Converts a DNAString to a number
        /// </summary>
        /// <returns></returns>
        //public int PatternToNumber()
        //{
        //    if (Length == 0)
        //        return 0;
        //
        //    char symbol = this[Length - 1];
        //    DNAString prefix = this.Substring(0, Length - 1);
        //
        //    return (4 * prefix.PatternToNumber()) + SymbolToNumber(symbol);
        //}



        //******************
        // Private methods *
        //******************

        /// <summary>
        /// Convert a nucleotide monomer to an integer representation
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        //private static int SymbolToNumber(char symbol) => char.ToUpper(symbol) switch
        //{
        //   'A' => 0,
        //    'C' => 1,
        //    'G' => 2,
        //    'T' => 3,
        //    _ => -1,
        //};

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
