using aircraft_client.UI.Interfaces;
using aircraft_client.WinForms;
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
    public partial class ProductionForm : BaseDataForm,IProductionView
    {
        public ProductionForm(ApplicationContext context):base(context)
        {
            InitializeComponent();
            ProdChooseButton.Click += (sender, e) => Invoke(ProdChoose);
            TeamAssemblingButton.Click += (sender, e) => Invoke(TeamsAssembling);
        }

        public event Action ProdChoose;
        public event Action TeamsAssembling;
    }
}
