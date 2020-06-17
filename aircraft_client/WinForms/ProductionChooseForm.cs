using aircraft_client.Model;
using aircraft_client.UI;
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
    public partial class ProductionChooseForm : BaseChooseTupleForm
        , IProductionChooseView
    {
        public ProductionChooseForm()
        {
            InitializeComponent();
        }


        public Configuration.CategoryProd GetSelectedCategory()
        {
            var button = CategoryBox.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            return Configuration.GetCategoryProd(button.Text);
        }

        public Configuration.ProdChoosenMode GetSelectedChoosenMode()
        {
            var button=ChooseModeBox.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            return Configuration.GetMode(button.Text);
        }

        public string GetTimeBegin() =>
            DateBegPicker.Value.ToString("dd.MM.yyyy");

        public string GetTimeEnd()=>
            DateEndPicker.Value.ToString("dd.MM.yyyy");

    }
}
