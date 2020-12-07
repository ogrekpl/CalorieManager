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
        private List<Meal> meals;
        private DateTime date;
        public uint Id => id;
        public List<Meal> Meals => meals;
        public DateTime Date => date;

        /// <summary>
        /// Constructor of class DailyMeals
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="meals">Meals</param>
        /// <param name="date">Date</param>
        public DailyMeals(uint id, List<Meal> meals, DateTime date)
        {
            this.id = id;
            this.meals = meals;
            this.date = date;
        }

        /// <summary>
        /// Constructor without Id of class DailyMeals
        /// </summary>
        /// <param name="meals">Meals</param>
        /// <param name="date">Date</param>
        public DailyMeals(List<Meal> meals, DateTime date)
        {
	        this.meals = meals;
	        this.date = date;
        }

    }
}
