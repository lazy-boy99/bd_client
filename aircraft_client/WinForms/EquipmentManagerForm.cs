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
    public partial class EquipmentManagerForm : BaseDataForm,IEquipmentManagerView
    {
        public EquipmentManagerForm(ApplicationContext context):base(context)
        {
            InitializeComponent();
        }

        private void EquipmentManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
