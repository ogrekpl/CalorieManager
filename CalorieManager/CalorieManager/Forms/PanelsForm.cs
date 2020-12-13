﻿using System;
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
		public PanelsForm(User user)
		{
			//get all acc date + user id
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

		private void buttonAddActivity_Click(object sender, EventArgs e)
		{
			NewDailyActivityForm form = new NewDailyActivityForm(user);
			form.ShowDialog();
			LoadDailyActivities();
			RefreshPanels();
		}

		private void buttonAddMeal_Click(object sender, EventArgs e)
		{
			NewDailyMealForm form = new NewDailyMealForm(user);
			form.ShowDialog();
			LoadDailyMeals();
			RefreshPanels();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			activeDate = dateTimePicker1.Value;
		}

		private void LoadDailyMeals()
		{
			Database db = new Database();
			dailyMeals = db.DailyMealsDataCollectionDate(user, activeDate);
		}

		private void LoadDailyActivities()
		{
			Database db = new Database();
			dailyActivities = db.DailyActivitiesDataCollectionDate(user, activeDate);
		}

		private List<MealControl> LoadMealsControl(List<DailyMeal> dM)
		{
			List<MealControl> temp = new List<MealControl>();

			foreach (var meal in dM)
			{
				temp.Add(new MealControl(meal, user));
			}

			return  temp;
		}

		private List<ActivityControl> LoadActivityControls(List<DailyActivitie> dA)
		{
			List<ActivityControl> temp = new List<ActivityControl>();

			foreach (var activity in dA)
			{
				temp.Add(new ActivityControl(activity, user));
			}

			return  temp;
		}

		private void AddToPanelActivitie(DailyActivitie activitie)
		{
			ActivityControl activeControl = new ActivityControl(activitie, user);
			activeControl.Location = new Point(10, panel2.Controls.Count * (activeControl.Height + 30));
			panel2.Controls.Add(activeControl);
		}

		private void AddToPanelMeal(DailyMeal meal)
		{
			MealControl mealControl = new MealControl(meal, user);
			mealControl.Location = new Point(10, panel1.Controls.Count * (mealControl.Height + 30));
			panel1.Controls.Add(mealControl);
		}

		private void LoadToPanelActivities(List<ActivityControl> aCL)
		{
			foreach (var aC in aCL)
			{
				aC.Location = new Point(10, panel2.Controls.Count * (aC.Height + 30));
				panel2.Controls.Add(aC);
			}
		}

		private void LoadToPanelMeals(List<MealControl> mCL)
		{
			foreach (var mC in mCL)
			{
				mC.Location = new Point(10, panel1.Controls.Count * (mC.Height + 30));
				panel1.Controls.Add(mC);
			}
		}

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
