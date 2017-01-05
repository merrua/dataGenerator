using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataGenerator;

namespace DataGenerator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckStringLength()
        {
            FrenchData data = new FrenchData();
            var ex = data.getRandomFrenchString(10);
            Assert.AreEqual(10, ex.Length);
        }
    }
}
