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

namespace CalorieManager.Controls
{
	public partial class MealControl : UserControl
	{
		public MealControl(DailyMeal meal)
		{
			InitializeComponent();
		}
	}
}
