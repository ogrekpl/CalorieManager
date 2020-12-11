﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace CalorieManager.Classes
{
    class Database
    {
        private SqlConnection connection;
        private string server;
        private string databaseName;
        private string uid;
        private string password;

        /// <summary>
        /// Constructor of class Database
        /// </summary>
        /// <param name="server"></param>
        /// <param name="databaseName"></param>
        /// <param name="uid"></param>
        /// <param name="password"></param>
        /// <param name="connection"></param>
        public Database()
        {
            server = System.Windows.Forms.SystemInformation.ComputerName + @"\ADIX155";
            databaseName = "CMDatabase";
            uid = @"test";
            password = "CMDatabase";

            string connectionString = "SERVER=" + server + ";DATABASE=" + databaseName + ";UID=" + uid + ";PASSWORD=" + password + ";MultipleActiveResultSets=true";

            connection = new SqlConnection(connectionString);
        }

        //User Methods:

        public List<User> UsersDataCollection()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM Users";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string query2 = "SELECT * FROM WeightHistory WHERE Id = @ID";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.Add("@ID", SqlDbType.Int);
                cmd2.Parameters["@ID"].Value = id;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                Dictionary<DateTime, double> weightHistory = new Dictionary<DateTime, double>();
                while (reader2.Read())
                {
                    DateTime data = reader2.GetDateTime(2);
                    double weight = Convert.ToDouble(reader2.GetDecimal(1));
                    weightHistory.Add(data, weight);
                }
                User newUser = new User(
                    Convert.ToUInt32(reader.GetInt32(0)),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetInt32(4),
                    Convert.ToDouble(reader.GetDecimal(5)),
                    weightHistory);

                users.Add(newUser);
            }
            connection.Close();
            return users;
        }

        public void UserDataAdd(User user)
        {
            connection.Open();
            string query =
                "INSERT INTO Users(Name, Age, Height, KcalGoal, WeightGoal) VALUES (@NAME, @AGE, @HEIGHT, @KCALGOAL, @WEIGHTGOAL)";
            string query2 = 
                "INSERT INTO WeightHistory(Weight, Date, UserID) VALUES (@WEIGHT, @DATE, @USERID)";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlCommand cmd2 = new SqlCommand(query2, connection);

            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar);
            cmd.Parameters.Add("@AGE", SqlDbType.Int);
            cmd.Parameters.Add("@HEIGHT", SqlDbType.Decimal);
            cmd.Parameters.Add("@KCALGOAL", SqlDbType.Int);
            cmd.Parameters.Add("@WEIGHTGOAL", SqlDbType.Decimal);
            cmd2.Parameters.Add("@WEIGHT", SqlDbType.Decimal);
            cmd2.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd2.Parameters.Add("@USERID", SqlDbType.Int);

            cmd.Parameters["@NAME"].Value = user.Name;
            cmd.Parameters["@AGE"].Value = user.Age;
            cmd.Parameters["@HEIGHT"].Value = user.Height;
            cmd.Parameters["@KCALGOAL"].Value = user.CaloriesGoal;
            cmd.Parameters["@WEIGHTGOAL"].Value = user.WeightGoal;
            cmd2.Parameters["@WEIGHT"].Value = user.WeightHistory.Values.First();
            cmd2.Parameters["@DATE"].Value = user.WeightHistory.Keys.First();
            

            cmd.ExecuteNonQuery();

            string query3 = "SELECT Id FROM Users ORDER BY Id DESC";
            SqlCommand cmd3 = new SqlCommand(query3, connection);
            SqlDataReader reader = cmd3.ExecuteReader();
            int a = 1;
            int id = new int();
            while (reader.Read() && a == 1)
            {
                id = reader.GetInt32(0);
                a++;
            }
            reader.Close();
            cmd2.Parameters["@USERID"].Value = id;
            cmd2.ExecuteNonQuery();

            connection.Close();
        }

        public void UserDataUpdate(User user)
        {
            connection.Open();

            string query = "UPDATE Users SET KcalGoal = @KCALGOAL, WeightGoal = @WEIGHTGOAL WHERE Id = @ID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@KCALGOAL", SqlDbType.Int);
            cmd.Parameters.Add("@WEIGHTGOAL", SqlDbType.Decimal);
            cmd.Parameters.Add("@ID", SqlDbType.Int);

            cmd.Parameters["@KCALGOAL"].Value = user.CaloriesGoal;
            cmd.Parameters["@WEIGHTGOAL"].Value = user.WeightGoal;
            cmd.Parameters["@ID"].Value = user.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //Activity Methods:

        public void ActivityDataAdd(Activity activity)
        {
            connection.Open();
            string query =
                "INSERT INTO Activities(Name, Description, Calories) VALUES (@NAME, @DESCRIPTION, @CALORIES)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DESCRIPTION", SqlDbType.NVarChar);
            cmd.Parameters.Add("@CALORIES", SqlDbType.Int);

            cmd.Parameters["@NAME"].Value = activity.Name;
            cmd.Parameters["@DESCRIPTION"].Value = activity.Description;
            cmd.Parameters["@CALORIES"].Value = activity.Calories;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //Daily Activities Methods:

        public void DailyActivitiesDataAdd(DailyActivities dailyActivities, User user)
        {
            connection.Open();
            string query =
                "INSERT INTO DailyActivities(Activity, Date, UserId) VALUES (@ACTIVITY, @DATE, @USERID)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@ACTIVITY", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters.Add("@USERID", SqlDbType.Int);

            cmd.Parameters["@ACTIVITY"].Value = dailyActivities.Activities.Last();
            cmd.Parameters["@DATE"].Value = dailyActivities.Date;
            cmd.Parameters["@USERID"].Value = user.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void DailyActivitiesDataUpdate(Activity activity, DailyActivities dailyActivities, User user)
        {
            connection.Open();

            string query = "UPDATE DailyActivities SET Activity = @ACTIVITY, Date = @DATE, UserId = @USERID WHERE Id = @ID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@ACTIVITY", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters.Add("@ID", SqlDbType.Int);

            cmd.Parameters["@ACTIVITY"].Value = activity.Id;
            cmd.Parameters["@DATE"].Value = dailyActivities.Date;
            cmd.Parameters["@USERID"].Value = user.Id;
            cmd.Parameters["@ID"].Value = dailyActivities.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void DailyActivitiesDataDelete(DailyActivities dailyActivities)
        {
            connection.Open();

            string query =
                "DELETE FROM DailyActivities WHERE Id = @USERID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters["@USERID"].Value = dailyActivities.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //Meal Methods:

        public void MealDataAdd(Meal meal)
        {
            connection.Open();
            string query =
                "INSERT INTO Meal(Name, Description, Kcal, Protein, Fat, Hydrocarbon) VALUES (@NAME, @DESCRIPTION, @CALORIES, @PROTEIN, @FAT, @HYDROCARBON)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DESCRIPTION", SqlDbType.NVarChar);
            cmd.Parameters.Add("@CALORIES", SqlDbType.Int);
            cmd.Parameters.Add("@PROTEIN", SqlDbType.Int);
            cmd.Parameters.Add("@FAT", SqlDbType.Int);
            cmd.Parameters.Add("@HYDROCARBON", SqlDbType.Int);

            cmd.Parameters["@NAME"].Value = meal.Name;
            cmd.Parameters["@DESCRIPTION"].Value = meal.Description;
            cmd.Parameters["@CALORIES"].Value = meal.Kcal;
            cmd.Parameters["@PROTEIN"].Value = meal.Protein;
            cmd.Parameters["@FAT"].Value = meal.Fat;
            cmd.Parameters["@HYDROCARBON"].Value = meal.Hydrocarbon;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //Daily Meals Methods:

        public void DailyMealsDataAdd(DailyMeals dailyMeals, User user)
        {
            connection.Open();
            string query =
                "INSERT INTO DailyMeals(Meal, Date, UserId) VALUES (@MEAL, @DATE, @USERID)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@MEAL", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters.Add("@USERID", SqlDbType.Int);

            cmd.Parameters["@ACTIVITY"].Value = dailyMeals.Meals.Last();
            cmd.Parameters["@DATE"].Value = dailyMeals.Date;
            cmd.Parameters["@USERID"].Value = user.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void DailyMealsDataUpdate(Meal meal, DailyMeals dailyMeals, User user)
        {
            connection.Open();

            string query = "UPDATE DailyMeals SET Meals = @MEALS, Date = @DATE, UserId = @USERID WHERE Id = @ID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@ACTIVITY", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters.Add("@ID", SqlDbType.Int);

            cmd.Parameters["@ACTIVITY"].Value = meal.Id;
            cmd.Parameters["@DATE"].Value = dailyMeals.Date;
            cmd.Parameters["@USERID"].Value = user.Id;
            cmd.Parameters["@ID"].Value = dailyMeals.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void DailyMealsDataDelete(DailyMeals dailyMeals)
        {
            connection.Open();

            string query =
                "DELETE FROM DailyActivities WHERE Id = @USERID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters["@USERID"].Value = dailyMeals.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

    }
}
