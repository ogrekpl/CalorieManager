using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieManager.Classes
{
    class DailyActivities
    {
        private uint id;
        private Activity activity;
        private DateTime date;

        public uint Id => id;
        public Activity Activity => activity;
        public DateTime Date => date;

        /// <summary>
        /// Constructor of DailyActivities class
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="activity">Activity</param>
        /// <param name="date">Date</param>

        public DailyActivities(uint id, Activity activity, DateTime date)
        {
            this.id = id;
            this.activity = activity;
            this.date = date;
        }

        /// <summary>
        /// Constructor of DailyActivities class without Id
        /// </summary>
        /// <param name="activity">Activity</param>
        /// <param name="date">Date</param>

        public DailyActivities(Activity activity, DateTime date)
        {
            this.activity = activity;
            this.date = date;
        }
    }
}
