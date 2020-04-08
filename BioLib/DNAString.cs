using System;
using System.Collections.Generic;

namespace BioLib
{
    public class DNAString
    {
        public string Text { get; set; }
        public int Length { get => Text.Length; }

        public DNAString() => Text = "";

        public DNAString(string dnaString) => Text = dnaString;

        /// <summary>
        /// Returns the number of times the DNA Pattern occurs in
        /// the DNA String
        /// </summary>
        /// <param name="dnaPattern"></param>
        /// <returns></returns>
        public int PatternCount(DNAString dnaPattern)
        {
            int count = 0;
            for (int i = 0; i <= Text.Length - dnaPattern.Length; i++)
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
    }
}
