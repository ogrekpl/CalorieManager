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
			Form addActivityForm = new AddActivityForm();
            this.Hide();
			addActivityForm.Show();
		}

        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
			Form addMealForm = new AddMealForm();
            this.Hide();
            addMealForm.Show();
		}

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeCaloriesGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form updateKcalGoal = new UpdateKcalGoal(user);
            updateKcalGoal.Show();
        }

        private void changeWeightGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form updateWeightGoal = new UpdateWeightGoal(user);
            updateWeightGoal.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wylogowano użytkownika " + user.Name);
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
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
