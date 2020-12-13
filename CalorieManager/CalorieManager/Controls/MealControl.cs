using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieManager.Classes;
using CalorieManager.Forms;

namespace CalorieManager.Controls
{
	public partial class MealControl : UserControl
	{
		private DailyMeal dailyMeal;
		public DailyMeal DailyMeal => dailyMeal;
		private User user;

		public MealControl(DailyMeal dailyMeal, User user)
		{
			this.dailyMeal = dailyMeal;
			this.user = user;
			InitializeComponent();
			UpdateLabels(null, EventArgs.Empty);
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			Form updateDailyMeal = new UpdateDailyMealForm(dailyMeal, user);
			updateDailyMeal.ShowDialog();
			updateDailyMeal.Closed += UpdateLabels;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Database db = new Database();
			db.DailyMealsDataDelete(dailyMeal);
			PanelsForm form = Application.OpenForms["PanelsForm"] as PanelsForm;
			form.RefreshPanels();
			MessageBox.Show("Success");
		}

		private void UpdateLabels(object sender, EventArgs e)
		{
			labelName.Text = dailyMeal.Meal.Name;
			labelDescription.Text = dailyMeal.Meal.Description;
			labelCalories.Text = Convert.ToString(dailyMeal.Meal.Kcal);
		}
	}
}
