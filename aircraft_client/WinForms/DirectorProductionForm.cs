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
    public partial class DirectorProductionForm : BaseMainForm, IDirectorProductionView
    {
        
        public DirectorProductionForm(ApplicationContext context) : base(context)
        {
            InitializeComponent();
            BackButton.Click += (sender, e) => Invoke(Back);
            ExitButton.Click += (sender, e) => Invoke(Exit);
            ProdButton.Click += (sender, e) => Invoke(Production);
            JobButton.Click += (sender, e) => Invoke(Jobs);
        }
        
        private void Invoke(Action e) =>
            e?.Invoke();
        
        public event Action Back;
        public event Action Exit;
        public event Action Production;
        public event Action Jobs;
    }
}
