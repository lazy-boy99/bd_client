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
using static aircraft_client.Model.Formatter.QueryFormatter;

namespace aircraft_client.Logic.Presenters
{
    public class ProductionPresenter : BaseDataPresenter<IProductionView>
    {
        public ProductionPresenter
            (IApplicationController controller, IProductionView view, IModel model)
        : base(controller, view, model)
        {
            View.TeamsAssembling += GetTeamsAssemling;
            View.ProdChoose += ChooseProdTuple;
        }

        protected override void Back()
        {
            Controller.Run<DirectorProductionPresenter>();
        }

        private void ChooseProdTuple()
        {
            var queryListWs = SelectFormatter.Get("name","workshops");
            var queryListSec = SelectFormatter.Get("name", "sectors");
            Controller.Run<ProductionChoosePresenter, string,string>(queryListWs,queryListSec);
        }

        private void GetTeamsAssemling()
        {
            Controller
               .Run<ChoosePresenter<ProductionPresenter, IProductionView>
                    , string,string>(Query.GetProductsNames()
                    ,"Выберите название продукта");
            
        }

    }
        
}
