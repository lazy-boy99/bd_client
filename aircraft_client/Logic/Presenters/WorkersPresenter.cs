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
    public class WorkersPresenter : BaseDataPresenter<IWorkersView>
    {

        public WorkersPresenter(IApplicationController controller, IWorkersView view, IModel model) : base(controller, view, model)
        {
            View.Workers += ChooseWorkersTuple;
            View.Back += Controller.Run<DirectorWorkersPresenter>;
        }

        private void ChooseWorkersTuple()
        {
            var queryListWs = SelectFormatter.Get("name", "workshops");
            var queryListSec = SelectFormatter.Get("name", "sectors");
            Controller.Run<WorkersChoosePresenter, string, string>(queryListWs, queryListSec);
        }
    }
}
