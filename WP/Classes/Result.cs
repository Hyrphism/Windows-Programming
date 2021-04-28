using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WP.Classes
{
    class Result
    {
        MY_DB db = new MY_DB();

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

        public DataTable GetStudentResult()
        {
            string query = "SELECT FROM ";
            return this.GetTable(query);
        }


    }
}
