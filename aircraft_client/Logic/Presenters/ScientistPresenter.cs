using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;

namespace aircraft_client.Logic.Presenters
{
    class ScientistPresenter:BaseDataPresenter<IScientistView>
    {
        public ScientistPresenter
            (IApplicationController controller, IScientistView view, IModel model)
        : base(controller, view, model) { }
        
    }
}
