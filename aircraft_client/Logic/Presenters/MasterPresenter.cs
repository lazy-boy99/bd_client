using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aircraft_client.Model.Formatter.QueryFormatter;

namespace aircraft_client.Logic.Presenters
{
    public class MasterPresenter : BaseDataPresenter<IMasterView>
    {
        public MasterPresenter(IApplicationController controller, IMasterView view, IModel model) : base(controller, view, model)
        {
            View.Masters += GetTupleMasters;
            View.Back += Controller.Run<DirectorTechnicsPresenter>;
        }

        private void GetTupleMasters()
        {
            var queryListWs = SelectFormatter.Get("name", "workshops");
            var queryListSec = SelectFormatter.Get("name", "sectors");
            Controller.Run<MastersChoosePresenter, string, string>(queryListWs, queryListSec);
        }
    }
}
