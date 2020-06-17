using aircraft_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IChooseLaboratoryView:IChooseView
    {
        Configuration.CategoryProd GetSelectedCategory();
        string GetTimeBegin();
        string GetTimeEnd();

    }
}
