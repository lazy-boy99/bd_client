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
    public partial class DirectorForm : BaseDataForm,IDirectorView
    {
        public DirectorForm(ApplicationContext context):base(context)
        {
            InitializeComponent();
            SectorListButton.Click += (sender, e) => Invoke(SectorsList);
        }

        public event Action SectorsList;
    }
}
