using System.Data;
using System.Data.SqlClient;

namespace FactoryConnection.Repositories
{
    public class ConnectionFactory
    {


        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection(/*ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString*/);
            connection.ConnectionString = "";
            connection.Open();
            return connection;
        }
    }
}
