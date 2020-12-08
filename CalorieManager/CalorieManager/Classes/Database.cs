using System;
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
            server = @"ADRIAN\ADIX155";
            databaseName = "CMDatabase";
            uid = @"test";
            password = "CMDatabase";

            string connectionString = "SERVER=" + server + ";DATABASE=" + databaseName + ";UID=" + uid + ";PASSWORD=" + password;

            connection = new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = server,
                    InitialCatalog = databaseName,
                    UserID = uid,
                    Password = password
                }.ConnectionString
            );


        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

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
                    weightHistory.Add(reader2.GetDateTime(2), reader2.GetDouble(1));
                }

                User newUser = new User(
                    (uint)reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetInt32(4),
                    reader.GetDouble(5),
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
        

    }
}
