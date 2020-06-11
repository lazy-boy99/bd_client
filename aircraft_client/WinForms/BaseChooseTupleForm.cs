using aircraft_client.Model;
using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aircraft_client.WinForms
{
    public partial class BaseChooseTupleForm : BaseDialogForm, IBaseTupleView
    {
        public BaseChooseTupleForm()
        {
            InitializeComponent();
        }


        public Configuration.ChoosenPlace GetSelectedChoosenPlace()
        {
            var button = ChoosenPlaceBox.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            return Configuration.GetPlace(button.Text);
        }

        public void SetListBoxes(List<string> dataWs, List<string> dataSec)
        {
            foreach (var item in dataWs)
                WsBox.Items.Add(item);
            foreach (var item in dataSec)
                SectorBox.Items.Add(item);
        }

        public string GetChoosenSector() =>
            SectorBox.SelectedItem as string;

        public string GetChoosenWorkshop() =>
            WsBox.SelectedItem as string;
    }

}
