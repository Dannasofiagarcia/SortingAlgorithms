using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.test
{
    [TestClass]
    public class DataGeneratorTest
    {
        private int[] temp;

        [TestMethod]
        public void TestMethod1()
        {
            //Orden ascendente
            temp = SortingAlgorithms.model.DataGenerator.Generate(0, 0, 100);
            Boolean ascendente = true;

            for (int i = 0; i < temp.Length - 1; i++)
            {
                if(!(temp[i] < temp[i +1])){
                ascendente = false;
                }
            }

            Assert.IsTrue(ascendente);

        }
        
        [TestMethod]
        public void TestMethod2()
        {
            //Orden descendente
            temp = SortingAlgorithms.model.DataGenerator.Generate(0, 1, 100);
            Boolean descendente = true;

            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (!(temp[i] > temp[i + 1]))
                {
                    descendente = false;
                }
            }

            Assert.IsTrue(descendente);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Orden aleatorio
            temp = SortingAlgorithms.model.DataGenerator.Generate(0, 2, 100);
            Boolean ascendente = true;
            Boolean descendente = true;

            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (!(temp[i] > temp[i + 1]))
                {
                    descendente = false;
                }
                if(!(temp[i] < temp[i + 1]))
                {
                    ascendente = false;
              
                }
            }

            Assert.IsTrue(!ascendente);
            Assert.IsTrue(!descendente);

        }

        [TestMethod]

        public void TestMethod4()
        {
            //Orden aleatorio
            temp = SortingAlgorithms.model.DataGenerator.Generate(1, 2, 0);
            Boolean ascendente = true;
            Boolean descendente = true;

            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (!(temp[i] > temp[i + 1]))
                {
                    descendente = false;
                }
                if (!(temp[i] < temp[i + 1]))
                {
                    ascendente = false;

                }
            }

            Assert.IsTrue(!ascendente);
            Assert.IsTrue(!descendente);
            Assert.IsTrue((temp.Length % 10) == 0);

        }


        [TestMethod]
        public void TestMethod5()
        {
            //Orden descendente
            temp = SortingAlgorithms.model.DataGenerator.Generate(1, 0, 0);
            Boolean ascendente = true;

            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (!(temp[i] < temp[i + 1]))
                {
                    ascendente = false;
                }
            }

            Assert.IsTrue(ascendente);
            Assert.IsTrue((temp.Length % 10) == 0);

        }

        [TestMethod]
        public void TestMethod6()
        {
            //Orden descendente
            temp = SortingAlgorithms.model.DataGenerator.Generate(1, 1, 0);
            Boolean descendente = true;

            for (int i = 0; i < temp.Length - 1; i++)
            {
                if (!(temp[i] > temp[i + 1]))
                {
                    descendente = false;
                }
            }

            Assert.IsTrue(descendente);
            Assert.IsTrue((temp.Length % 10) == 0);
        }

    }
}
