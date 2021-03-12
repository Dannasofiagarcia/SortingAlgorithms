using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SortingAlgorithms;
using SortingAlgorithms.model;

namespace UnitTestProject
{
    [TestClass]
    public class SorterTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            int[] temp = new int[3] { 1, 2, 3 };
            temp = Sorter.sort(temp, 0);
        }
    }
}
