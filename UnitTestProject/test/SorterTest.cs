using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SortingAlgorithms;

namespace UnitTestProject
{
    [TestClass]
    public class SorterTest
    {
        private int[] temp;

        public void SetUp1()
        {
            temp = new int[3] {3, 2, 1 };
            
        }

        [TestMethod]
        public void TestMethod1()
        {
            SetUp1();            
            //Burbuja
            temp = SortingAlgorithms.model.Sorter.sort(temp, 0);

            Assert.IsTrue(temp[0] == 1);

        }
    }
}
