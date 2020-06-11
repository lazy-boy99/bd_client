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
    class SectorChoosePresenter : BasePresenter<ISectorChooseView,string>
    {
        protected IModel Model { get; private set; }

        public SectorChoosePresenter(IModel model,IApplicationController controller, ISectorChooseView view) : base(controller, view)
        {
            Model = model;
            View.Cancel += View.Close;
            View.Continue += GetSectors;
        }

        public override void Run(string query)
        {
            var data = Formatter.GetStringData(Model.GetData(query));
            View.SetAvailableList(data);
            View.Show();
        }

        private void GetSectors()
        {
            string query;
            switch (View.GetSelectedChoosenPlace())
            {
                case ChoosenPlace.WorkShop:
                    query = Query.GetSectorByWorkshopName(View.GetChoosenWorkshop());
                    break;
                case ChoosenPlace.Factory:
                    query = Query.GetSectorByFactory();
                    break;
                default:
                    throw new NotImplementedException("Невозможно определить место выборки");
            }
            Controller.Run<DirectorPresenter, string>(query);
        }

    }
}
