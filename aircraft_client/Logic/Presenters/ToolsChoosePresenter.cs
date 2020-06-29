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
    public class ToolsChoosePresenter: BasePresenter<IToolsChooseView, string>
    {

        private readonly IModel Model;

        public ToolsChoosePresenter(IApplicationController controller, IToolsChooseView view, IModel model) : base(controller, view)
        {
            Model = model;
            View.Continue += GetToolsByProducts;
            View.Cancel += View.Close;
            View.ReloadProducts += SetProductsLs;
        }

        public override void Run(string query)
        {
            var data = Formatter.GetStringData(Model.GetData(query));
            View.SetAvailableLabs(data);
            View.Show();
        }

        private void SetProductsLs()
        {

           var query=Query.GetProdIdByLaboratory(View.GetChoosenLab()
              , View.GetTimeBegin()
             , View.GetTimeEnd());
            query = Query.GetProductsNames(query);
            var data = Formatter.GetStringData(Model.GetData(query));
            View.SetAvailableProds(data);
        }

        private void GetToolsByProducts()
        {
            var query = Query.GetCategoryQuery(View.GetSelectedCategory());
            if (query == "one product")
                query = Query.GetProdIdByProductName(View.GetChoosenProd());
            else
                query = SelectFormatter.Get("prod_id","("+query+")");
            var conditions = new List<string>();
            conditions.Add("time_end<=to_date('" + View.GetTimeEnd()+ "','dd.mm.yyyy')");
            conditions.Add("time_begin>=to_date('" + View.GetTimeBegin() + "','dd.mm.yyyy')");
            conditions.Add(QueryFormatter.In("prod_id", query));

            query = QueryFormatter.SelectFormatter.Get("prod_id"
                ,"products_exps"
                ,conditions);

            query = Query.GetToolsByProdIdLab(query,View.GetChoosenLab());
            Controller.Run<DirectorScientistsPresenter, string>(query);
        }
    }
}
