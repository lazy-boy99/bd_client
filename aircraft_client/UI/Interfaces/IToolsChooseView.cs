using aircraft_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IToolsChooseView:IBaseDialogView
    {
        Configuration.CategoryProd GetSelectedCategory();
        string GetTimeBegin();
        string GetTimeEnd();
        string GetChoosenLab();
        string GetChoosenProd();
        void SetAvailableLabs(List<string> ls);
        void SetAvailableProds(List<string> ls);
        event Action ReloadProducts;
    }
}
