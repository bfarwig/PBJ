using System;
using NUnit.Framework;

namespace PBJ.UnitTests
{
    [TestFixture]
    public class SampleTest
    {

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(1,1);
        }

        [TearDown]
        public void Dispose()
        {
            
        }
    }
}
