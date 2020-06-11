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
    class TechnicsPresenter : BaseDataPresenter<ITechnicsView>
    {
        public TechnicsPresenter(IApplicationController controller, ITechnicsView view, IModel model) : base(controller, view, model)
        {
            View.Technics += ChooseTechnics;
            View.Back += Controller.Run<DirectorTechnicsPresenter>;
        }

        private void ChooseTechnics()
        {
            var queryListWs = SelectFormatter.Get("name", "workshops");
            var queryListSec = SelectFormatter.Get("name", "sectors");
            Controller.Run<TechnichsChoosePresenter, string, string>(queryListWs, queryListSec);
        }
    }
}
