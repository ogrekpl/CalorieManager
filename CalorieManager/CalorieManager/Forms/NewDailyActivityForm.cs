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
	public partial class NewDailyActivityForm : Form
	{
		private User user;
		private DailyActivitie dailyActivitie;
		public DailyActivitie DailyActivitie => dailyActivitie;

		public NewDailyActivityForm(User user)
		{
			this.user = user;
			InitializeComponent();
			LoadItemsToComboBox();
		}

		private void LoadItemsToComboBox()
		{
			Database db = new Database();
			List<Activity> activities = db.ActivityDataCollection();

			foreach (var activity in activities)
			{
				comboBox1.Items.Add(activity);
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			Activity activitie = comboBox1.SelectedItem as Activity;
			Database db = new Database();
			dailyActivitie = new DailyActivitie(activitie, DateTime.Today);
			db.DailyActivitiesDataAdd(dailyActivitie, user);
			this.Close();
		}
	}
}
