using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventcity.Classes
{
    public static class DatabaseInterface
    {
        /// <summary>
        /// Local Instance of the database model
        /// </summary>
        private static Eventcity.Models.eventcitydbEntities m_db = new Models.eventcitydbEntities();

        /// <summary>
        /// Gets all events in the database
        /// </summary>
        /// <returns>List of all events</returns>
        public static List<Models.events> GetAllEvents()
        {
            List<Eventcity.Models.events> lstEvents = new List<Models.events>();

            //Get all the events from the database
            var results = from r in m_db.events
                          select r;

            //Add them to a list to pass to the view
            foreach (Models.events ev in results)
            {
                lstEvents.Add(ev);
            }

            return lstEvents;
        }

        public static bool AccountExists(string strUserName, string strPassword)
        {
            bool bExists = false;

            int results = (from r in m_db.accounts
                          where r.strUserName == strUserName
                          && r.strPassword == strPassword
                          select r).Count();

            if (results != 0)
                return true;

            return bExists;
        }
    }
}