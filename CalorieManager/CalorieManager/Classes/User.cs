using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieManager
{
	public class User
	{
		private uint id;
		private string name;
		private int age;
		private int height;
		private int caloriesGoal;
		private double weightGoal;
		private Dictionary<DateTime, double> weightHistory;
		public uint Id => id;
		public string Name => name;
		public int Age => age;
		public int Height => height;
		public int CaloriesGoal => caloriesGoal;
		public double WeightGoal => weightGoal;
		public Dictionary<DateTime, double> WeightHistory => weightHistory;


		/// <summary>
		/// Constructor of class User
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="name">Name</param>
		/// <param name="age">Age</param>
		/// <param name="height">Height(cm)</param>
		/// <param name="caloriesGoal">Calories Goal</param>
		/// <param name="weightGoal">Weight goal</param>
		/// <param name="weightHistory">Weight History</param>
		public User(uint id, string name, int age, int height, int caloriesGoal, double weightGoal, Dictionary<DateTime, double> weightHistory)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			this.height = height;
			this.caloriesGoal = caloriesGoal;
			this.weightGoal = weightGoal;
			this.weightHistory = weightHistory;
		}

		/// <summary>
		/// Constructor without Id of class User
		/// </summary>
		/// <param name="name"></param>
		/// <param name="age"></param>
		/// <param name="height"></param>
		/// <param name="caloriesGoal"></param>
		/// <param name="weightGoal"></param>
		/// <param name="weightHistory"></param>
		public User(string name, int age, int height, int caloriesGoal, double weightGoal, Dictionary<DateTime, double> weightHistory)
		{
			this.name = name;
			this.age = age;
			this.height = height;
			this.caloriesGoal = caloriesGoal;
			this.weightGoal = weightGoal;
			this.weightHistory = weightHistory;
		}
	}
}
