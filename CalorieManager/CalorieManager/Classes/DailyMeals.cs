using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieManager.Forms
{
    class DailyMeals
    {
        private uint id;
        private List<Meal> meal;
        private DateTime date;

        public uint Id => id;

        public List<Meal> Meal => meal;

        public DateTime Date => date;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="meal"></param>
        /// <param name="date"></param>
        public DailyMeals(uint id, List<Meal> meal, DateTime date)
        {
            this.id = id;
            this.meal = meal;
            this.date = date;
        }

    }
}
