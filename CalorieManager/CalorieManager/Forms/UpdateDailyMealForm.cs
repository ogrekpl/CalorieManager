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
	public partial class UpdateDailyMealForm : Form
	{
		private DailyMeal dailyMeal;
		private User user;
		private User User => user;
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dailyMeal">Daily Meal</param>
		/// <param name="user">User</param>
		public UpdateDailyMealForm(DailyMeal dailyMeal, User user)
		{
			this.user = user;
			this.dailyMeal = dailyMeal;
			InitializeComponent();
			LoadToComboBox();
		}

		/// <summary>
		/// On Button New clicked method
		/// </summary>
		private void buttonNew_Click_1(object sender, EventArgs e)
		{
			if (comboBox.SelectedItem == null)
			{
				const string message = "Select meal!";
				const string caption = "Error";
				MessageBox.Show(message, caption);
			}
			else
			{
				Database db = new Database();
				db.DailyMealsDataUpdate(comboBox.SelectedItem as Meal, dailyMeal, user);
				const string message = "Activitie has been updated.";
				const string caption = "Success";
				MessageBox.Show(message, caption);
				PanelsForm form = Application.OpenForms["PanelsForm"] as PanelsForm;
				form.RefreshPanels();
				this.Close();
			}
		}

		/// <summary>
		/// Method that loads meals to Combobox
		/// </summary>
		private void LoadToComboBox()
		{
			Database db = new Database();
			List<Meal> meals = db.MealDataCollection();
			foreach (var meal in meals)
			{
				comboBox.Items.Add(meal);
			}
		}
	}
}
