using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Sum;

namespace TestSum
{
    [TestFixture]
    public class Class1
    {
        MyClass myClass = new MyClass();

        [Test]
        public void TestSumList_WhenEmpty_Returns0()
        {
            List<int> input = new List<int>() { };
            int output = myClass.SumList(input);
            int expected = 0;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestSumList_WhenOneElement_ReturnsElement()
        {
            List<int> input = new List<int>() { 5 };
            int output = myClass.SumList(input);
            int expected = 5;
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void TestSumList_WhenMultipleElements_ReturnsSum()
        {
            List<int> input = new List<int>() { 5, 5, 3 };
            int output = myClass.SumList(input);
            int expected = 13;
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void TestSumList_WhenNull_ReturnsError()
        {
            List<int> input = null;
            int output = myClass.SumList(input);
            int expected = 0;S
            Assert.AreEqual(expected, output);
        }
    }
}
