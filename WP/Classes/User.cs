using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WP.Classes
{
    class User
    {
        MY_DB db = new MY_DB();

        public bool InsertUser(int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [User] (id, fname, lname, username, password, picture) " +
                                                "VALUES (@id, @fname, @lname, @username, @password, @picture)", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool CheckUsernameExist(string username, string operation, int id = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM [User] WHERE username = @username";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM [User] WHERE username = @username AND id <> @id";
            }

            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateUser(int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE [User] " +
                                                "SET id=@id, " +
                                                    "fname=@fname, " +
                                                    "lname=@lname, " +
                                                    "username=@username, " +
                                                    "password=@password, " +
                                                    "picture=@picture",
                                                    db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable GetTable(string query)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand(query, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "User");
            db.closeConnection();

            DataTable table = dataSet.Tables["User"];
            return table;
        }

        public DataTable GetUserByID(int id)
        {
            string query = $"SELECT * FROM [User] WHERE id = {id}";
            return this.GetTable(query);
        }

        public string GetUserFullNameByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT CONCAT(TRIM(lname), ' ', TRIM(fname)) FROM [User] WHERE id = @id", 
                                                db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows[0][0].ToString().Trim();
        }
    }
}
