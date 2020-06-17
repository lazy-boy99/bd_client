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
    public class ChooseLaboratoryPresenter : BasePresenter<IChooseLaboratoryView, string, string>
    {
        private readonly IModel Model;

        public ChooseLaboratoryPresenter(IApplicationController controller, IChooseLaboratoryView view, IModel model) : base(controller, view)
        {
            View.Continue += GetProductsByLaboratory;
            View.Cancel += View.Close;
            Model = model;
        }

        public override void Run(string query, string name)
        {
            var data = Formatter.GetStringData(Model.GetData(query));
            View.SetAvailableList(data);
            View.SetLabel(name);
            View.Show();
        }

        private void GetProductsByLaboratory()
        {
            var query = Query.GetProdIdByLaboratory(View.GetChoosenItem(),View.GetTimeBegin()
                ,View.GetTimeEnd());
            var prodQuery = Query.GetCategoryQuery(View.GetSelectedCategory());
            query=SelectFormatter.Get("*", "(" + prodQuery + ")", query,"prod_id");
            Controller.Run<DirectorScientistsPresenter,string>(query);
        }
    }
}
