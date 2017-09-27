using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Apples_again;

namespace ClassLibrary1
{
    [TestFixture]
    public class AppleTest
    {
        [Test]
        public void TestGetApples()
        {
            var apples = new Apples();
            string expected = "apples";
            string output = apples.GetApples();
            Assert.AreEqual(expected, output);
        }
    }
}
