using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieManager.Classes
{
    public class DailyActivitie
    {
        private uint id;
        private Activity activitie;
        private DateTime date;
        public uint Id => id;
        public Activity Activitie => activitie;
        public DateTime Date => date;

        /// <summary>
        /// Constructor of Daily Activity class
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="activitie">Activity</param>
        /// <param name="date">Date</param>
        public DailyActivitie(uint id, Activity activitie, DateTime date)
        {
            this.id = id;
            this.activitie = activitie;
            this.date = date;
        }
        /// <summary>
        /// Constructor of Daily Activity class no ID
        /// </summary>
        /// <param name="activitie">Activity</param>
        /// <param name="date">Date</param>
        public DailyActivitie(Activity activitie, DateTime date)
        {
            this.activitie = activitie;
            this.date = date;
        }
    }
}
