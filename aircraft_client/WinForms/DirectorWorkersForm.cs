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
    public partial class DirectorWorkersForm : BaseMainForm, IDirectorWorkersView
    {
        public DirectorWorkersForm(ApplicationContext context):base(context)
        {
            InitializeComponent();
            WorkersButton.Click += (sender, e) => Invoke(Workers);
            ExitButton.Click += (sender, e) => Invoke(Exit);
            BackButton.Click += (sender, e) => Invoke(Back);
            TeamsButton.Click += (sender, e) => Invoke(Teams);
        }

        public event Action Exit;
        public event Action Back;
        public event Action Workers;
        public event Action Teams;

        private void Invoke(Action e)=>
            e?.Invoke();
    }
}
