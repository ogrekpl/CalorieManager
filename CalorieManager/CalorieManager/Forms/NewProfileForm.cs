using CalorieManager.Classes;
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

			if (inputName.Text == string.Empty)
			{
				const string message = "Enter name!";
				const string caption = "Error";
				MessageBox.Show(message, caption);
			}
			else
			{
				Database db = new Database();
				db.UserDataAdd(CreateUserFromForm());
				this.Close();
                const string message = "New user was added to database";
                const string caption = "Success";
                MessageBox.Show(message, caption);
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
				new Dictionary<DateTime, double>(){{DateTime.Now, Convert.ToDouble(inputWeight.Value)}});
		}

    }
}
