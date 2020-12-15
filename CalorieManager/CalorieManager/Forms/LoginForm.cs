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
using CalorieManager.Forms;

namespace CalorieManager
{
	public partial class LoginForm : Form
	{
		/// <summary>
		/// Constructor of Login Form Class
		/// </summary>
		public LoginForm()
		{
			InitializeComponent();
			LoadUsers();
		}

		/// <summary>
		/// Event when clicked on button "New Profile"
		/// </summary>
		private void buttonNewProfile_Click(object sender, EventArgs e)
		{
			Form newProfileForm = new NewProfileForm();
			newProfileForm.ShowDialog();
			newProfileForm.Closed += OnNewProfileFormClosed;
			LoadLastUser();
		}

		/// <summary>
		/// Method that load users form DB into Combo Box
		/// </summary>
		private void LoadUsers()
		{
            Database db = new Database();
            List<User> usersList = db.UsersDataCollection();

			foreach (User user in usersList)
			{
				comboBoxProfiles.Items.Add(user);
			}
        }

		/// <summary>
		/// Method that loads last user
		/// </summary>
        private void LoadLastUser()
        {
			Database db = new Database();
            List<User> usersList = db.UsersDataCollection();
            comboBoxProfiles.Items.Add(usersList.Last());
        }

		/// <summary>
		/// Event when clicked on button "Select"
		/// </summary>
		private void buttonSelect_Click(object sender, EventArgs e)
		{
			if (comboBoxProfiles.SelectedItem != null)
			{
				Form mainForm = new MainForm((User)comboBoxProfiles.SelectedItem);
				this.Hide();
				mainForm.Closed += (s, args) => this.Close();
				mainForm.Show();
			}
			else
			{
				const string message = "Select profile!";
				const string caption = "Error";
				MessageBox.Show(message, caption);
			}

		}

		/// <summary>
		/// Event that load profiles after newProfileForm is closed
		/// </summary>
		private void OnNewProfileFormClosed(object sender, EventArgs e)
		{
			LoadUsers();
        }
	}
}
