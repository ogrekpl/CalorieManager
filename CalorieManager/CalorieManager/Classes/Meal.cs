using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieManager.Forms
{
    class Meal
    {
        private uint id;
        private string name;
        private string description;
        private int kcal;
        private int protein;
        private int fat;
        private int hydrocarbon;

        public uint Id => id;
        public string Name => name;
        public string Description => description;
        public int Protein => protein;
        public int Fat => fat;
        public int Hydrocarbon => hydrocarbon;

        /// <summary>
        /// Constructor of class Meal
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="kcal">Calories</param>
        /// <param name="protein">Proteins</param>
        /// <param name="fat">Fats</param>
        /// <param name="hydrocarbon">Hydrocarbons</param>
        public Meal(uint id, string name, string description, int kcal, int protein, int fat, int hydrocarbon)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.kcal = kcal;
            this.protein = protein;
            this.fat = fat;
            this.hydrocarbon = hydrocarbon;
        }

        /// <summary>
        /// Constructor without Id of class Meal
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="kcal">Calories</param>
        /// <param name="protein">Proteins</param>
        /// <param name="fat">Fats</param>
        /// <param name="hydrocarbon">Hydrocarbons</param>
        public Meal(string name, string description, int kcal, int protein, int fat, int hydrocarbon)
        {
	        this.name = name;
	        this.description = description;
	        this.kcal = kcal;
	        this.protein = protein;
	        this.fat = fat;
	        this.hydrocarbon = hydrocarbon;
        }
    }
}
