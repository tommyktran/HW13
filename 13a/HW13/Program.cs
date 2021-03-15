using System;
using System.Collections.Generic;

namespace HW13
{
    class Program
    {
        static void Main(string[] args)
        {
            ShrinkableWords("MITXAFEC");
        }
        static void ShrinkableWords(string word)
        {
            List<string> vocab = new List<string>()
            {
                "MTAO", "OF", "TEC", "MXD", "T", "O", "AF", "AE", "A",
                "TAZ", "MTBXAE", "ABCDE", "TAEC", "MTOZE", "MITXFAEC", "MTAFC", "MTAFOC", "MTZABC",
                "MTAFOC", "MITXFFEC", "XAEC", "MTAFEC", "F", "MTBXAEC", "ZAEC", "MFECFEC", "TAX",
                "MTXAFEC", "TAFEC", "MXAFECI", "TAE", "ITXAFC", "MTAFOCC", "MITXAFEOC", "D", "MXITABFEC",
                "AC", "MTAFOC", "MD", "MTXABCD", "OA", "MITXAFEC", "OFMIT", "TED", "MTAEC",
                "MITXFAEE", "TAF", "TAC", "AEOC", "TA", "MITXAFC", "ITXAFEC", "MITXAFE", "MITAFEC"
            };
            var result = new List<string> { };

            ShrinkableWords(vocab, word, result);
        }
        static bool ShrinkableWords(List<string> vocab, string word, List<string> result)
        {
            if (word == "")
            {
                foreach (string thing in result)
                {
                    Console.Write(thing + " -> ");
                }
                Console.WriteLine("(empty)");
                return true;
            }
            for (int x = 0; x < word.Length; x++)
            {
                if (vocab.Contains(word.Remove(x, 1)) || (vocab.Contains(word) && word.Length == 1))
                {
                    result.Add(word);
                    if (ShrinkableWords(vocab, word.Remove(x, 1), result)) return true;
                    result.Remove(word);
                }
            }
            return false;
        }
    }
}
