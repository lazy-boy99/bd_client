using aircraft_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IScientistChooseView:IBaseDialogView
    {
        Configuration.CategoryProd GetSelectedCategory();
        string GetTimeBegin();
        string GetTimeEnd();
        string GetChoosenItem();
        void SetAvailableList(List<string> ls);
    }
}
