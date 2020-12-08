using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieManager.Classes
{
	class Activity
	{
		private uint id;
		private string name;
		private string description;
		private int calories;
		public uint Id => id;
		public string Name => name;
		public string Description => description;
		public int Calories => calories;

		/// <summary>
		/// Constructor of Activity class
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="name">Name</param>
		/// <param name="description">Description</param>
		/// <param name="calories">Calories</param>
		public Activity(uint id, string name, string description, int calories)
		{
			this.id = id;
			this.name = name;
			this.description = description;
			this.calories = calories;
		}

		/// <summary>
		/// Constructor without Id of Activity class
		/// </summary>
		/// <param name="name">Name</param>
		/// <param name="description">Description</param>
		/// <param name="calories">Calories</param>
		public Activity(string name, string description, int calories)
		{
			this.name = name;
			this.description = description;
			this.calories = calories;
		}

		public override string ToString()
		{
			return name;
		}
	}
}
