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
    public partial class BaseDataForm : BaseMainForm, IDataView
    {
        protected BaseDataForm(ApplicationContext context):base(context)
        {
            InitializeComponent();
            BackButton.Click += (sender, e) => Invoke(Back);
        }
        
        public void FillData(DataTable dt)
        {
            DataField.DataSource = dt;
            DataField.DataMember = dt.TableName;
        }

        protected void Invoke(Action e) =>
            e?.Invoke();

        public event Action Back;

    }
}
