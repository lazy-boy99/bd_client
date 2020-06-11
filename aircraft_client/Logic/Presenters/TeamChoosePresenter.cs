using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model;
using aircraft_client.Model.Data;
using aircraft_client.Model.Formatter;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static aircraft_client.Model.Configuration;

namespace aircraft_client.Logic.Presenters
{
    public class TeamChoosePresenter: BaseChoosePresenter<IChooseTeamView>
    {

        public TeamChoosePresenter(IApplicationController controller, IChooseTeamView view, IModel model) : base(controller, view,model)
        {
        }


        protected override void GetSpecificTuple()
        {
            string query = (View.GetSelectedChoosenPlace()) switch
            {
                ChoosenPlace.WorkShop => Query.GetSquadByWsName(View.GetChoosenWorkshop()),
                ChoosenPlace.Sector => Query.GetSquadBySecName(View.GetChoosenSector()),
                ChoosenPlace.Factory => Query.GetSquad(),
                _ => throw new NotImplementedException("Невозможно определить место выборки"),
            };
            Controller.Run<WorkersPresenter, string>(query);
        }
    }
}
