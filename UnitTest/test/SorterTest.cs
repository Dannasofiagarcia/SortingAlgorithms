using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class SorterTest
    {

        public void Initialize()
        {

        }

        public void SetUp1()
        {
            int[] temp = new int [3]{ 1, 2, 3 };
            temp = Sorter.sort(temp, 0);
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
