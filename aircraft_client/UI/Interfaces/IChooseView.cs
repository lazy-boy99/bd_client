using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IChooseView : IBaseDialogView
    {
        void SetAvailableList(List<string> ls);
        string GetChoosenItem();
        void SetLabel(string name);
    }
}
