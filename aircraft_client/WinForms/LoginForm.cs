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
    public partial class LoginForm : BaseMainForm, ILoginView
    {
        public LoginForm(ApplicationContext context):base(context)
        {
            InitializeComponent();
            StartButton.Click+=(sender, e) => Invoke(Login);
            ExitButton.Click += (sender, e) => Invoke(Exit);
        }

        public LoginForm()
        {
            InitializeComponent();

        }

        private void Invoke(Action e) =>
            e?.Invoke();

        public string Username => LogField.Text;

        public string Password => PasField.Text;

        public event Action Login;
        public event Action Exit;
    }
}
