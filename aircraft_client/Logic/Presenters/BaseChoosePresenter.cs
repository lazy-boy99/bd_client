using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model.Data;
using aircraft_client.Model.Formatter;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Logic.Presenters
{
    public abstract class BaseChoosePresenter<TChooseView> : BasePresenter<TChooseView, string, string>
        where TChooseView: IBaseTupleView
    {
        private readonly IModel Model;

        public BaseChoosePresenter(IApplicationController controller, TChooseView view,IModel model) : base(controller, view)
        {
            Model = model;
            View.Continue += GetSpecificTuple;
            View.Cancel += View.Close;
        }

        protected abstract void GetSpecificTuple();

        public override void Run(string queryWs, string querySec)
        {
            var dataWs = Formatter.GetStringData(Model.GetData(queryWs));
            var dataSec = Formatter.GetStringData(Model.GetData(querySec));
            View.SetListBoxes(dataWs, dataSec);
            View.Show();
        }
    }
}
