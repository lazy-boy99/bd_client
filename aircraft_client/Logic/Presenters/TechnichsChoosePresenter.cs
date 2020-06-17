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
    public class TechnichsChoosePresenter : BaseChoosePresenter<IChooseTechnicsView>
    {
        public TechnichsChoosePresenter(IApplicationController controller, IChooseTechnicsView view, IModel model) : base(controller, view, model)
        {
        }

        protected override void GetSpecificTuple()
        {
            var query=Query.GetCategoryQuery(View.GetCategory());
            string techIdQuery = "";
            switch (View.GetSelectedChoosenPlace())
            {
                case ChoosenPlace.WorkShop:
                    techIdQuery = Query.GetTechIdByWsName(View.GetChoosenWorkshop());
                    break;
                case ChoosenPlace.Sector:
                    techIdQuery = Query.GetTechIdBySecName(View.GetChoosenSector());
                    break;
                case ChoosenPlace.Factory:
                    break;
                default:
                    throw new NotImplementedException("Невозможно определить место выборки");
            }
            if (techIdQuery != "")
                query = QueryFormatter.SelectFormatter.Get("*", "(" + query + ")", techIdQuery, "id");
            Controller.Run<TechnicsPresenter, string>(query);
        }
    }
}
