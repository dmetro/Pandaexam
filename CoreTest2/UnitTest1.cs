using Core.Services.ExChange;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTest2
{
    [TestClass]
    public class UnitTest1
    {
        ExChangeService ExChangeService = new ExChangeService();

        [TestMethod]
        public void TestMethod1()
        {
            var res = ExChangeService.getMessage();
        }
    }
}
