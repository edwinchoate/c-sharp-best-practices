using Prestige.Common;

namespace Prestige.CommonTests
{
    [TestClass]
    public sealed class NotificationServiceTest
    {
        [TestMethod]
        public void TestNotifyTalent()
        {
            string name = "Edwin";
            string talent = NotificationService.NotifyTalent(name);
            Assert.AreEqual("talent: Edwin", talent);
        }
    }
}
