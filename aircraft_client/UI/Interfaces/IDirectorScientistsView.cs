using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IDirectorScientistsView : IDataView
    {
        event Action LabsList;
        event Action ProdsByLab;
        event Action ScientistListByProd;
        event Action ExpTools;
    }
}
