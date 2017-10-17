using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    [TestFixture]

    class DominoTest
    {
        [Test]
        public void CompareSameFirstNums()
        {
            var domino1 = new Domino(1, 4);
            var domino2 = new Domino(1, 2);
            int expected = 1;

            Assert.AreEqual(expected, domino1.CompareTo(domino2));
        }

    }
}
