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
	public partial class DailySummaryForm : Form
	{
		private User user;
		private DateTime activeDate;
		public DailySummaryForm(User user)
		{
			this.user = user;
			InitializeComponent();
		}

		private void buttonAddActivity_Click(object sender, EventArgs e)
		{

		}

		private void buttonAddMeal_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			activeDate = dateTimePicker1.Value;
		}
	}
}
