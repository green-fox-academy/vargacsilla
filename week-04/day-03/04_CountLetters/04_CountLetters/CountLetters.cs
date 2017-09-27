using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CountLetters
{
    public class CountLetters
    {
        public Dictionary<char, int> GetLettersCount(string inputString)
        {
            inputString = inputString.ToLower();
            var letterDict = new Dictionary<char, int>();

            if (String.IsNullOrEmpty(inputString))
            {
                return letterDict = null;
            }

            for (int i = 0; i < inputString.Length; i++)
            {
                if (letterDict.ContainsKey(inputString[i]))
                {
                    letterDict[inputString[i]]++;
                }
                else
                {
                    letterDict.Add(inputString[i], 1);
                }
            }
            return letterDict;
        }
    }
}
