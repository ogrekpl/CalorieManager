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
	public partial class UpdateDailyActivitie : Form
	{
		private DailyActivitie dailyActivitie;
		public UpdateDailyActivitie(DailyActivitie dailyActivitie)
		{
			InitializeComponent();
		}
	}
}
