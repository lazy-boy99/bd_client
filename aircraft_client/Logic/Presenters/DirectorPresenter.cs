using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Logic.Presenters
{
    public class DirectorPresenter : BaseDataPresenter<IDirectorView>
    {
        public DirectorPresenter(IApplicationController controller, IDirectorView view, IModel model) : base(controller, view, model)
        {
            View.SectorsList += GetSectorsList;
        }
        
        private void GetSectorsList()
        {
            var query = Query.GetWorkshops();
            Controller.Run<SectorChoosePresenter, string>(query);
        }

    }
}
