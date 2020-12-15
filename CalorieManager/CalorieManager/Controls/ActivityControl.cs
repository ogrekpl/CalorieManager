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
	public partial class ActivityControl : UserControl
	{
		private DailyActivitie dailyActivitie;
		public DailyActivitie DailyActivitie => dailyActivitie;
		private User user;

		/// <summary>
		/// Constructor of Daily Activitiy class
		/// </summary>
		/// <param name="dailyActivitie">Daily Activity</param>
		/// <param name="user">User</param>
		public ActivityControl(DailyActivitie dailyActivitie, User user)
		{
			this.user = user;
			this.dailyActivitie = dailyActivitie;
			InitializeComponent();
			UpdateLabels(null, EventArgs.Empty);
		}

		/// <summary>
		/// On Button Edit Click event
		/// </summary>
		private void buttonEdit_Click(object sender, EventArgs e)
		{
			Form editDailyActivitie = new UpdateDailyActivitieForm(dailyActivitie, user);
			editDailyActivitie.ShowDialog();
			editDailyActivitie.Closed += UpdateLabels;
		}

		/// <summary>
		///  On Button Delete Click event
		/// </summary>
		private void button2_Click(object sender, EventArgs e)
		{
			Database db = new Database();
			db.DailyActivitiesDataDelete(dailyActivitie);
			PanelsForm form = Application.OpenForms["PanelsForm"] as PanelsForm;
			form.RefreshPanels();
			MessageBox.Show("Success");
		}

		/// <summary>
		/// Method that update labels 
		/// </summary>
		private void UpdateLabels(object sender, EventArgs e)
		{
			labelName.Text = dailyActivitie.Activitie.Name;
			labelDescription.Text = dailyActivitie.Activitie.Description;
			labelCalories.Text = Convert.ToString(dailyActivitie.Activitie.Calories);
		}
	}
}
