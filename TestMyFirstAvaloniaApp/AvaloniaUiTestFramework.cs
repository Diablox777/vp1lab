using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAvaloniaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
        }
        [TestMethod()]
        public void RomanNumberTest2()
        {
            Assert.IsNotNull(new RomanNumber(20));
        }

        [TestMethod()]
        public void ToStringTest1()
        {
            var expected = "XXI";
            var obj = new RomanNumber(21);
            Assert.AreEqual(expected, obj.ToString());
        }

        [TestMethod()]
        public void ToStringTest2()
        {
            var expected = "XIX";
            var obj = new RomanNumber(19);
            Assert.AreEqual(expected, obj.ToString());
        }

        [TestMethod()]
        public void CloneTest()
        {
            var obj = new RomanNumber(50);
            RomanNumber clone = obj.Clone() as RomanNumber;
            Assert.IsNotNull(clone);
            Assert.AreNotSame(obj, clone);

            var expected = 0;
            var t = clone.CompareTo(obj);
            Assert.AreEqual(expected, t);
        }

        [TestMethod()]
        public void CompareToTest()
        {
            var expected = 0;
            var obj = new RomanNumber(5);
            var obj2 = new RomanNumber(5);

            var t = obj.CompareTo(obj2);

            Assert.AreEqual(expected, t);
        }

        [TestMethod()]
        public void CompareToTest2()
        {
            var expected = 1;
            var obj = new RomanNumber(6);
            var obj2 = new RomanNumber(5);

            var t = obj.CompareTo(obj2);

            Assert.AreEqual(expected, t);
        }

        [TestMethod()]
        public void CompareToTest3()
        {
            var expected = -1;
            var obj = new RomanNumber(6);
            var obj2 = new RomanNumber(7);

            var t = obj.CompareTo(obj2);

            Assert.AreEqual(expected, t);
        }

        [TestMethod()]
        public void AddTestNull1()
        {
            var obj = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj + obj2);
        }

        [TestMethod()]
        public void AddTestNull2()
        {
            var obj = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj2 + obj);
        }

        [TestMethod()]
        public void AddTest1()
        {
            var obj = new RomanNumber(5);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(11);

            Assert.AreEqual(0, (obj + obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void AddTest2()
        {
            var obj = new RomanNumber(20);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(26);

            Assert.AreEqual(0, (obj + obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void SubTestNull1()
        {
            var obj = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj - obj2);
        }

        [TestMethod()]
        public void SubTestNull2()
        {
            var obj = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj2 - obj);
        }

        [TestMethod()]
        public void SubTest1()
        {
            var obj = new RomanNumber(20);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(14);

            Assert.AreEqual(0, (obj - obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void SubTest2()
        {
            var obj = new RomanNumber(20);
            var obj2 = new RomanNumber(6);

            Assert.ThrowsException<RomanNumberException>(() => obj2 - obj);
        }

        [TestMethod()]
        public void SubTest3()
        {
            var obj = new RomanNumber(6);
            var obj2 = new RomanNumber(6);

            Assert.ThrowsException<RomanNumberException>(() => obj2 - obj);
        }

        [TestMethod()]
        public void DivTestNull1()
        {
            var obj = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj / obj2);
        }

        [TestMethod()]
        public void DivTestNull2()
        {
            var obj = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj2 / obj);
        }

        [TestMethod()]
        public void Div1Test1()
        {
            var obj = new RomanNumber(5);
            var obj2 = new RomanNumber(6);

            Assert.ThrowsException<RomanNumberException>(() => obj / obj2);
        }

        [TestMethod()]
        public void Div1Test2()
        {
            var obj = new RomanNumber(6);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(1);

            Assert.AreEqual(0, (obj / obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void Div1Test3()
        {
            var obj = new RomanNumber(12);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(2);

            Assert.AreEqual(0, (obj / obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void Div1Test4()
        {
            var obj = new RomanNumber(15);
            var obj2 = new RomanNumber(2);
            var expected = new RomanNumber(7);

            Assert.AreEqual(0, (obj / obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void MullTestNull1()
        {
            var obj = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj * obj2);
        }

        [TestMethod()]
        public void MullTestNull2()
        {
            var obj = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj2 * obj);
        }

        [TestMethod()]
        public void MullTest1()
        {
            var obj = new RomanNumber(5);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(30);

            Assert.AreEqual(0, expected.CompareTo(obj * obj2));
        }

        [TestMethod()]
        public void MullTest2()
        {
            var obj = new RomanNumber(4);
            var obj2 = new RomanNumber(7);
            var expected = new RomanNumber(28);

            Assert.AreEqual(0, expected.CompareTo(obj * obj2));
        }
    }
}