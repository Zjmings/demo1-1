using demo1_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int A1 = 2, B1 = 0, X1 = 2;
            Class1 target = new Class1(A1,B1,X1);
            Assert.IsTrue(target != null);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int A1 = 4, B1 = 1, X1 = 1;
            Class1 target = new Class1(A1, B1, X1);
            Assert.IsTrue(target != null);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int A1 = 1, B1 = 1, X1 = 3;
            Class1 target = new Class1(A1, B1, X1);
            Assert.IsTrue(target != null);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int A1 = 1, B1 = 1, X1 = 1;
            Class1 target = new Class1(A1, B1, X1);
            Assert.IsTrue(target != null);
        }
    }
}
