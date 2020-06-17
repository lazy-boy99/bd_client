using aircraft_client.Logic.Containers;
using aircraft_client.Logic.Presenters;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Data.Common;

namespace aircraft_client.Logic.ApplicationController
{
    public interface IApplicationController
    {

        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        IApplicationController RegisterInstance<TArgument>(TArgument instance);

        IApplicationController RegisterService<TService, TImplementation>
            (DbConnection connection, DbDataAdapter adapter)
            where TImplementation : class, TService;
        
        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        void Run<TPresenter, TArgumnent>(TArgumnent argumnent)
            where TPresenter : class, IPresenter<TArgumnent>;


        void Run<TPresenter, TArg1, TArg2>(TArg1 arg1, TArg2 arg2)
             where TPresenter : class, IPresenter<TArg1,TArg2>;
    }
}