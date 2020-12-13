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
		public UpdateDailyMealForm(DailyMeal dailyMeal)
		{
			this.dailyMeal = dailyMeal;
			InitializeComponent();
		}

		private void buttonNew_Click_1(object sender, EventArgs e)
		{
			Database db = new Database();
			//Update DailyAcctivitie Method
			this.Close();
			const string message = "Activitie has been updated.";
			const string caption = "Success";
			MessageBox.Show(message, caption);
		}
	}
}
