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
using System.Windows.Forms;
using static aircraft_client.Model.Formatter.QueryFormatter;

namespace aircraft_client.Logic.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly IModel Model;

        public LoginPresenter(IModel model,IApplicationController controller, ILoginView view) : base(controller, view)
        {
            Model = model;
            View.Login += Enter;
            View.Exit += Application.Exit;
        }

        private RoleManager.RoleType GetInformation()
        {
            var conditions =new List<string> { "login='"+View.Username+"'"
                ,"pas='"+View.Password+"'" };
            var query=SelectFormatter.Get("role", "accounts", conditions);
            var ls = Formatter
                .GetStringData(Model.GetData(query));
            return RoleManager.GetType(ls[0]);
        }

        private void Enter()
        {
            try
            {
                RoleView(GetInformation());
            }
            catch (ArgumentOutOfRangeException ex) { 
                View.ShowError("Указаный пользователь не найден", "Пользователь не существует");
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message, ex.GetType().Name);
            }
        }

        private void RoleView(RoleManager.RoleType type)
        {
                switch (type)
                {
                    
                    case RoleManager.RoleType.EquipmentManager:
                        var query = QueryFormatter.SelectFormatter
                            .Get("name", "laboratories");
                        Controller.Run
                            <ChoosePresenter<EquipmentManagerPresenter, IEquipmentManagerView>
                            , string, string>(query, "Выберите лабораторию");
                        break;

                    case RoleManager.RoleType.DirectorScientists:
                        query = QueryFormatter.SelectFormatter
                            .Get(new List<string>
                                { "first_name"
                            , "last_name"
                            , "patronymic"}, "investigators");
                        Controller.Run<DirectorScientistsPresenter, string>
                            (query);
                        break;

                    case RoleManager.RoleType.DirectorProduction:
                        Controller.Run<DirectorProductionPresenter>();
                        break;

                    case RoleManager.RoleType.DirectorWorkers:
                        Controller.Run<DirectorWorkersPresenter>();
                        break;

                    case RoleManager.RoleType.DirectorTechnics:
                        Controller.Run<DirectorTechnicsPresenter>();
                        break;
                    case RoleManager.RoleType.Director:
                        Controller.Run<DirectorPresenter
                            , string>(Query.GetSectorByFactory());
                        break;
                    default:
                        throw new NotImplementedException("Невозможно установить роль");
                };
        }

    }
}
