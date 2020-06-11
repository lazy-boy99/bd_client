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
    public partial class ChooseLaboratoryForm : ChooseForm, IChooseLaboratoryView
    {
        public ChooseLaboratoryForm()
        {
            InitializeComponent();
        }

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
    }
}
