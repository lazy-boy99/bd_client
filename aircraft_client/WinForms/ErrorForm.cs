using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aircraft_client.WinForms
{
    public class ErrorForm : IErrorView
    {
        private string errorMessage;
        private string title;

        public void Close()
        {
        }

        public void Show()
        {
            MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SetDescription(string errorMessage, string title)
        {
            this.errorMessage = errorMessage;
            this.title = title;
        }
        
    }
}
