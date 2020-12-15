using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private DateTime date;

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        /// <summary>
        /// Constructor of MainForm class
        /// </summary>
        /// <param name="user">User</param>
		public MainForm(User user)
        {
            this.user = user;
            activeForm = null;
            InitializeComponent();
            showChildForm(new PanelsForm(user));
            date = DateTime.Today;
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
            MessageBox.Show("Logout of user " + user.Name + " was successful");
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

        /// <summary>
        /// Show Daily Summary
        /// </summary>
        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsForm form = Application.OpenForms["Panelsform"] as PanelsForm;
            if (form != null)
            {
                date = form.GetDate();
            }
            showChildForm(new DailySummary(date, user));
        }

        /// <summary>
        /// Method that display Form in Panel
        /// </summary>
        /// <param name="childForm">Form that will be shown</param>
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
	        panelChild.Controls.Add(childForm);
	        panelChild.Tag = childForm;
	        childForm.BringToFront();
	        childForm.Show();
        }

        /// <summary>
        /// Show Weekly Summary
        /// </summary>
        private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsForm form = Application.OpenForms["Panelsform"] as PanelsForm;
            if (form != null)
            {
                date = form.GetDate();
            }
            showChildForm(new WeeklySummary(date, user));
            
        }

        /// <summary>
        /// Show Monthly Summary
        /// </summary>
        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelsForm form = Application.OpenForms["Panelsform"] as PanelsForm;
            if (form != null)
            {
                date = form.GetDate();
            }
            showChildForm(new MonthlySummary(date, user));
            
        }

        private void manageCaloriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showChildForm(new PanelsForm(user));
        }
    }
}
