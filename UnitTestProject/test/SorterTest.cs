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
            //Probando en orden descendente
            temp = new int[3] {3, 2, 1 };
            
        }

        public void SetUp2()
        {
            //Probando en orden ascendente
            temp = new int[3] { 1, 2, 3 };

        }

        public void SetUp3()
        {
            //Probando en orden aleatorio
            temp = new int[3] { 1, 3, 2 };

        }



        [TestMethod]
        public void TestMethod1()
        {
            SetUp1();            
            //Burbuja
            temp = SortingAlgorithms.model.Sorter.sort(temp, 0);

            Assert.IsTrue(temp[0] == 1);

        }

        [TestMethod]
        public void TestMethod2()
        {
            SetUp1();
            //Quick
            temp = SortingAlgorithms.model.Sorter.sort(temp, 1);

            Assert.IsTrue(temp[0] == 1);

        }

        [TestMethod]
        public void TestMethod3()
        {
            SetUp1();
            int ultimo = 3;
            //Quick
            temp = SortingAlgorithms.model.Sorter.sort(temp, 1);

            Assert.IsTrue(temp[2] == ultimo);

        }

        [TestMethod]
        public void TestMethod4()
        {
            SetUp1();
            int ultimo = 3;
            //Quick
            temp = SortingAlgorithms.model.Sorter.sort(temp, 0);

            Assert.IsTrue(temp[2] == ultimo);

        }

        [TestMethod]
        public void TestMethod5()
        {
            SetUp2();
            //Bubble
            temp = SortingAlgorithms.model.Sorter.sort(temp, 0);

            Assert.IsTrue(temp[0] == 1);

        }

        [TestMethod]
        public void TestMethod6()
        {
            SetUp2();
            //Quick
            temp = SortingAlgorithms.model.Sorter.sort(temp, 1);

            Assert.IsTrue(temp[0] == 1);

        }

        [TestMethod]
        public void TestMethod7()
        {
            SetUp2();
            int ultimo = 3;
            //Bubble
            temp = SortingAlgorithms.model.Sorter.sort(temp, 0);

            Assert.IsTrue(temp[2] == ultimo);

        }

        [TestMethod]
        public void TestMethod8()
        {
            SetUp2();
            int ultimo = 3;
            //Quick
            temp = SortingAlgorithms.model.Sorter.sort(temp, 1);

            Assert.IsTrue(temp[2] == ultimo);

        }

        [TestMethod]
        public void TestMethod9()
        {
            SetUp3();
            //Bubble
            temp = SortingAlgorithms.model.Sorter.sort(temp, 0);

            Assert.IsTrue(temp[0] == 1);

        }

        [TestMethod]
        public void TestMethod10()
        {
            SetUp3();
            //Quick
            temp = SortingAlgorithms.model.Sorter.sort(temp, 1);

            Assert.IsTrue(temp[0] == 1);

        }

        [TestMethod]
        public void TestMethod11()
        {
            SetUp1();
            int ultimo = 3;
            //Bubble
            temp = SortingAlgorithms.model.Sorter.sort(temp, 0);

            Assert.IsTrue(temp[2] == ultimo);

        }

        [TestMethod]
        public void TestMethod12()
        {
            SetUp1();
            int ultimo = 3;
            //Quick
            temp = SortingAlgorithms.model.Sorter.sort(temp, 1);

            Assert.IsTrue(temp[2] == ultimo);

        }
    }
}
