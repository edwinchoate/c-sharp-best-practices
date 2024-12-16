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
        public void TestBookActor() {
            // Arrange
            string details = "Booking can change if" +
                " actor starts trouble.";
            var currentActor = new Actor("Johnny Boy");
            var expected = "Actor Johnny Boy is booked. " +
                details;
            // Act
            string result = currentActor.BookActor();
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookActorOnSpecificDate()
        {
            // Arrange
            string details = "Booking can change if" +
                " actor starts trouble.";
            var currentActor = new Actor("Johnny Boy");
            var expected = "Actor Johnny Boy is booked on " +
                DateTime.Today.ToShortDateString() + 
                ". "+  details;
            // Act
            string result = currentActor.BookActor
                            (DateTime.Today.ToShortDateString());
            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestActorNameSetter()
        {
            // Arrange
            string details = "Booking can change if" +
                " actor starts trouble.";
            var currentActor = new Actor("Johnny Boy      ");
            var expected = "Actor Johnny Boy is booked. " +
                details;
            // Act
            string result = currentActor.BookActor();
            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}
