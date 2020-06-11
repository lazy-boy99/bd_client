using aircraft_client.Logic.ApplicationController;
using aircraft_client.Model;
using aircraft_client.Model.Data;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.Logic.Presenters
{
    public class SignUpPresenter : BasePresenter<ISignUpView>
    {
        private readonly IModel Model;

        public SignUpPresenter(IModel model,IApplicationController controller, ISignUpView view) : base(controller, view)
        {
            Model = model;
            View.Continue += AddAccount;
            View.Cancel += View.Close;
        }

        public override void Run()
        {
            var listRoles=Enum
                .GetValues(typeof(RoleManager.RoleType))
                .Cast<RoleManager.RoleType>().Select(item=>RoleManager.ToString(item))
                .ToList();

            View.SetRoleList(listRoles);
            base.Run();
        }

        private void AddAccount()
        {
            try
            {
                var query = "insert into accounts(login,pas,role) values ('" + View.Username +
                    "','" + View.Pas + "','" + View.GetSelectedRole()+"')";
                Model.Execute(query);
                View.Close();
            }
            catch(Exception ex)
            {
                View.ShowError(ex.Message, ex.GetType().Name);
            }
        }

    }
}
