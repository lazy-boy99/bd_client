using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IDataView:IView
    {
        void FillData(DataTable dt);
        event Action Back;
        
    }
}
