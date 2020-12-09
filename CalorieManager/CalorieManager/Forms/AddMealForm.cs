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
	public partial class AddMealForm : Form
	{
		public AddMealForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Event when clicked on button "New"
		/// </summary>
		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (inputName.Text != string.Empty)
			{
				Database db = new Database();
	
				Meal meal = new Meal(inputName.Text, inputDescription.Text, (int)inputCalories.Value, (int)inputProteins.Value, 
					(int)inputFats.Value, (int)inputCarbohydrates.Value);

				db.MealDataAdd(meal);
                this.Close();
			}
			else
			{
				const string message = "Enter name of activity!";
				const string caption = "Error";
				MessageBox.Show(message, caption);
			}
		}

        private void AddMealForm_Load(object sender, EventArgs e)
        {

        }
    }
}
