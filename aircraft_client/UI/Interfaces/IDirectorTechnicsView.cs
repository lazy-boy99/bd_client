using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Logic.Presenters
{
    public interface IDirectorTechnicsView : IView
    {
        event Action Masters;
        event Action Technics;
        event Action Exit;
        event Action Back;
    }
}
