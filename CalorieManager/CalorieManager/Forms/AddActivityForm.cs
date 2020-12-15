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
	public partial class AddActivityForm : Form
	{
		/// <summary>
		/// Constructor of AddActivityForm class
		/// </summary>
		public AddActivityForm()
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
				Activity activity = new Activity(inputName.Text, inputDescription.Text, (int)inputCalories.Value);
				db.ActivityDataAdd(activity);
				this.Close();
			}
			else
			{
				const string message = "Enter name of activity!";
				const string caption = "Error";
				MessageBox.Show(message, caption);
			}
		}
	}
}
