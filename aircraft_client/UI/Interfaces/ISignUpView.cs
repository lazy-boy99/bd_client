using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface ISignUpView:IBaseDialogView
    {
        string Username { get; }
        string Pas { get; }
        void SetRoleList(List<string> ls);
        string GetSelectedRole();
    }
}
