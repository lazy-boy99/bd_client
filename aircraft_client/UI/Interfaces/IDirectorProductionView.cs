using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IDirectorProductionView : IView
    {
        event Action Back;
        event Action Exit;
        event Action Production;
        event Action Jobs;

    }
}
