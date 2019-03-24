using FutureSkill.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FooTest
    {
        [TestMethod]
        public void M1Test()
        {
            Foo f = new Foo();
            Assert.AreEqual(1, f.M1());
        }

    }
}
