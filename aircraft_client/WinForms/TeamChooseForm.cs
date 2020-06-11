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
    public partial class TeamChooseForm : BaseChooseTupleForm
        ,IChooseTeamView
    {
        public TeamChooseForm()
        {
            InitializeComponent();
        }

    }
}
