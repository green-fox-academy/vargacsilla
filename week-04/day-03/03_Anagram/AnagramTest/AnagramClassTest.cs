using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Anagram
{
    [TestFixture]
    public class Class1
    {
        MyClass myClass = new MyClass();

        [Test]
        public void TestIsAnagram_WhenSamecase_ReturnTrue()
        {
            string input1 = "abcde";
            string input2 = "edcba";

            bool expected = true;
            
            Assert.AreEqual(expected, myClass.IsAnagram(input1, input2));
        }

        [Test]
        public void TestIsAnagram_WhenDifferentCase_ReturnTrue()
        {
            string input1 = "abcde";
            string input2 = "ABCDE";

            bool expected = true;

            bool output = myClass.IsAnagram(input1, input2);

            Assert.AreEqual(expected, output);
        }
    }
}
