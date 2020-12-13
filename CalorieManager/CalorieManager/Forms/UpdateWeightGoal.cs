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
    public partial class UpdateWeightGoal : Form
    {
        private User user;

        /// <summary>
        /// Constructor of class Update Weight Goal
        /// </summary>
        /// <param name="user">User</param>
        public UpdateWeightGoal(User user)
        {
            this.user = user;
            InitializeComponent();
            initializeInputsDefValue();
        }

        /// <summary>
        /// Event when clicked on button "Set"
        /// </summary>

        private void newWeightGoalValue_Click(object sender, EventArgs e)
        {
            user.WeightGoal = Convert.ToDouble(newWeightGoal.Text);
            Database db = new Database();
            db.UserDataUpdate(user);
            MessageBox.Show("Finished with success.");
            this.Hide();
        }

        private void initializeInputsDefValue()
        {
	        newWeightGoal.Text = Convert.ToString(user.WeightGoal);
        }

        private void UpdateWeightGoal_Load(object sender, EventArgs e)
        {

        }
    }
}
