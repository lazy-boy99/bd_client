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
    public partial class SectorChooseForm : BaseDialogForm,ISectorChooseView
    {
        public SectorChooseForm()
        {
            InitializeComponent();
        }

        public string GetChoosenWorkshop() =>
            WsBox.SelectedItem as string;

        public Configuration.ChoosenPlace GetSelectedChoosenPlace()
        {
            var button = ChoosenPlaceBox.Controls.OfType<RadioButton>()
                          .FirstOrDefault(n => n.Checked);
            return Configuration.GetPlace(button.Text);
        }

        public void SetAvailableList(List<string> dataWs)
        {
            foreach (var item in dataWs)
                WsBox.Items.Add(item);
        }
    }
}
