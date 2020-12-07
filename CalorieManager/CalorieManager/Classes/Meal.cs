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
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="kcal"></param>
        /// <param name="protein"></param>
        /// <param name="fat"></param>
        /// <param name="hydrocarbon"></param>

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
    }
}
