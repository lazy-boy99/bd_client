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
    public class MastersChoosePresenter : BaseChoosePresenter<IChooseMastersView>
    {
        public MastersChoosePresenter(IApplicationController controller, IChooseMastersView view, IModel model) : base(controller, view, model)
        {
        }

        

        protected override void GetSpecificTuple()
        {
            string query = (View.GetSelectedChoosenPlace()) switch
            {
                ChoosenPlace.WorkShop => Query.GetMastersByWsName(View.GetChoosenWorkshop()),
                ChoosenPlace.Factory => Query.GetMasters(),
                ChoosenPlace.Sector => Query.GetMastersBySecName(View.GetChoosenSector()),
                _ => throw new NotImplementedException("Невозможно определить место выборки"),
            };
            Controller.Run<MasterPresenter, string>(query);
        }
    }
}
