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
    public partial class ScientistChooseForm : BaseDialogForm,IScientistChooseView
    {
        public ScientistChooseForm()
        {
            InitializeComponent();
        }

        public string GetChoosenItem() =>
            productBox.SelectedItem as string;

        public Configuration.CategoryProd GetSelectedCategory()
        {
            var button = CategoryBox.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            return Configuration.GetCategoryProd(button.Text);
        }

        public string GetTimeBegin() =>
            DatePickBeg.Value.ToString("dd.MM.yyyy");

        public string GetTimeEnd() =>
            DatePickEnd.Value.ToString("dd.MM.yyyy");

        public void SetAvailableList(List<string> ls)
        {
            foreach (var item in ls)
                productBox.Items.Add(item);
        }

        
    }
}
