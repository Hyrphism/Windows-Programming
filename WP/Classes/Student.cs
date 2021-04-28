using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WP
{
    class Student
    {
        MY_DB db = new MY_DB();

        public bool InsertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Student (id, fname, lname, bdate, gender, phone, address, picture)"
                                                + "VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adr, @pic)", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

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

        public DataTable GetStudent(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool DeleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Student WHERE id = @id", db.getConnection);
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

        public DataTable GetTable(string query)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand(query, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Student");
            db.closeConnection();

            DataTable table = dataSet.Tables["Student"];
            return table;
        }

        public double GetTotal()
        {
            string query = "SELECT COUNT(gender) FROM Student";
            DataTable table = GetTable(query);
            return Convert.ToDouble(table.Rows[0][0]);
        }

        public double GetMale()
        {
            string query = "SELECT COUNT(gender) FROM Student GROUP BY gender HAVING gender = 'Male'";
            DataTable table = GetTable(query);
            return Convert.ToDouble(table.Rows[0][0]);
        }

        public double GetFemale()
        {
            string query = "SELECT COUNT(gender) FROM Student GROUP BY gender HAVING gender = 'Female'";
            DataTable table = GetTable(query);
            return Convert.ToDouble(table.Rows[0][0]);
        }

        public DataTable GetAllStudent()
        {
            string query = "SELECT * FROM Student";
            return this.GetTable(query);
        }

        public bool InsertSelectedCourse(int id, string course)
        {
            SqlCommand command = new SqlCommand("UPDATE Student SET selected_course=@course WHERE id=@id", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@course", SqlDbType.NVarChar).Value = course;

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

        public string GetSelectedCourses(int id)
        {
            string query = $"SELECT selected_course FROM Student WHERE id={id}";
            return this.GetTable(query).Rows[0].Field<string>(0);
        }

        public DataTable GetStudentByID(int id = 0)
        {
            string query = $"SELECT * FROM Student WHERE id={id}";
            return this.GetTable(query);
        }

        public bool CheckValidCourse(string selectedCourse, string currCourse)
        {
            if (selectedCourse.Contains(currCourse))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
