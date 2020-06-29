using System.Data;
using System.Data.Common;

namespace aircraft_client.Model.Data
{
    public class BaseModel : IModel
    {

        private static DbDataAdapter Adapter { get;  set; }
        private static DbConnection Connection { get;  set; }

        public void EstablishConnection(DbConnection connection,DbDataAdapter adapter)
        {
            Connection=connection;
            Adapter = adapter;
        }

        public DataTable GetData(string query)
        {
            using var comand = Connection.CreateCommand();
            comand.CommandText = query;
            Adapter.SelectCommand = comand;
            var data = new DataTable();
            Adapter.Fill(data);
            return data;
        }

        public void Execute(string query)
        {
            using var comand = Connection.CreateCommand();
            comand.CommandText = query;
            comand.CommandTimeout = 180;
            comand.ExecuteNonQuery();
        }
    }
}
