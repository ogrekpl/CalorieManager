using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieManager.Forms;

namespace CalorieManager.Classes
{
    class DailyMeals
    {
        private uint id;
        private Meal meal;
        private DateTime date;
        public uint Id => id;
        public Meal Meal => meal;
        public DateTime Date => date;

        /// <summary>
        /// Constructor of class DailyMeals
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="meals">Meals</param>
        /// <param name="date">Date</param>
        public DailyMeals(uint id, Meal meal, DateTime date)
        {
            this.id = id;
            this.meal = meal;
            this.date = date;
        }

        /// <summary>
        /// Constructor without Id of class DailyMeals
        /// </summary>
        /// <param name="meals">Meals</param>
        /// <param name="date">Date</param>
        public DailyMeals(Meal meal, DateTime date)
        {
	        this.meal = meal;
	        this.date = date;
        }

        public override string ToString()
        {
	        return id + "-" + date.ToShortDateString();
        }
    }
}
