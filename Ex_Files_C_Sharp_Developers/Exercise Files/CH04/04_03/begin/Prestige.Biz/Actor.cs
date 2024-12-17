using System;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor() : this(null)
        { }

        public Actor(string actorName)
        {
            Console.WriteLine("An actor is born!");
            ActorName = actorName;
            CurrentAgency = new Agency();
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set {
                var formattedName = value?.Trim();
                actorName = formattedName;
            }
        }

        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public int ActorAge { get; set; }

        public string ActorDescription { get; set; } = 
            "Regular actor";

        private Agency currentAgency; 

        public Agency CurrentAgency
        {
            get { return currentAgency; }
            set { currentAgency = value; }
        }

        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation() {
            jobTitle = "Actor";
            return jobTitle;
        }

        /// <summary>
        /// Books actor and not date specified.
        /// </summary>
        public string BookActor() {
            return BookActor(string.Empty);
        }

        /// <summary>
        /// Books actor on specific date.
        /// </summary>
        /// <param name="theDate"></param>
        public string BookActor(string theDate)
        {
            string details = "Booking can change if" +
                " actor starts trouble.";
            string theActor = "Actor " + ActorName + " is booked";
            if (theDate != string.Empty)
            {
                return theActor + " on " + theDate + ". " + details;
            }
            else {
                return theActor + ". " + details;
            }                         
        }

        public string GetAgency() {
            return CurrentAgency.Name;
        }
    }
}
