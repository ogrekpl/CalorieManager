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

        public DailyActivitie(uint id, Activity activitie, DateTime date)
        {
            this.id = id;
            this.activitie = activitie;
            this.date = date;
        }

        public DailyActivitie(Activity activitie, DateTime date)
        {
            this.activitie = activitie;
            this.date = date;
        }
    }
}
