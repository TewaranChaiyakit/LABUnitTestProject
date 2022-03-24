using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary1;
using System;

namespace LABUnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_Assignment_1()
        {
            AssignmentClass ac = new AssignmentClass();
            int input = 1020;
            string result =ac.gradeCalculate(input);
            Assert.AreEqual("A", result);

            result = ac.gradeCalculate(-1);
            Assert.AreEqual("F", result);



        }
        [TestMethod]
        public void Test_Assignment_2()
        {
            AssignmentClass ac = new AssignmentClass();
            double result = ac.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21,result);
            result = ac.getDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);

        }
    }
}
