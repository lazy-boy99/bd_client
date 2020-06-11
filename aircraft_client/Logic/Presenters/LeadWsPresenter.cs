using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Logic.Presenters
{
    public class LeadWsPresenter : BaseDataPresenter<ILeadWsView>
    {
        private string Query;
        public LeadWsPresenter(IApplicationController controller, ILeadWsView view, IModel model) : base(controller, view, model)
        {
            View.Reload += () => Run(Query);
        }

        public override void Run(string query)
        {
            Query = query;
            base.Run(query);
        }



    }
}
