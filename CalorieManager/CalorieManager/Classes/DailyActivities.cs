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
        private List<Activity> activities;
        private DateTime date;

        public uint Id => id;
        public List<Activity> Activities => activities;
        public DateTime Date => date;

        public DailyActivities(uint id, List<Activity> activities, DateTime date)
        {
            this.id = id;
            this.activities = activities;
            this.date = date;
        }

        public DailyActivities(List<Activity> activities, DateTime date)
        {
            this.activities = activities;
            this.date = date;
        }
    }
}
