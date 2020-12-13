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
		public ActivityControl(DailyActivitie dailyActivitie)
		{
			this.dailyActivitie = dailyActivitie;
			InitializeComponent();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			Form editDailyActivitie = new UpdateDailyActivitieForm(dailyActivitie);
			editDailyActivitie.ShowDialog();
			editDailyActivitie.Closed += updateLabels;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Database db = new Database();
			db.DailyActivitiesDataDelete(dailyActivitie);
			//usun z wyświetlania
			PanelsForm form = Application.OpenForms["DailySummaryForm"] as PanelsForm;
			form.RefreshPanels();
			MessageBox.Show("Success.");
		}

		private void updateLabels(object sender, EventArgs e)
		{
			
		}
	}
}
