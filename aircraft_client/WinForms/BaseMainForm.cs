using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aircraft_client.WinForms
{
    public class BaseMainForm:Form
    {
        private readonly ApplicationContext Context;
        
        protected BaseMainForm(ApplicationContext context) 
        {
            Context = context;
        }

        public BaseMainForm()
        {

        }
        

        public new void Show()
        {
            Context.MainForm = this;
            if (Application.OpenForms.Count == 0)
                Application.Run(Context);
            else
                base.Show();
            ClosePreviousViews();
        }

        private void ClosePreviousViews()
        {
            for(int i=0;i< Application.OpenForms.Count;i++)
            {
                if (!Application.OpenForms[i].Equals(this))
                {
                    Application.OpenForms[i].Close();
                    i--;
                }
            }

        }

    }
}
