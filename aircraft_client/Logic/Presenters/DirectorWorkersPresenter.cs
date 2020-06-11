using aircraft_client.Logic.ApplicationController;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aircraft_client.Logic.Presenters
{
    public class DirectorWorkersPresenter : BasePresenter<IDirectorWorkersView>
    {
        public DirectorWorkersPresenter(IApplicationController controller, IDirectorWorkersView view) : base(controller, view)
        {
            View.Back += Controller.Run<LoginPresenter>;
            View.Exit += Application.Exit;
            View.Workers += ()=>Controller.Run<WorkersPresenter,string>("");
            View.Teams+=() => Controller.Run<TeamPresenter, string>("");
        }

    }
}
