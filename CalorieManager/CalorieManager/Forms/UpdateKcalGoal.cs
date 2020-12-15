﻿using System;
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
    public partial class UpdateKcalGoal : Form
    {
        private User user;
        public UpdateKcalGoal(User user)
        {
            this.user = user;
            InitializeComponent();
            initializeInputsDefValue();
        }

        /// <summary>
        /// Event when clicked on button "Set"
        /// </summary>

        private void newKcalGoalValue_Click(object sender, EventArgs e)
        {
            user.CaloriesGoal = Convert.ToInt32(newKcalGoal.Text);
            Database db = new Database();
            db.UserDataUpdate(user);
            MessageBox.Show("Operacja zakończona sukcesem");
            this.Hide();
        }

        private void newKcalGoal_TextChanged(object sender, EventArgs e)
        {

        }

        private void initializeInputsDefValue()
        {
	        newKcalGoal.Text = Convert.ToString(user.CaloriesGoal);
        }

        private void newKcalGoal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateKcalGoal_Load(object sender, EventArgs e)
        {

        }
    }
}
