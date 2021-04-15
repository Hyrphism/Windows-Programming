using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WP
{
    class MY_DB
    {
        SqlConnection data = new SqlConnection(@"Data Source=laptop-tr9pgo6u\sqlexpress;Initial Catalog=DB;Integrated Security=True");

        public SqlConnection getConnection
        {
            get
            {
                return data;
            }
        }

        public void openConnection()
        {
            if ((data.State == ConnectionState.Closed))
            {
                data.Open();
            }

        }

        public void closeConnection()
        {
            if ((data.State == ConnectionState.Open))
            {
                data.Close();
            }

        }

    }
}
