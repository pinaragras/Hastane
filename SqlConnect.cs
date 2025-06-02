using System.Data.SqlClient;

namespace Hastane
{
    public class SqlConnect
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog=MarmaraDB; Integrated Security=True; Trusted_Connection=True";
        public SqlConnection connect()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
