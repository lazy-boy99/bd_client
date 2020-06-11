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
    public class ProductionChoosePresenter : BaseChoosePresenter<IProductionChooseView>
    {

        public ProductionChoosePresenter(IApplicationController controller, IProductionChooseView view, IModel model) 
            : base(controller, view, model)
        {
        }

        protected override void GetSpecificTuple()
        {
            var query=Query.GetCategoryQuery(View.GetSelectedCategory());
            string timeBeg = View.GetTimeBegin();
            string timeEnd = View.GetTimeEnd();
            string prodIdQuery = (View.GetSelectedChoosenPlace()) switch
            {
                ChoosenPlace.WorkShop => Query.GetProdIdByWsName(View.GetChoosenWorkshop()
                                       , View.GetSelectedChoosenMode()
                                       , timeBeg, timeEnd),
                ChoosenPlace.Factory => Query.GetProdIdByMode(View.GetSelectedChoosenMode()
                                        , timeBeg
                                        , timeEnd),
                ChoosenPlace.Sector => Query.GetProdIdBySecName(View.GetChoosenSector()
                                        , View.GetSelectedChoosenMode()
                                        , timeBeg
                                        , timeEnd),
                _ => throw new NotImplementedException("Невозможно определить место выборки"),
            };
            query = QueryFormatter.SelectFormatter.Get("*", "(" + query + ")", prodIdQuery, "prod_id");
            Controller.Run<ProductionPresenter, string>(query);
        }
    }
}
