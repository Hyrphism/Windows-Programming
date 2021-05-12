using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP.Classes
{
    class Contact
    {
        MY_DB db = new MY_DB();

        public bool InsertContact(int id, string fname, string lname, string group, string phone, string email, string address, MemoryStream picture, int user_id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Contact (id, fname, lname, [group], phone, email, address, picture, user_id) " +
                                                "VALUES (@id, @fname, @lname, @group, @phone, @email, @address, @picture, @user_id)", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.Text).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.Text).Value = lname;
            command.Parameters.Add("@group", SqlDbType.Text).Value = group;
            command.Parameters.Add("@phone", SqlDbType.Text).Value = phone;
            command.Parameters.Add("@email", SqlDbType.Text).Value = email;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
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

        public bool UpdateContact(int id, string fname, string lname, string group, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Contact " +
                                                "SET " +
                                                "fname=@fname," +
                                                "lname=@lname," +
                                                "[group]=@group," +
                                                "phone=@phone," +
                                                "email=@email," +
                                                "address=@address," +
                                                "picture=@picture " +
                                                "WHERE id=@id", 
                                                db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.Text).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.Text).Value = lname;
            command.Parameters.Add("@group", SqlDbType.Text).Value = group;
            command.Parameters.Add("@phone", SqlDbType.Text).Value = phone;
            command.Parameters.Add("@email", SqlDbType.Text).Value = email;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
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

        public bool DeleteContact(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Contact WHERE id=@id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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

        public bool CheckContactID(int id, int user_id)
        {
            string query = "SELECT * FROM Contact WHERE user_id = @user_id AND id = @id";

            SqlCommand command = new SqlCommand(query, db.getConnection);
            command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;
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

        public DataTable GetTable(string query)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand(query, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Contact");
            db.closeConnection();

            DataTable table = dataSet.Tables["Contact"];
            return table;
        }

        public DataTable SelectContactList()
        {
            string query = "SELECT * FROM Contact";
            return this.GetTable(query);
        }

        public DataTable GetContactByID(int id)
        {
            string query = $"SELECT * FROM Contact WHERE id = {id}";
            return this.GetTable(query);
        }

        public DataTable GetContactByGroup(string group)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Contact WHERE CAST([group] AS NVARCHAR) = @group", db.getConnection);
            command.Parameters.Add("@group", SqlDbType.NVarChar).Value = group;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
