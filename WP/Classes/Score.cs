using System.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP
{
    class Score
    {
        private float studentScore;
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public float StudentScore
        {
            get { return studentScore; }
            set {
                if (value > 10)
                {
                    studentScore = 10;
                }
                else if (value < 0)
                {
                    studentScore = 0;
                }
                else studentScore = value;
            }
        }
        public string Description { get; set; }
        public Score()
        {

        }
        public bool AddThisScore()
        {
            MY_DB db = new MY_DB();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Score (student_id, course_id, student_score, description)" +
                    "VALUES (@student_id, @course_id, @student_score, @description)", db.getConnection);

                command.Parameters.Add("@student_id", SqlDbType.Int).Value = StudentID;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = CourseID;
                command.Parameters.Add("@student_score", SqlDbType.Float).Value = StudentScore;
                command.Parameters.Add("@description", SqlDbType.Text).Value = Description;

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool UpdateThisScore()
        {
            MY_DB db = new MY_DB();
            try
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Score" +
                    " SET " +
                    "student_score = @student_score," +
                    "description = @description," +
                    " WHERE student_id = @student_id and course_id = @course_id"
                    , db.getConnection);
                command.Parameters.Add("@student_id", SqlDbType.Int).Value = StudentID;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = CourseID;
                command.Parameters.Add("@student_score", SqlDbType.Float).Value = StudentScore;
                command.Parameters.Add("@desciption", SqlDbType.Text).Value = Description;

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public bool RemoveThisScore()
        {
            MY_DB db = new MY_DB();
            try
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Score" +
                    " WHERE student_id = @student_id and course_id = @course_id", db.getConnection);
                command.Parameters.Add("@student_id", SqlDbType.Int).Value = StudentID;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = CourseID;

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
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
        public DataTable getAllScore()
        {
            MY_DB db = new MY_DB();
            try
            {
                SqlCommand command = new SqlCommand("Select * From Score", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                db.openConnection();

                adapter.Fill(table);

                db.closeConnection();

                return table;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

    }
}
