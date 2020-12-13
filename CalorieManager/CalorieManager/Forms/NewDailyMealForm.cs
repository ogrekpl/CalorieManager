using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieManager.Classes;

namespace CalorieManager.Forms
{
	public partial class NewDailyMealForm : Form
	{
		private User user;
		private DailyMeal dailyMeal;
		public DailyMeal DailyMeal => dailyMeal;
		public NewDailyMealForm(User user)
		{
			this.user = user;
			InitializeComponent();
			LoadItemsToComboBox();
		}

		private void LoadItemsToComboBox()
		{
			Database db = new Database();
			List<Meal> meals = db.MealDataCollection();

			foreach (var meal in meals)
			{
				comboBox1.Items.Add(meal);
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			Meal meal = comboBox1.SelectedItem as Meal;
			Database db = new Database();
			dailyMeal = new DailyMeal(meal, DateTime.Today);
			db.DailyMealsDataAdd(dailyMeal, user);
		}
	}
}
