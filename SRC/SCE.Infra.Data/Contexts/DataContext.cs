using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Infra.Data.Contexts
{
    public abstract class DataContext
    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlDataReader sqlDataReader;
        protected SqlTransaction sqlTransaction;

        protected string query = string.Empty;
        protected readonly string connectionString = "";

        protected void OpenConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        protected void CloseConnection()
        {
            if (sqlConnection != null)
                sqlConnection.Close();
        }

    }
}
