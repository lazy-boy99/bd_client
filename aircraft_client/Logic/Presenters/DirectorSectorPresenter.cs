using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aircraft_client.Model.Data.BaseModel;

namespace aircraft_client.Logic.Presenters
{
    class DirectorSectorPresenter:BaseDataPresenter<IDirectorSectorView>
    {
        public DirectorSectorPresenter
            (IApplicationController controller, IDirectorSectorView view, IModel model)
        : base(controller, view, model)
        {

        }

    }
}
