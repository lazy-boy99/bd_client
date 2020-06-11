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
    public partial class TeamForm : BaseDataForm,ITeamView
    {
        public event Action Squad;

        public TeamForm(ApplicationContext context):base(context)
        {
            InitializeComponent();
            TeamButton.Click+=(sender, e) => Invoke(Squad);
        }

    }
}
