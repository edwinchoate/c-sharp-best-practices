using System;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born!");
        }

        public Actor(string actorName) 
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set { actorName = value; }
        }

        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }


        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation() {
            jobTitle = "Actor";
            return jobTitle;
        }

        public string BookActor ()
        {
            return "Actor " + ActorName + " is booked. Booking can change if actor starts trouble.";
        }

        public string BookActor (string date)
        {
            return "Actor " + ActorName + " is booked on " + date + "." + 
                "Booking can change if actor starts trouble.";
        }

    }
}
