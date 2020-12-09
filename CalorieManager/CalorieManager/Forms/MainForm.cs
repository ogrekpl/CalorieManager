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
		public MainForm(User user)
		{
			InitializeComponent();
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
    }
}
