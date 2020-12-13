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
    public partial class WeeklySummary : Form
    {
        private DateTime dateTime;
        private User user;
        private Database database;

        /// <summary>
        /// Constructor of class WeeklySummary
        /// </summary>
        /// <param name="dateTime">Date</param>
        /// <param name="user">User</param>
        public WeeklySummary(DateTime dateTime, User user)
        {
            this.dateTime = dateTime;
            this.user = user;
            database = new Database();
            InitializeComponent();
            LoadTextForSummary(dateTime, user);
        }

        /// <summary>
        /// Load information to Weekly Summary Form
        /// </summary>
        /// <param name="dateTime">Date</param>
        /// <param name="user">User</param>
        private void LoadTextForSummary(DateTime dateTime, User user)
        {
            int[] result = database.WeeklySummaryDataCollection(user, dateTime);
            int score = result[6] - result[7];
            WeeklySummaryTitle2.Text = result[0] + "." + result[1] + "." + result[2] + " - " + result[3] + "." +
                                       result[4] + "." + result[5];
            WeeklySummaryCalories.Text =
                "Your weekly score is " + score + " from declare " + user.CaloriesGoal * 7 + " kcal.";
            WeeklySummaryActivities.Text = "During your actvities in following week you have burned " + result[7] + " kcal ";
            WeeklySummaryScore.Text = "Yo've reached your daily score on " + result[8] + " days";
            if (result[8] == 7)
            {
                WeeklySummaryCommentValue.Text = "Super, you've reached your weekly calories goal!";
            }
            else
            {
                WeeklySummaryCommentValue.Text = "Unfornunately you've not reached your weekly calories goal.";
            }
        }

        private void WeeklySummaryDailyActivities_Click(object sender, EventArgs e)
        {

        }

        private void WeeklySummaryTitle2_Click(object sender, EventArgs e)
        {

        }

        private void WeeklySummary_Load(object sender, EventArgs e)
        {

        }
    }
}
