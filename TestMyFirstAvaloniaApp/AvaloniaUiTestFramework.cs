using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAvaloniaApp.Models;
using MyFirstAvaloniaApp.ViewModels;
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
            var obj1 = new RomanNumber(21);
            Assert.AreEqual(expected, obj1.ToString());
        }

        [TestMethod()]
        public void ToStringTest2()
        {
            var expected = "XIX";
            var obj1 = new RomanNumber(19);
            Assert.AreEqual(expected, obj1.ToString());
        }

        [TestMethod()]
        public void CloneTest()
        {
            var obj1 = new RomanNumber(50);
            RomanNumber clone = obj1.Clone() as RomanNumber;
            Assert.IsNotNull(clone);
            Assert.AreNotSame(obj1, clone);

            var expected = 0;
            var t = clone.CompareTo(obj1);
            Assert.AreEqual(expected, t);
        }

        [TestMethod()]
        public void CompareToTest()
        {
            var expected = 0;
            var obj1 = new RomanNumber(5);
            var obj2 = new RomanNumber(5);

            var t = obj1.CompareTo(obj2);

            Assert.AreEqual(expected, t);
        }

        [TestMethod()]
        public void CompareToTest2()
        {
            var expected = 1;
            var obj1 = new RomanNumber(6);
            var obj2 = new RomanNumber(5);

            var t = obj1.CompareTo(obj2);

            Assert.AreEqual(expected, t);
        }

        [TestMethod()]
        public void CompareToTest3()
        {
            var expected = -1;
            var obj1 = new RomanNumber(6);
            var obj2 = new RomanNumber(7);

            var t = obj1.CompareTo(obj2);

            Assert.AreEqual(expected, t);
        }

        [TestMethod()]
        public void AddTestNull1()
        {
            var obj1 = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj1 + obj2);
        }

        [TestMethod()]
        public void AddTestNull2()
        {
            var obj1 = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj2 + obj1);
        }

        [TestMethod()]
        public void AddTest1()
        {
            var obj1 = new RomanNumber(5);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(11);

            Assert.AreEqual(0, (obj1 + obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void AddTest2()
        {
            var obj1 = new RomanNumber(20);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(26);

            Assert.AreEqual(0, (obj1 + obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void SubTestNull1()
        {
            var obj1 = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj1 - obj2);
        }

        [TestMethod()]
        public void SubTestNull2()
        {
            var obj1 = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj2 - obj1);
        }

        [TestMethod()]
        public void SubTest1()
        {
            var obj1 = new RomanNumber(20);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(14);

            Assert.AreEqual(0, (obj1 - obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void SubTest2()
        {
            var obj1 = new RomanNumber(20);
            var obj2 = new RomanNumber(6);

            Assert.ThrowsException<RomanNumberException>(() => obj2 - obj1);
        }

        [TestMethod()]
        public void SubTest3()
        {
            var obj1 = new RomanNumber(6);
            var obj2 = new RomanNumber(6);

            Assert.ThrowsException<RomanNumberException>(() => obj2 - obj1);
        }

        [TestMethod()]
        public void DivTestNull1()
        {
            var obj1 = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj1 / obj2);
        }

        [TestMethod()]
        public void DivTestNull2()
        {
            var obj1 = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj2 / obj1);
        }

        [TestMethod()]
        public void DivvvTest1()
        {
            var obj1 = new RomanNumber(5);
            var obj2 = new RomanNumber(6);

            Assert.ThrowsException<RomanNumberException>(() => obj1 / obj2);
        }

        [TestMethod()]
        public void DivvvTest2()
        {
            var obj1 = new RomanNumber(6);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(1);

            Assert.AreEqual(0, (obj1 / obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void DivvvTest3()
        {
            var obj1 = new RomanNumber(12);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(2);

            Assert.AreEqual(0, (obj1 / obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void DivvvTest4()
        {
            var obj1 = new RomanNumber(15);
            var obj2 = new RomanNumber(2);
            var expected = new RomanNumber(7);

            Assert.AreEqual(0, (obj1 / obj2).CompareTo(expected));
        }

        [TestMethod()]
        public void MultiTestNull1()
        {
            var obj1 = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj1 * obj2);
        }

        [TestMethod()]
        public void MultiTestNull2()
        {
            var obj1 = new RomanNumber(5);
            RomanNumber obj2 = null;
            Assert.ThrowsException<ArgumentNullException>(() => obj2 * obj1);
        }

        [TestMethod()]
        public void MultiTest1()
        {
            var obj1 = new RomanNumber(5);
            var obj2 = new RomanNumber(6);
            var expected = new RomanNumber(30);

            Assert.AreEqual(0, expected.CompareTo(obj1 * obj2));
        }

        [TestMethod()]
        public void MultiTest2()
        {
            var obj1 = new RomanNumber(4);
            var obj2 = new RomanNumber(7);
            var expected = new RomanNumber(28);

            Assert.AreEqual(0, expected.CompareTo(obj1 * obj2));
        }


    }
    [TestClass()]
    public class VisualTest
    {
        [TestMethod()]
        public void VTest1()
        {
            var obj1 = new MainWindowViewModel();
            var test = 0;
            obj1.Set_text("test_text");
            obj1.Clear();
            if (obj1.Get_text() == "") test = 1;
            Assert.AreEqual(1, test);
        }
        [TestMethod()]
        public void VTest2()
        {
            var obj1 = new MainWindowViewModel();
            obj1.MainText = "";
            string text = "*";
            var test = 0;
            obj1.WriteChar(text);
            if (obj1.MainText == "*") test = 1;
            Assert.AreEqual(1, test);
        }
    }
}