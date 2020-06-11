using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aircraft_client.Model.Data.BaseModel;

namespace aircraft_client.Model.Data
{
    public interface IModel
    {

        DataTable GetData(string query);
        void EstablishConnection(DbConnection connection, DbDataAdapter adapter);
        void Execute(string query);
    }
}
