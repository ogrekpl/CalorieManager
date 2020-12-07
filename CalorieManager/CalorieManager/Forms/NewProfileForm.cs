using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieManager
{
	public partial class NewProfileForm : Form
	{

		public NewProfileForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// On button clicked method
		/// </summary>
		private void buttonCreateProfile_Click(object sender, EventArgs e)
		{

			if (String.IsNullOrEmpty(inputName.Text))
			{
				const string message = "Enter name!";
				const string caption = "Error";
				MessageBox.Show(message, caption);
			}
			else
			{
				Database db = new Database();
				db.UserDataAdd(CreateUserFromForm());

			}
		}

		/// <summary>
		/// Method that create user from form
		/// </summary>
		/// <returns>New object of class User</returns>
		private User CreateUserFromForm()
		{
			return new User(inputName.Text, Convert.ToInt32(inputAge.Text), Convert.ToInt32(inputHeight.Value), 
				Convert.ToInt32(inputKcalGoal.Value), Convert.ToDouble(inputWeightGoal.Value), 
				new Dictionary<DateTime, double>(){{DateTime.Today, Convert.ToDouble(inputWeight.Value)}});
		}
	}
}
