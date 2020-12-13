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
    public partial class MonthlySummary : Form
    {
        private DateTime dateTime;
        private User user;
        private Database database;

        /// <summary>
        /// Constructor of class MonthlySummary
        /// </summary>
        /// <param name="dateTime">Date</param>
        /// <param name="user">User</param>
        public MonthlySummary(DateTime dateTime, User user)
        {
            this.dateTime = dateTime;
            this.user = user;
            database = new Database();
            InitializeComponent();
            LoadTextForSummary();
        }

        /// <summary>
        /// Load information to Weekly Summary Form
        /// </summary>
        /// <param name="dateTime">Date</param>
        /// <param name="user">User</param>
        private void LoadTextForSummary()
        {
            double[] result = database.MonthlySummaryDataCollection(user, dateTime);
            int score = (int) result[1] - (int) result[2];
            MonthlySummaryTitle.Text = "Summmary for month " + dateTime.Month + "." + dateTime.Year;
            MonthlySummaryCalories.Text = "Your monthly score is " + score + " from declare " + (int)result[0]*user.CaloriesGoal + " kcal.";
            MonthlySummaryActivities.Text = "During your actvities in following month you have burned " + (int)result[2] + " kcal ";
            MonthlySummaryScore.Text = "Yo've reached your daily score on " + (int)result[3] + " days";
            
            if (result[4] == 0)
            {
                MonthlySummaryWeightChange.Text = "Your weight doesn't change in following month";
                if ((int)result[3] == (int)result[0])
                {
                    MonthlySummaryCommentValue.Text = "Super, you've fully reached your daily calories goal!";
                }
                else
                {
                    MonthlySummaryCommentValue.Text = "You've reached your daily calories goal, but not fully!";
                }
            }
            else if (result[4] > 0)
            {
                MonthlySummaryWeightChange.Text = "You lost weight by " + result[4] + " kg in following month";
                if ((int)result[3] == (int)result[0])
                {
                    MonthlySummaryCommentValue.Text = "Super, you've fully reached your daily calories goal!";
                }
                else
                {
                    MonthlySummaryCommentValue.Text = "You've reached your daily calories goal, but not fully!";
                }
            }
            else
            {
                MonthlySummaryWeightChange.Text = "You have gained " + -result[4] + " kg in following month";
                MonthlySummaryCommentValue.Text = "Unfornunately you've not reached your monthly calories goal.";
            }
        }

        private void WeeklySummaryCalories_Click(object sender, EventArgs e)
        {

        }

        private void MonthlySummary_Load(object sender, EventArgs e)
        {

        }
    }
}
