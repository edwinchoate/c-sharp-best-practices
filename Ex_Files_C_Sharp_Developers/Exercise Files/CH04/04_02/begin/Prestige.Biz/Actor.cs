﻿using System;

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

        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation() {
            jobTitle = "Actor";
            return jobTitle;
        }

        public string GetAgency ()
        {
            Agency agency = new Agency();
            return agency.Name;
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
    }
}
