using aircraft_client.Logic.Containers;
using aircraft_client.Logic.Presenters;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Data.Common;

namespace aircraft_client.Logic.ApplicationController
{
    public class ApplicationController : IApplicationController
    {
        private readonly IContainer _container;

        public ApplicationController(IContainer container)
        {
            _container = container;
            _container.RegisterInstance<IApplicationController>(this);
        }


        public IApplicationController RegisterInstance<TInstance>(TInstance instance)
        {
            _container.RegisterInstance(instance);
            return this;
        }
        //вот тут надо менять на актуальную модель
        public IApplicationController RegisterService
            <TModel, TImplementation>
                (DbConnection connection, DbDataAdapter adapter)
            where TImplementation : class, TModel
        {
            _container.Register<TModel, TImplementation>();
            var model = _container.Resolve<IModel>();
            model.EstablishConnection(connection,adapter);
            return this;
        }

        public IApplicationController RegisterView<TView, TImplementation>()
             where TImplementation : class, TView
             where TView : IView
        {
            _container.Register<TView, TImplementation>();
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter, TArgumnent>(TArgumnent argumnent)
            where TPresenter : class, IPresenter<TArgumnent>
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run(argumnent);
        }

        public void Run<TPresenter, TArg1, TArg2>(TArg1 arg1, TArg2 arg2)
            where TPresenter : class, IPresenter<TArg1, TArg2>
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run(arg1,arg2);
        }
    }
}
