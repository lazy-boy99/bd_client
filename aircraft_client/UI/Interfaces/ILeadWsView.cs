using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface ILeadWsView:IDataView
    {
        event Action Reload;
    }
}
