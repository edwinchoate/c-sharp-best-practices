using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            // Arrange
            var currentActor = new Actor();
            var expected = "Actor";
            // Act
            string result = currentActor.GetOccupation();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestParameterizedConstructor() {
            // Arrange
            var currentActor = new Actor("Johnny Boy");
            var expected = "Johnny Boy";
            // Act
            string result = currentActor.ActorName;
            // Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestBookActor ()
        {
            string expected = "Actor Edwin Is booked.Booking can change if actor starts trouble.";
            Actor actor = new Actor("Edwin");
            Assert.AreEqual(expected, actor.BookActor());
        }

        [TestMethod]
        public void TestBookActorOnSpecificDate ()
        {
            string expected = "Actor Edwin is booked on wednesday. Booking can change if actor starts trouble.";
            Actor actor = new Actor("Edwin");
            Assert.AreEqual(expected, actor.BookActor("wednesday"));
        }
    }
}
