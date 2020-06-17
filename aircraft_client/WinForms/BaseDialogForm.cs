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
    public partial class BaseDialogForm : Form, IBaseDialogView
    {

        public event Action Continue;
        public event Action Cancel;

        protected BaseDialogForm()
        {
            InitializeComponent();
            ContinueButton.Click += (sender, e) => Invoke(Continue);
            CancelButton.Click += (sender, e) => Invoke(Cancel);
        }

        public new void Show()
        {
            ShowDialog();
        }

        public void ShowError(string errorMessage, string title)
        {
            MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void Invoke(Action e)
        {
            e?.Invoke();
        }

    }
}
