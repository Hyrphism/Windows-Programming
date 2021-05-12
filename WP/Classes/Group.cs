using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP.Classes
{
    class Group
    {
        MY_DB db = new MY_DB();

        public bool InsertGroup(int id, string name, int user_id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Group] (id, name, user_id) " +
                                                "VALUES (@id, @name, @user_id)", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.Text).Value = name;
            command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;

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

        public bool UpdateGroup(int id,string name, int user_id)
        {
            SqlCommand command = new SqlCommand("UPDATE [Group] " +
                                                "SET " +
                                                "name=@name " +
                                                "WHERE id=@id " +
                                                "AND user_id=@user_id ",
                                                db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.Text).Value = name;
            command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;

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

        public bool DeleteGroup(int id, int user_id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Group] WHERE id=@id AND user_id=@user_id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;

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

        public bool CheckGroupExist(string name, string operation, int id = 0, int user_id = 0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();

            if (operation == "add")
            {
                query = "SELECT * FROM [Group] WHERE CAST(name AS NVARCHAR) = @name AND user_id = @user_id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM [Group] WHERE CAST(name AS NVARCHAR) = @name AND user_id = @user_id AND id <> @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;
            }

            command.Connection = db.getConnection;
            command.CommandText = query;

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

        public DataTable GetTable(string query)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand(query, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Group");
            db.closeConnection();

            DataTable table = dataSet.Tables["Group"];
            return table;
        }

        public DataTable GetAllGroup()
        {
            string query = "SELECT * FROM [Group]";
            return this.GetTable(query);
        }
    }
}
