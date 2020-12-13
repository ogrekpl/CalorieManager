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
    public partial class DailySummary : Form
    {
        private DateTime dateTime;
        private User user;
        private Database database;

        public DailySummary(DateTime dateTime, User user)
        {
            this.dateTime = dateTime;
            this.user = user;
            this.database = new Database();
            InitializeComponent();
            LoadTextForSummary();
        }

        private void LoadTextForSummary()
        {
            int[] results = database.DailySummaryDataCollection(user, dateTime);
            int score = results[0] - results[1];
            DailySummaryTitle.Text = "Summary for date: " + dateTime.Day + "." + dateTime.Month + "." + dateTime.Year;
            DailySummaryCalories.Text = "You ate meals at value " + results[0] + " kcal.";
            DailySummaryDailyActivities.Text = "During your actvities you have burned " + results[1] + " kcal.";
            DailySummaryScore.Text = "Your daily score is " + score + " from declared " + user.CaloriesGoal + " kcal";
            string comment = String.Empty;
            if (score <= user.CaloriesGoal)
            {
                comment = "Super, you've reached your daily calories goal!";
            }
            else
            {
                comment = "Unfornunately you've not reached your daily calories goal.";
            }

            DailySummaryCommentValue.Text = comment;
        }

        private void DailySummary_Load(object sender, EventArgs e)
        {

        }


        private void DailySummaryDailyActivities_Click(object sender, EventArgs e)
        {

        }
    }
}
