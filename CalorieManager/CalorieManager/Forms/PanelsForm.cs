using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieManager.Classes;
using CalorieManager.Controls;

namespace CalorieManager.Forms
{
	public partial class PanelsForm : Form
	{
		private User user;
		private DateTime activeDate;
		private List<ActivityControl> activitiyControls;
		private List<MealControl> mealControls;
		private List<DailyActivitie> dailyActivities;
		private List<DailyMeal> dailyMeals;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="user">User</param>
		public PanelsForm(User user)
		{
			dailyActivities = new List<DailyActivitie>();
			dailyMeals = new List<DailyMeal>();
			activeDate = DateTime.Now.Date;
			this.user = user;
			InitializeComponent();
			dateTimePicker1.Value = activeDate;
			LoadDailyMeals();
			LoadDailyActivities();
			RefreshPanels();
		}

		/// <summary>
		/// On Add Activity Button clicked Method
		/// </summary>
		private void buttonAddActivity_Click(object sender, EventArgs e)
		{
			NewDailyActivityForm form = new NewDailyActivityForm(user);
			form.ShowDialog();
			LoadDailyActivities();
			RefreshPanels();
		}

		/// <summary>
		/// On Add Meal Button clicked Method
		/// </summary>
		private void buttonAddMeal_Click(object sender, EventArgs e)
		{
			NewDailyMealForm form = new NewDailyMealForm(user);
			form.ShowDialog();
			LoadDailyMeals();
			RefreshPanels();
		}

		/// <summary>
		/// On Date Time Picker value changed method
		/// </summary>
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			activeDate = dateTimePicker1.Value;
		}

		/// <summary>
		/// Method that loads all daily meals from data base with this user and seted date
		/// </summary>
		private void LoadDailyMeals()
		{
			Database db = new Database();
			dailyMeals = db.DailyMealsDataCollectionDate(user, activeDate);
		}

		/// <summary>
		///  Method that loads all daily activities from data base with this user and seted date
		/// </summary>
		private void LoadDailyActivities()
		{
			Database db = new Database();
			dailyActivities = db.DailyActivitiesDataCollectionDate(user, activeDate);
		}

		/// <summary>
		/// Method that Loads Meals Controls 
		/// </summary>
		/// <param name="dM">Daily Meals List</param>
		/// <returns>Meals Control List</returns>
		private List<MealControl> LoadMealsControl(List<DailyMeal> dM)
		{
			List<MealControl> temp = new List<MealControl>();

			foreach (var meal in dM)
			{
				temp.Add(new MealControl(meal, user));
			}

			return  temp;
		}
		/// <summary>
		/// Method that Loads Activities Controls 
		/// </summary>
		/// <param name="dA">Daily Activities List</param>
		/// <returns>Activities Control List</returns>
		private List<ActivityControl> LoadActivityControls(List<DailyActivitie> dA)
		{
			List<ActivityControl> temp = new List<ActivityControl>();

			foreach (var activity in dA)
			{
				temp.Add(new ActivityControl(activity, user));
			}

			return  temp;
		}

		/// <summary>
		/// Method that Loads Activities to Panel
		/// </summary>
		/// <param name="aCL">Activities Control List</param>
		private void LoadToPanelActivities(List<ActivityControl> aCL)
		{
			foreach (var aC in aCL)
			{
				aC.Location = new Point(10, panel2.Controls.Count * (aC.Height + 30));
				panel2.Controls.Add(aC);
			}
		}

		/// <summary>
		/// Method that Loads MealsControls to Panel
		/// </summary>
		/// <param name="mCL">Meals Control List</param>
		private void LoadToPanelMeals(List<MealControl> mCL)
		{
			foreach (var mC in mCL)
			{
				mC.Location = new Point(10, panel1.Controls.Count * (mC.Height + 30));
				panel1.Controls.Add(mC);
			}
		}

		/// <summary>
		/// Method that Refresh Panels
		/// </summary>
		public void RefreshPanels()
		{
			panel1.Controls.Clear();
			panel2.Controls.Clear();
			LoadDailyMeals();
			LoadDailyActivities();
			mealControls = LoadMealsControl(dailyMeals);
			activitiyControls = LoadActivityControls(dailyActivities);
			LoadToPanelActivities(activitiyControls);
			LoadToPanelMeals(mealControls);
		}
	}
}
