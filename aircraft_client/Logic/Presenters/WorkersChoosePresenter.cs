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
    public class WorkersChoosePresenter : BaseChoosePresenter<IChooseWorkersView>
    {

        public WorkersChoosePresenter(IApplicationController controller, IChooseWorkersView view, IModel model) : base(controller, view,model)
        {
        }


        protected override void GetSpecificTuple()
        {
            var query = Query.GetCategoryQuery(View.GetSelectedCategory());
            string workIdQuery="";
            switch (View.GetSelectedChoosenPlace())
            {
                case ChoosenPlace.WorkShop:
                    workIdQuery = Query.GetWorkIdByWsName(View.GetChoosenWorkshop());
                    break;
                case ChoosenPlace.Sector:
                    workIdQuery = Query.GetWorkIdBySecName(View.GetChoosenSector());
                    break;
                case ChoosenPlace.Factory:
                    break;
                default:
                    throw new NotImplementedException("Невозможно определить место выборки");
            }
            if (workIdQuery != "")
                query = QueryFormatter.SelectFormatter.Get("*", "(" + query + ")", workIdQuery, "id");
            Controller.Run<WorkersPresenter, string>(query);
        }
    }
}
