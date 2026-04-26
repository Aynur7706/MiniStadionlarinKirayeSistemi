using System.Data.SqlClient;

namespace MiniStadionKiraye
{
    public static class Database
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                @"Data Source=localhost;
                  Initial Catalog=MiniStadionDB;
                  Integrated Security=True");
        }
    }
}
