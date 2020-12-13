using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Crmf;


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
        /// <param name="server">Server</param>
        /// <param name="databaseName">Database Name</param>
        /// <param name="uid">User ID</param>
        /// <param name="password">Password</param>
        /// <param name="connection">Connection String</param>
        public Database()
        {
            server = System.Windows.Forms.SystemInformation.ComputerName + @"\ADIX155";
            databaseName = "CMDatabase";
            uid = @"test";
            password = "CMDatabase";

            string connectionString = "SERVER=" + server + ";DATABASE=" + databaseName + ";UID=" + uid + ";PASSWORD=" + password + ";MultipleActiveResultSets=true";

            connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Collection of User from Database
        /// </summary>
        /// <returns>List of Users</returns>

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

        /// <summary>
        /// Add new User to Database
        /// </summary>
        /// <param name="user">User</param>

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

        /// <summary>
        /// Update of User data in Database
        /// </summary>
        /// <param name="user">User</param>

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

        /// <summary>
        /// Add new Activity to Database
        /// </summary>
        /// <param name="activity">Activity</param>

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

        /// <summary>
        /// Collect list of all Activites from Database
        /// </summary>
        /// <returns></returns>

        public List<Activity> ActivityDataCollection()
        {
            List<Activity> activities = new List<Activity>();

            connection.Open();
            string query = "SELECT * FROM Activities";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Activity activity = new Activity((uint)reader.GetInt32(0), reader.GetString(1), reader.GetString(2), 
                    reader.GetInt32(3));
                activities.Add(activity);
            }

            connection.Close();
            return activities;
        }

        /// <summary>
        /// Add new DailyActivities to Database
        /// </summary>
        /// <param name="dailyActivities">Daily Activities</param>
        /// <param name="user"User>User</param>

        public void DailyActivitiesDataAdd(DailyActivitie dailyActivities, User user)
        {
            connection.Open();
            string query =
                "INSERT INTO DailyActivities(Activity, Date, UserId) VALUES (@ACTIVITY, @DATE, @USERID)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@ACTIVITY", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters.Add("@USERID", SqlDbType.Int);

            cmd.Parameters["@ACTIVITY"].Value = dailyActivities.Activitie.Id;
            cmd.Parameters["@DATE"].Value = dailyActivities.Date;
            cmd.Parameters["@USERID"].Value = user.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// Update DailyActivities in Database
        /// </summary>
        /// <param name="activity">Activity</param>
        /// <param name="dailyActivities">Daily Activities</param>
        /// <param name="user">User</param>
        public void DailyActivitiesDataUpdate(Activity activity, DailyActivitie dailyActivities, User user)
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

        /// <summary>
        /// Delete Daily Activities from Database
        /// </summary>
        /// <param name="dailyActivities">Daily Activities</param>
        public void DailyActivitiesDataDelete(DailyActivitie dailyActivities)
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

        /// <summary>
        /// Collect all of Daily Activities form Database, which are connected to User Id
        /// </summary>
        /// <param name="user">User</param>
        /// <returns></returns>
        public List<DailyActivitie> DailyActivitiesDataCollection(User user)
        {
            List<DailyActivitie> dailyActivities = new List<DailyActivitie>();

            connection.Open();
            string query = "SELECT * FROM DailyActivities WHERE UserId = @USERID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters["@USERID"].Value = user.Id;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Activity activity = new Activity(1, "a", "a", 1);
                int activityId = reader.GetInt32(1);
                string query2 = "SELECT * FROM Activities WHERE Id = @ID";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.Add("@ID", SqlDbType.Int);
                cmd2.Parameters["@ID"].Value = activityId;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                int a = 0;
                while (reader2.Read() && a == 0)
                {
                    Activity newActivity = new Activity((uint)reader2.GetInt32(0), reader2.GetString(1), reader2.GetString(2),
                        reader2.GetInt32(3));
                    a++;
                    activity = newActivity;
                }
                
                reader2.Close();
                DailyActivitie dailyActivity = new DailyActivitie((uint)reader.GetInt32(0), activity, reader.GetDateTime(2));
                dailyActivities.Add(dailyActivity);
            }
            reader.Close();

            connection.Close();
            return dailyActivities;
        }

        /// <summary>
        /// Collect all of Daily Activities form Database, which are connected to User Id, at specified Date
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="date">Date</param>
        /// <returns></returns>
        public List<DailyActivitie> DailyActivitiesDataCollectionDate(User user, DateTime date)
        {
            List<DailyActivitie> dailyActivities = new List<DailyActivitie>();

            connection.Open();
            string query = "SELECT * FROM DailyActivities WHERE UserId = @USERID AND Date = @DATE";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters["@USERID"].Value = user.Id;
            cmd.Parameters["@DATE"].Value = date.Date;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Activity activity = new Activity(1, "a", "a", 1);
                int activityId = reader.GetInt32(1);
                string query2 = "SELECT * FROM Activities WHERE Id = @ID";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.Add("@ID", SqlDbType.Int);
                cmd2.Parameters["@ID"].Value = activityId;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                int a = 0;
                while (reader2.Read() && a == 0)
                {
                    Activity newActivity = new Activity((uint)reader2.GetInt32(0), reader2.GetString(1), reader2.GetString(2),
                        reader2.GetInt32(3));
                    a++;
                    activity = newActivity;
                }

                reader2.Close();
                DailyActivitie dailyActivity = new DailyActivitie((uint)reader.GetInt32(0), activity, date.Date);
                dailyActivities.Add(dailyActivity);
            }
            reader.Close();

            connection.Close();
            return dailyActivities;
        }

        /// <summary>
        /// Add new Meal to Database
        /// </summary>
        /// <param name="meal">Meal</param>
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

        /// <summary>
        /// Collect list of all Meals from Database
        /// </summary>
        /// <returns></returns>
        public List<Meal> MealDataCollection()
        {
            List<Meal> meals = new List<Meal>();

            connection.Open();
            string query = "SELECT * FROM Meal";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Meal meal = new Meal((uint)reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                    reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6));
                meals.Add(meal);
            }
            connection.Close();

            return meals;
        }

        /// <summary>
        /// Add new DailyMeals to Database
        /// </summary>
        /// <param name="dailyMeals">Daily Meals</param>
        /// <param name="user">User</param>

        public void DailyMealsDataAdd(DailyMeal dailyMeals, User user)
        {
            connection.Open();
            string query =
                "INSERT INTO DailyMeals(Meal, Date, UserId) VALUES (@MEAL, @DATE, @USERID)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@MEAL", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters.Add("@USERID", SqlDbType.Int);

            cmd.Parameters["@MEAL"].Value = dailyMeals.Meal.Id;
            cmd.Parameters["@DATE"].Value = dailyMeals.Date;
            cmd.Parameters["@USERID"].Value = user.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// Update DailyMeals in Database
        /// </summary>
        /// <param name="meal">Meal</param>
        /// <param name="dailyMeals">Daily Meals</param>
        /// <param name="user">User</param>

        public void DailyMealsDataUpdate(Meal meal, DailyMeal dailyMeals, User user)
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

        /// <summary>
        /// Delete DailyMeals from Database
        /// </summary>
        /// <param name="dailyMeals">Daily Meals</param>

        public void DailyMealsDataDelete(DailyMeal dailyMeals)
        {
            connection.Open();

            string query =
                "DELETE FROM DailyMeals WHERE Id = @USERID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters["@USERID"].Value = dailyMeals.Id;

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// Collect all of Daily Meals form Database, which are connected to User Id
        /// </summary>
        /// <param name="user">User</param>
        /// <returns></returns>
        public List<DailyMeal> DailyMealsDataCollection(User user)
        {
            List<DailyMeal> dailyMeals = new List<DailyMeal>();

            connection.Open();
            string query = "SELECT * FROM DailyMeals WHERE UserId = @USERID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters["@USERID"].Value = user.Id;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Meal meal = new Meal(1, "a", "b", 1, 1, 1, 1);
                int mealId = reader.GetInt32(1);
                string query2 = "SELECT * FROM Meal WHERE Id = @ID";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.Add("@ID", SqlDbType.Int);
                cmd2.Parameters["@ID"].Value = mealId;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                int a = 0;
                while (reader2.Read() && a == 0)
                {
                    Meal newMeal = new Meal((uint)reader2.GetInt32(0), reader2.GetString(1), reader2.GetString(2),
                        reader2.GetInt32(3), reader2.GetInt32(4), reader2.GetInt32(5), reader2.GetInt32(6));
                    a++;
                    meal = newMeal;
                }

                reader2.Close();
                DailyMeal dailyMeal = new DailyMeal((uint)reader.GetInt32(0), meal, reader.GetDateTime(2));
                dailyMeals.Add(dailyMeal);
            }
            reader.Close();

            connection.Close();
            return dailyMeals;
        }

        /// <summary>
        /// Collect all of Daily Meals form Database, which are connected to User Id, at specified Date
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="date">Date</param>
        /// <returns></returns>
        public List<DailyMeal> DailyMealsDataCollectionDate(User user, DateTime date)
        {
            List<DailyMeal> dailyMeals = new List<DailyMeal>();

            connection.Open();
            string query = "SELECT * FROM DailyMeals WHERE UserId = @USERID and Date = @DATE";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd.Parameters["@USERID"].Value = user.Id;
            cmd.Parameters["@DATE"].Value = date.Date;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Meal meal = new Meal(1, "a", "b", 1, 1, 1, 1);
                int mealId = reader.GetInt32(1);
                string query2 = "SELECT * FROM Meal WHERE Id = @ID";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.Add("@ID", SqlDbType.Int);
                cmd2.Parameters["@ID"].Value = mealId;
                SqlDataReader reader2 = cmd2.ExecuteReader();
                int a = 0;
                while (reader2.Read() && a == 0)
                {
                    Meal newMeal = new Meal((uint)reader2.GetInt32(0), reader2.GetString(1), reader2.GetString(2),
                        reader2.GetInt32(3), reader2.GetInt32(4), reader2.GetInt32(5), reader2.GetInt32(6));
                    a++;
                    meal = newMeal;
                }

                reader2.Close();
                DailyMeal dailyMeal = new DailyMeal((uint)reader.GetInt32(0), meal, reader.GetDateTime(2));
                dailyMeals.Add(dailyMeal);
            }
            reader.Close();

            connection.Close();
            return dailyMeals;
        }

        /// <summary>
        /// Get necessary data to Daily Summary 
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="dateTime">Date</param>
        /// <returns></returns>
        public int[] DailySummary(User user, DateTime dateTime)
        {
            string query =
                "SELECT Meal FROM DailyMeals WHERE UserId = @USERID AND Date = @DATE";
            string query2 =
                "SELECT Kcal FROM Meal WHERE Id = @ID";
            string query3 =
                "SELECT Activity FROM DailyActivities WHERE UserId = @USERID AND Date = @DATE";
            string query4 =
                "SELECT Calories FROM Activities WHERE Id = @ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlCommand cmd2 = new SqlCommand(query2, connection);
            SqlCommand cmd3 = new SqlCommand(query3, connection);
            SqlCommand cmd4 = new SqlCommand(query4, connection);

            cmd.Parameters.Add("@USERID", SqlDbType.Int);
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd2.Parameters.Add("@ID", SqlDbType.Int);
            cmd3.Parameters.Add("@USERID", SqlDbType.Int);
            cmd3.Parameters.Add("@DATE", SqlDbType.DateTime);
            cmd4.Parameters.Add("@ID", SqlDbType.Int);

            cmd.Parameters["@DATE"].Value = dateTime.Date;
            cmd.Parameters["@USERID"].Value = user.Id;
            cmd3.Parameters["@DATE"].Value = dateTime.Date;
            cmd3.Parameters["@USERID"].Value = user.Id;

            List<Int32> dailyMeals = new List<int>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dailyMeals.Add(reader.GetInt32(0));
            }
            reader.Close();

            List<Int32> dailyMealsKcalSum = new List<int>();

            for (int i = 0; i < dailyMeals.Count; i++)
            {
                cmd2.Parameters["@ID"].Value = dailyMeals[i];
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    dailyMealsKcalSum.Add(reader2.GetInt32(0));
                }
                reader2.Close();
            }
            

            int dailyCaloriesSum = dailyMealsKcalSum.Sum();

            List<Int32> dailyActivities = new List<int>();

            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                dailyMeals.Add(reader3.GetInt32(0));
            }
            reader3.Close();

            List<Int32> dailyActivitiesKcalSum = new List<int>();

            for (int i = 0; i < dailyActivities.Count; i++)
            {
                cmd4.Parameters["@ID"].Value = dailyActivities[i];
                SqlDataReader reader4 = cmd4.ExecuteReader();
                while (reader4.Read())
                {
                    dailyMealsKcalSum.Add(reader4.GetInt32(0));
                }
                reader4.Close();
            }

            int dailyActivitySum = dailyActivitiesKcalSum.Sum();

            return new[] {dailyCaloriesSum, dailyActivitySum};
        }

        /// <summary>
        /// Get data to Daily Summary Form
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public int[] DailySummaryDataCollection(User user, DateTime dateTime)
        {
            connection.Open();
            int[] result = DailySummary(user, dateTime);
            connection.Close();
            return result;
        }

        /// <summary>
        /// Get data to Weekly Summary Form
        /// </summary>
        /// <param name="user">User</param>
        /// <param name="todayDate">Date of following day - method computes Start/EndDate itself</param>
        /// <returns></returns>
        public int[] WeeklySummaryDataCollection(User user, DateTime todayDate)
        {
            connection.Open();

            int delta = DayOfWeek.Monday - todayDate.DayOfWeek;
            if (delta > 0)
            {
                delta -= 7;
            }

            List<DateTime> week = new List<DateTime>();
            DateTime monday = todayDate.AddDays(delta);
            week.Add(monday);

            for (int i = 1; i < 7; i++)
            {
                DateTime nextDay = week[i - 1].AddDays(1);
                week.Add(nextDay);
            }

            int[,] dailySummaries = new int[week.Count, 2];

            for (int i = 0; i < week.Count; i++)
            {
                int[] dailyResult = DailySummary(user, week[i]);
                for (int j = 0; j < dailyResult.Length; j++)
                {
                    dailySummaries[i, j] = dailyResult[j];
                }
            }

            int weeklyCalories = 0;
            int weeklyActivities = 0;
            int weeklyReachedGoals = 0;
            for (int i = 0; i < dailySummaries.Length/2; i++)
            {
                weeklyCalories += dailySummaries[i, 0];
                weeklyActivities += dailySummaries[i, 1];
                if (dailySummaries[i,0] - dailySummaries[i,1] <= user.CaloriesGoal)
                {
                    weeklyReachedGoals += 1;
                }
            }
            return new int[] {monday.Day, monday.Month, monday.Year, week.Last().Day, week.Last().Month, week.Last().Year,
                weeklyCalories, weeklyActivities, weeklyReachedGoals};
        }

    }
}
