using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model;
using aircraft_client.Model.Data;
using aircraft_client.Model.Formatter;
using aircraft_client.UI.Interfaces;
using System;
using System.Linq;
using System.Text;

namespace aircraft_client.Logic.Presenters
{
    class ChoosePresenter<TPresenter,TDataView> : BasePresenter<IChooseView, string,string>
        where TPresenter : BaseDataPresenter<TDataView>
        where TDataView:IDataView
    {
        private readonly IModel Model;


        public ChoosePresenter(IApplicationController controller, IModel model, IChooseView view) : base(controller, view)
        {
            Model = model;
            View.Continue += NextForm;
            View.Cancel += View.Close;
        }

        public override void Run(string query,string name)
        {
            var data = Formatter.GetStringData(Model.GetData(query));
            View.SetAvailableList(data);
            View.SetLabel(name);
            View.Show();
        }

        private void NextForm()
        {
            string item = View.GetChoosenItem();
            string query;
            if (typeof(TPresenter) == typeof(DirectorScientistsPresenter))
            {
                query = Query.GetLabsListByProduct(GetRightName(item));
            }
            else if (typeof(TPresenter) == typeof(EquipmentManagerPresenter))
                query = Query.GetToolsByLaboratory(item);
            else if (typeof(TPresenter) == typeof(JobsPresenter))
            {
                query = Query.GetJobsByProductName(GetRightName(item));
            }
            else if (typeof(TPresenter) == typeof(ProductionPresenter)) {
                query = Query.GetTeamsAssembling(GetRightName(item));
            }
            else
                throw new NotImplementedException("Невозможно определить представителя");
            Controller.Run<TPresenter, string>(query);
        }

        private string GetRightName(string data)
        {
            var sb = new StringBuilder();
            var ar = data.Split(' ');
            ar.ToList().ForEach(n =>
            {
                if (n != ar.Last())
                {
                    if (n != ar.First())
                    {
                        sb.Append(" ");
                    }
                    sb.Append(n);
                }
            });
            return sb.ToString();
        }
    }

    
}
