using aircraft_client.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace aircraft_client.UI.Interfaces
{
    public interface IProductionChooseView:IBaseTupleView
    {
        Configuration.ProdChoosenMode GetSelectedChoosenMode();
        Configuration.CategoryProd GetSelectedCategory();
        string GetTimeBegin();
        string GetTimeEnd();
    }
}
