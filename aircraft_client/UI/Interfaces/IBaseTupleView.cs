using aircraft_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_client.UI.Interfaces
{
    public interface IBaseTupleView:IBaseDialogView
    {
        Configuration.ChoosenPlace GetSelectedChoosenPlace();
        string GetChoosenWorkshop();
        string GetChoosenSector();
        void SetListBoxes(List<string> dataWs, List<string> dataSec);
    }
}
