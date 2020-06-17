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
    public partial class DirectorScientistsForm : BaseDataForm,IDirectorScientistsView
    {
        public DirectorScientistsForm(ApplicationContext context):base(context)
        {
            InitializeComponent();
            LabsButton.Click += (sender, e) => Invoke(LabsList);
            ProdByLabButton.Click += (sender, e) => Invoke(ProdsByLab);
            ScientistButton.Click+= (sender, e) => Invoke(ScientistListByProd);
            ProdByScientistButton.Click+= (sender, e) => Invoke(ProdByScientist);
        }


        
        public event Action LabsList;
        public event Action ProdsByLab;
        public event Action ScientistListByProd;
        public event Action ProdByScientist;
    }
}
