using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sale()// data 
        {
            List<int> data = new List<int>()
            {
                1,2,3,4,5,6,7
            };
            int results = (int)Services.Sumvalueofsaleinweek(data);

            //assert
            Assert.AreEqual(28, results);
        }
    }

    public class Services
    {
        public static object Sumvalueofsaleinweek(List<int> data)
        {
            var total = 0;
            foreach (var item in data)
            {
                total += item;
            };
            return total;
        }
    }
}