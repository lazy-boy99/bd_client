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
    class JobsPresenter : BaseDataPresenter<IJobsView>
    {
        public JobsPresenter(IApplicationController controller, IJobsView view, IModel model) 
            : base(controller, view, model)
        {
            View.Jobs += GetJobsTuple;
        }

        private void GetJobsTuple()
        {
            var query = QueryFormatter.SelectFormatter.Union(new List<string> { "name" }
            ,new List<string> {"rockets","helicopters","gliders "
                ,"hang_gliders","planes","other_prods"});
            Controller.Run<ChoosePresenter<JobsPresenter,IJobsView>,string,string>(query,"Выберите название изделия");
        }

        protected override void Back()
        {
            Controller.Run<DirectorProductionPresenter>();
        }

    }
}
