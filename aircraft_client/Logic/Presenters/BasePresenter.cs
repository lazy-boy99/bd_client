using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;

namespace aircraft_client.Logic.Presenters
{
    public abstract class BasePresenter<TView> : IPresenter
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public virtual void Run()
        {
            View.Show();
        }
    }

    public abstract class BasePresenter<TView, TArg> : IPresenter<TArg>
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg argument);
    }

    public abstract class BasePresenter<TView, TArg1, TArg2> : IPresenter<TArg1, TArg2>
       where TView : IView
    {
        protected TView View { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg1 argument1, TArg2 argument2);
        

        
    }


    public abstract class BaseDataPresenter<TDataView> : BasePresenter<TDataView, string>
        where TDataView:IDataView
    {
        protected IModel Model { get; private set; }

        protected BaseDataPresenter(IApplicationController controller, TDataView view, IModel model)
            :base(controller,view)
        {
            Model = model;
            View.Back += Back;
        }

        public override void Run(string query)
        {
            if (query != "")
                View.FillData(Model.GetData(query));
            View.Show();
        }

        protected virtual void Back() {
            Controller.Run<LoginPresenter>();
        }
    }

}