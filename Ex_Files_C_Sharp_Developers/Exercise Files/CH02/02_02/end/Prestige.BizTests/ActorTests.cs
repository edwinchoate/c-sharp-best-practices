using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTests
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            Actor actor = new Actor();
            string occupation = actor.GetOccupation();
            Assert.AreEqual(occupation, "Actor");
        }
    }
}
