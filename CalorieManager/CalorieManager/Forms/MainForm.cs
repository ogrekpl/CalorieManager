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
	public partial class MainForm : Form
    {
        private User user;
        private Form activeForm;

		public MainForm(User user)
        {
            this.user = user;
            activeForm = null;
            InitializeComponent();
            showChildForm(new PanelsForm(user));
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {

		}

        private void buttonAddMeal_Click(object sender, EventArgs e)
        {

		}

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event when clicked on button "Change Calories Goal" in Strip Menu "Profile" -> "Edit Profile"
        /// </summary>

        private void changeCaloriesGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form updateKcalGoal = new UpdateKcalGoal(user);
            updateKcalGoal.ShowDialog();
        }

        /// <summary>
        /// Event when clicked on button "Change Weight Goal" in Strip Menu "Profile" -> "Edit Profile"
        /// </summary>

        private void changeWeightGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form updateWeightGoal = new UpdateWeightGoal(user);
            updateWeightGoal.ShowDialog();
        }

        /// <summary>
        /// Event when clicked on button "Logout" in Strip Menu "Profile"
        /// </summary>

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wylogowano użytkownika " + user.Name);
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        /// <summary>
        /// Event when clicked on button "New Meal" in Strip Menu "New"
        /// </summary>

        private void newMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addMealForm = new AddMealForm();
            addMealForm.ShowDialog();
        }

        /// <summary>
        /// Event when clicked on button "New Activity" in Strip Menu "New"
        /// </summary>

        private void newActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addActivityForm = new AddActivityForm();
            addActivityForm.ShowDialog();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dailySummary = new DailySummary(DateTime.Today, user);
            dailySummary.ShowDialog();
        }
        private void showChildForm(Form childForm)
        {
	        if (activeForm != null)
	        {
		        activeForm.Close();
	        }

	        activeForm = childForm;
	        childForm.TopLevel = false;
	        childForm.FormBorderStyle = FormBorderStyle.None;
	        childForm.Dock = DockStyle.Fill;
	        panelChildForm.Controls.Add(childForm);
	        panelChildForm.Tag = childForm;
	        childForm.BringToFront();
	        childForm.Show();
        }
    }
}
