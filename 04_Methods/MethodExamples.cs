using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;

        }

        private int SubtractTwoNumbers(int a,int b)
        {
            int num = a - b;
            return num;

        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;

        }

        private int DivideTwoNumbers(int z, int r)
        {
            int div = z / r;
            return div;
        }

        [TestMethod]

        public void MethodTests()

        {
            int banana = AddTwoNumbers(7, 12);
            int sumTwo = AddTwoNumbers(5, 42);

            int SubtractR = SubtractTwoNumbers(10, 5);
                Assert.AreEqual(5, SubtractR);
        }
    }
}
    
