using Core.Services.ExChange;
using System;
using Xunit;

namespace CoreTest
{
    [TestClass]
    public class UnitTest1
    {
        ExChangeService service = new ExChangeService();
        [Test]
        public void Test1()
        {
            var res = service.getMessage();
    }
    }
}
