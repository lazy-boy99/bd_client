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
            ChooseModeBox.Controls.OfType<RadioButton>().ToList()
                .ForEach(n => {
                    n.Click += (sender, e) =>
                    {
                        n.Checked = true;

                        var button=ChoosenPlaceBox.Controls.OfType<RadioButton>()
                        .FirstOrDefault(it => it.Text == "Участок");

                        button.Enabled = !n.Equals(ProdTypeButton) && !n.Equals(ProdButton);
                        button.Checked = false;

                        CategoryBox.Controls.OfType<RadioButton>()
                        .ToList()
                        .ForEach(it =>
                        {
                            var condition = it.Text == "Все категории";
                            it.Enabled = !n.Equals(ProdTypeButton) || condition;
                            it.Checked = false || condition;
                        });
                    };
                });
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
