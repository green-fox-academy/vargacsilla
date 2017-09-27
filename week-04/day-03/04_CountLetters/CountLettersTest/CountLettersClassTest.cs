using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CountLetters;

namespace CountLettersTest
{
    [TestFixture]
    public class CountLettersClassTest
    {
        CountLetters myCountLetter = new CountLetters();

        [Test]
        public void TestCountLetters_WhenEmpty_ReturnNull()
        {
            Dictionary<char, int> expected = null;
            var input = "";

            Assert.AreEqual(expected, myCountLetter.GetLettersCount(input));
        }

        [Test]
        public void TestCountLetters_WhenContainsSame_ReturnDict()
        {
            //Dictionary<char, int> expected = new Dictionary<char, int>();
            string input = "aba bba";
            Dictionary<char, int> myDict = myCountLetter.GetLettersCount(input);
            int output = myDict['b'];

            int expected = 3;

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestCountLetters_WhenUpperLower_ReturnDict()
        {
            //Dictionary<char, int> expected = new Dictionary<char, int>();
            string input = "aBa bba";
            Dictionary<char, int> myDict = myCountLetter.GetLettersCount(input);
            int output = myDict['b'];

            int expected = 3;

            Assert.AreEqual(expected, output);
        }
    }
}
