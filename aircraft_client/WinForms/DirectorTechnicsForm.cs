using aircraft_client.Logic.Presenters;
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
    public partial class DirectorTechnicsForm : BaseMainForm, IDirectorTechnicsView
    {
        public DirectorTechnicsForm(ApplicationContext context) : base(context)
        {
            InitializeComponent();
            MasterButton.Click +=(sender,e)=> Invoke(Masters);
            TechButton.Click += (sender, e) => Invoke(Technics);
            ExitButton.Click += (sender, e) => Invoke(Exit);
            BackButton.Click += (sender, e) => Invoke(Back);

        }

        private void Invoke(Action e) =>
            e ?. Invoke();

        public event Action Masters;
        public event Action Technics;
        public event Action Exit;
        public event Action Back;
    }
}
