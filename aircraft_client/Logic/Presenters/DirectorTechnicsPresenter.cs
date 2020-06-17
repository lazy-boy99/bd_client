using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aircraft_client.Logic.Presenters
{
    public class DirectorTechnicsPresenter:BasePresenter<IDirectorTechnicsView>
    {
        public DirectorTechnicsPresenter(IApplicationController controller,IDirectorTechnicsView view)
            : base(controller, view)
        {
            View.Back += Controller.Run<LoginPresenter>;
            View.Exit+= Application.Exit;
            View.Masters += () => Controller.Run<MasterPresenter,string>("");
            View.Technics += () => Controller.Run<TechnicsPresenter,string>("");
        }
    }
}
