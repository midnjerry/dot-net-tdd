using dot_net_tdd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace dot_net_tdd_tests
{
    [TestClass]
    public class PrimeFactorsTest
    {
        PrimeFactors factors = new PrimeFactors();
        List<int> expected = new List<int>();

        [TestMethod]
        public void InputOfZeroAndOneReturnsEmptyList()
        {
            CollectionAssert.AreEqual(expected, factors.Generate(0));
            CollectionAssert.AreEqual(expected, factors.Generate(1));
        }

        [TestMethod]
        public void InputOfTwoReturnsTwo()
        {
            expected.Add(2);
            CollectionAssert.AreEqual(expected, factors.Generate(2));
        }
        [TestMethod]
        public void InputOFThreeReturns3()
        {
            expected.Add(3);
            CollectionAssert.AreEqual(expected, factors.Generate(3));
        }

        [TestMethod]
        public void InputOfFourShouldReturn2_2()
        {
            expected.Add(2);
            expected.Add(2);
            CollectionAssert.AreEqual(expected, factors.Generate(4));
        }

        [TestMethod]
        public void InputOfFiveShouldReturn5()
        {
            expected.Add(5);
            CollectionAssert.AreEqual(expected, factors.Generate(5));
        }

        [TestMethod]
        public void InputOfTwelveShouldReturn2_2_3()
        {
            expected.Add(2);
            expected.Add(2);
            expected.Add(3);
            CollectionAssert.AreEqual(expected, factors.Generate(12));
        }

        [TestMethod]
        public void InputOf541()
        {
            expected.Add(541);
            CollectionAssert.AreEqual(expected, factors.Generate(541));
        }

        [TestMethod]
        public void InputOf1299709()
        {
            expected.Add(1299709);
            CollectionAssert.AreEqual(expected, factors.Generate(1299709));
        }

        [TestMethod]
        public void InputOf703142569()
        {
            expected.Add(541);
            expected.Add(  1299709);
            CollectionAssert.AreEqual(expected, factors.Generate(703142569));
        }
    }
}
