using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP
{
    class Database
    {
        SqlConnection data = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
                                               Initial Catalog=QLSVDB;
                                               Integrated Security=True;
                                               Connect Timeout=30;
                                               Encrypt=False;
                                               TrustServerCertificate=False;
                                               ApplicationIntent=ReadWrite;
                                               MultiSubnetFailover=False");

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
