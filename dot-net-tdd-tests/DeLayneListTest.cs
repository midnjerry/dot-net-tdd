using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using dot_net_tdd;

namespace dot_net_tdd_tests
{
    [TestClass]
    public class DeLayneListTest
    {
        //add, size, remove(i), insert(i),  get(i)

        private DeLayneList list;

        [TestInitialize]
        public void SetUp()
        {
            list = new DeLayneList();
        }

        // RED
        // GREEN
        // REFACTOR

        [TestMethod]
        public void Size_OnANewInstance_ShouldReturn0()
        {
            Assert.AreEqual(0, list.Size);
        }

        [TestMethod]
        public void Size_AddShouldIncrementSize()
        {
            list.Add("abc");
            Assert.AreEqual(1, list.Size);
            list.Add("def");
            Assert.AreEqual(2, list.Size);
        }

        [TestMethod]
        public void Size_RemoveShouldDecrementSize()
        {
            list.Add(123);
            list.Add(456);
            list.Add("abd");
            list.Remove(0);
            Assert.AreEqual(2, list.Size);
            list.Remove(0);
            Assert.AreEqual(1, list.Size);
            list.Remove(0);
            Assert.AreEqual(0, list.Size);
        }

        [TestMethod]
        public void Size_InsertShouldIncrementSize()
        {
            list.Insert(0);
            Assert.AreEqual(1, list.Size);
            list.Insert(0);
            Assert.AreEqual(2, list.Size);
        }

        [TestMethod]
        public void Get0_ShouldReturnFirstElementAdded()
        {
            list.Add("element");
            Assert.AreEqual("element", list.Get(0));
        }

        [TestMethod]
        public void Get0_ShouldReturnFirstElementAdded2()
        {
            list.Add("blue");
            Assert.AreEqual("blue", list.Get(0));
        }

        [TestMethod]
        public void Get_ShouldReturnBothElementsAdded()
        {
            list.Add("red");
            list.Add("blue");
            list.Add("green");
            Assert.AreEqual("red", list.Get(0));
            Assert.AreEqual("blue", list.Get(1));
            Assert.AreEqual("green", list.Get(2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void Get_ShouldThrowAnExceptionIfOutOfRange()
        {
            list.Add("red");
            list.Add("blue");
            list.Add("green");
            list.Get(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Get_ShouldThrowAnErrorIfTheIndexIsNegative()
        {
            list.Add("red");
            list.Add("blue");
            list.Add("green");
            list.Get(-1);
        }

        // remove
        // empty list remove throws exception
        // list with elements, remove with OOR index throws exception
        // list with elements, remove 0 removes the first element
        // list with elements, remove 1 removes second element
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_onEmptyList_ShouldThrowError()
        {
            list.Remove(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_ShouldThrowErrorIfIndexIsNegativeOne()
        {
            list.Add("Test");
            list.Remove(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void Remove_ShouldThrowExceptionIfIndexOutOfRangeForNonEmptyList()
        {
            list.Add('a');
            list.Add('b');
            list.Add('c');
            list.Remove(3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void Remove_ShouldThrowExceptionIfIndexGreaterThanSize()
        {
            list.Add('a');
            list.Add('b');
            list.Add('c');
            list.Remove(6);
        }

/*        [TestMethod]
        public void Remove_ShouldRemoveFirstElement()
        {
            list.Add('a');
            list.Add('b');
            list.Add('c');
            Assert.AreEqual('a', list.Remove(0));
            Assert.AreEqual(2, list.Size());
        }*/

        //RED
        //GREEN
        //REFACTOR
    }
}

