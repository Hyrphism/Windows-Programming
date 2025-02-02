﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WP.Classes
{
    class Course
    {
        MY_DB db = new MY_DB();

        public bool InsertCourse(int id, string label, int period, string description, string semester)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Course (id, label, period, description, semester) "
                                              + "VALUES (@id, @label, @period, @description, @semester)", db.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.Text).Value = description;
            command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;

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

        public bool CheckCourseName(string courseName, int courseID = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@cName and id<>@cID", db.getConnection);

            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool RemoveCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id = @id", db.getConnection);
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

        public bool UpdateCourse(int id, string label, int period, string description, string semester)
        {
            SqlCommand command = new SqlCommand(
                                "UPDATE Course" +
                                " SET " +
                                "label = @label," +
                                "period = @period," +
                                "description = @description, " +
                                "semester = @semester" +
                                " WHERE id = @ID"
                                , db.getConnection);

            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.Text).Value = description;
            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = semester;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

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

        public bool DeleteCourse(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Course " +
                                                "where id=@id",
                                                db.getConnection);

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
            adapter.Fill(dataSet, "Course");
            db.closeConnection();

            DataTable table = dataSet.Tables["Course"];
            return table;
        }

        public DataTable GetAllCourses()
        {
            string query = "SELECT * FROM Course";
            return this.GetTable(query);
        }

        public DataTable GetCourseByID(int id)
        {
            string query = $"SELECT * FROM Course WHERE id = {id}";
            return this.GetTable(query);
        }

        public int TotalCourse()
        {
            DataTable table = this.GetAllCourses();
            return table.Rows.Count;
        }

        public DataTable GetAverageScore()
        {
            string query = "SELECT c.label, AVG(s.student_score) as 'average score' " +
                           "FROM Course c, Score s " +
                           "WHERE c.id = s.course_id " +
                           "GROUP BY c.label";
            return this.GetTable(query);
        }

        public DataTable GetCourseBySemester(string semester)
        {
            string query = $"SELECT label FROM Course WHERE semester = '{semester}'";
            return this.GetTable(query);
        }

        public bool CheckValidCourseInSemester(string course, string semester)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE semester=@semester and label=@course", db.getConnection);

            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = semester;
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

        public DataTable CourseStudentList(string label, string semester)
        {
            SqlCommand command = new SqlCommand(
                "                                SELECT ROW_NUMBER() OVER(ORDER BY s.id) AS STT," +
                "                                       s.id," +
                "                                       fname," +
                "                                       lname," +
                "                                       CAST(bdate as DATE) as bdate," +
                "                                       gender," +
                "                                       phone" +
                "                                FROM Student s, Course c " +
                "                                WHERE selected_course LIKE '%' + @label + '%' " +
                "                                  AND semester = @semester " +
                "                                  AND label = @label", 
                db.getConnection);

            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = semester;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
