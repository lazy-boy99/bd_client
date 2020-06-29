using aircraft_client.Logic.ApplicationController;
using aircraft_client.Logic.Containers;
using aircraft_client.Logic.Presenters;
using aircraft_client.Model;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using aircraft_client.WinForms;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
namespace aircraft_client.Main
{
    class Application
    {
        public static readonly ApplicationContext Context = new ApplicationContext();
       
        public static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var controller = new ApplicationController(new ContainerAdapter()).
                    RegisterView<IErrorView, ErrorForm>();
            try
            {
                using (var conn= new OracleConnection(Connection.Instance.connectionString))
                {
                    conn.Open();
                    controller
                        .RegisterService<IModel, BaseModel>(conn, new OracleDataAdapter())
                        .RegisterView<ILoginView, LoginForm>()
                        .RegisterView<IChooseView, ChooseForm>()
                        .RegisterView<IDirectorScientistsView, DirectorScientistsForm>()
                        .RegisterView<IDirectorView, DirectorForm>()
                        .RegisterView<IDirectorWorkersView, DirectorWorkersForm>()
                        .RegisterView<IEquipmentManagerView, EquipmentManagerForm>()
                        .RegisterView<IDirectorProductionView, DirectorProductionForm>()
                        .RegisterView<IDirectorTechnicsView, DirectorTechnicsForm>()
                        .RegisterView<IProductionChooseView, ProductionChooseForm>()
                        .RegisterView<IProductionView, ProductionForm>()
                        .RegisterView<IJobsView, JobsForm>()
                        .RegisterView<IWorkersView, WorkersForm>()
                        .RegisterView<IChooseWorkersView, WorkersChooseForm>()
                        .RegisterView<ITeamView, TeamForm>()
                        .RegisterView<IChooseTeamView, TeamChooseForm>()
                        .RegisterView<IMasterView, MasterForm>()
                        .RegisterView<IChooseMastersView, ChooseMasterForm>()
                        .RegisterView<IChooseTeamView, TeamChooseForm>()
                        .RegisterView<ITechnicsView, TechnicsForm>()
                        .RegisterView<IChooseLaboratoryView, ChooseLaboratoryForm>()
                        .RegisterView<IChooseTechnicsView, TechnicsChooseForm>()
                        .RegisterView<IScientistChooseView, ScientistChooseForm>()
                        .RegisterView<ISectorChooseView, SectorChooseForm>()
                        .RegisterInstance(Context);
                    controller.Run<LoginPresenter>();
                    conn.Close();
                    }
            }
            catch (System.Exception ex)
            {
                controller.Run<ErrorPresenter,string,string>(ex.Message, ex.GetType().Name);
            }
        }
}
}

