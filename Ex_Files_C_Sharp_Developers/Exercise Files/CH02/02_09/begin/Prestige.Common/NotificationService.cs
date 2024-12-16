namespace Prestige.Common
{
    public static class NotificationService
    {

        /// <summary>
        /// Notifies Talent
        /// </summary>
        public static string NotifyTalent (string talentName)
        {
            string message = "talent: " + talentName;
            Console.WriteLine(message);
            return message;
        }

    }
}
