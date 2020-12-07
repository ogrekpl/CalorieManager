using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalorieManager
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
            server = "localhost";
            databaseName = "CMDatabase";
            uid = "root";
            password = "";

            string connectionString = "SERVER=" + server + ";DATABASE=" + databaseName + ";UID=" + uid + ";PASSWORD=" + password;

            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

    }
}
