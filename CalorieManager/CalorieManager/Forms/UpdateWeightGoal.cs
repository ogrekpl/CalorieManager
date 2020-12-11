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
        public UpdateWeightGoal(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void newWeightGoalValue_Click(object sender, EventArgs e)
        {
            user.WeightGoal = Convert.ToDouble(newKcalGoal.Text);
            Database db = new Database();
            db.UserDataUpdate(user);
            MessageBox.Show("Operacja zakończona sukcesem");
            Form mainForm = new MainForm(user);
            this.Hide();
            mainForm.Show();
        }
    }
}
