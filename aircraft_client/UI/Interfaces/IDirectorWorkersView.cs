using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IDirectorWorkersView : IView
    {

        event Action Exit;
        event Action Back;
        event Action Workers;
        event Action Teams;
    }
}
