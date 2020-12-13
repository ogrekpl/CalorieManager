using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieManager.Classes;

namespace CalorieManager.Forms
{
	public partial class UpdateDailyActivitieForm : Form
	{
		private DailyActivitie dailyActivitie;
		private User user;
		public UpdateDailyActivitieForm(DailyActivitie dailyActivitie, User user)
		{
			this.user = user;
			this.dailyActivitie = dailyActivitie;
			InitializeComponent();
			LoadToComboBox();
		}

		private void buttonNew_Click(object sender, EventArgs e)
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
				db.DailyActivitiesDataUpdate(comboBox.SelectedItem as Activity, dailyActivitie, user);
				const string message = "Activitie has been updated.";
				const string caption = "Success";
				MessageBox.Show(message, caption);
				PanelsForm form = Application.OpenForms["PanelsForm"] as PanelsForm;
				form.RefreshPanels();
				this.Close();
			}
		}

		private void LoadToComboBox()
		{
			Database db = new Database();
			List<Activity> activities = db.ActivityDataCollection();
			foreach (var activity in activities)
			{
				comboBox.Items.Add(activity);
			}
		}
	}
}
