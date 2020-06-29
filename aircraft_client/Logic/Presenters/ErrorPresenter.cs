using aircraft_client.Logic.ApplicationController;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Logic.Presenters
{
    public class ErrorPresenter:BasePresenter<IErrorView,string,string>
    {
        public ErrorPresenter(IApplicationController controller, IErrorView view) : base(controller, view)
        {
            
        }
        public override void Run(string description, string title)
        {
            View.SetDescription(description, title);
            View.Show();
        }
    }
}
