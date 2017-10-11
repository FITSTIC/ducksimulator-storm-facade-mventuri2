using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FacadeTest
{
    [TestClass]
    public class StormTest
    {
        private Storm storm;

        [TestInitialize]
        public void InitStorm()
        {
            this.storm = new Storm();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Assert.Fail("test");
        }
    }
}
