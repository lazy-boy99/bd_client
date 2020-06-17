using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aircraft_client.Model.Data.BaseModel;

namespace aircraft_client.Logic.Presenters
{
    class DirectorProductionPresenter : BasePresenter<IDirectorProductionView>
    {
        public DirectorProductionPresenter
            (IApplicationController controller, IDirectorProductionView view)
        : base(controller, view)
        {
            View.Back += Controller.Run<LoginPresenter>;
            View.Exit += Application.Exit;
            View.Production+= ()=>Controller.Run<ProductionPresenter,string>("");
            View.Jobs+= () => Controller.Run<JobsPresenter, string>("");
        }
    }
}
