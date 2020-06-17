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
    public class ChooseScientistPresenter : BasePresenter<IScientistChooseView,string>
    {
        private readonly IModel Model;

        public ChooseScientistPresenter(IApplicationController controller, IScientistChooseView view,IModel model) : base(controller, view)
        {
            Model = model;
            View.Continue += GetScientistByProduct;
            View.Cancel += View.Close;
        }

        public override void Run(string query)
        {
            var data = Formatter.GetStringData(Model.GetData(query));
            View.SetAvailableList(data);
            View.Show();
        }

        private void GetScientistByProduct()
        {
            var query = Query.GetCategoryQuery(View.GetSelectedCategory());
            if (query == "one product")
                query = Query.GetProdIdByProductName(View.GetChoosenItem());
            query = Query.GetInvestigatorsByProduct(query, View.GetTimeBegin(), View.GetTimeEnd());
            Controller.Run<DirectorScientistsPresenter, string>(query);
        }
    }
}
