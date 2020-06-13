using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model;
using aircraft_client.Model.Data;
using aircraft_client.Model.Formatter;
using aircraft_client.UI.Interfaces;
using System;

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
                if(item.Split(' ').Length==3)
                    query = Query.GetExperimentsByScientist(item);
                else
                    query = Query.GetLabsListByProduct(item.Split(' ')[0]);
            }
            else if (typeof(TPresenter) == typeof(EquipmentManagerPresenter))
                query = Query.GetToolsByLaboratory(item);
            else if (typeof(TPresenter) == typeof(JobsPresenter))
                query = Query.GetJobsByProductName(item.Split(' ')[0]);
            else if (typeof(TPresenter) == typeof(ProductionPresenter))
                query = Query.GetTeamsAssembling(item.Split(' ')[0]);
            else
                throw new NotImplementedException("Невозможно определить представителя");
            Controller.Run<TPresenter, string>(query);
        }
    }
}
