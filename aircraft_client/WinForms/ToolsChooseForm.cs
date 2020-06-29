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
    public partial class ToolsChooseForm : BaseDialogForm, IToolsChooseView
    {
        public ToolsChooseForm()
        {
            InitializeComponent();
            ChooseLab.SelectedIndexChanged += (sender,e)=>Invoke(ReloadProducts);
            DatePickBeg.ValueChanged+= (sender,e)=>Invoke(ReloadProducts);
            DatePickEnd.ValueChanged += (sender,e)=>Invoke(ReloadProducts);
        }

        public event Action ReloadProducts;

        public string GetChoosenProd() =>
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

        public string GetChoosenLab()=>
            ChooseLab.SelectedItem as string;

        public void SetAvailableLabs(List<string> ls)
        {
            foreach (var item in ls)
                ChooseLab.Items.Add(item);
        }


        public void SetAvailableProds(List<string> ls)
        {
            productBox.Items.Clear();
            foreach (var item in ls)
                productBox.Items.Add(item);
        }
    }
}
