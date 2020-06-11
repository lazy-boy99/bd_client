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
    public partial class SignUpForm : BaseDialogForm,ISignUpView
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        
        public string Username => LogField.Text;

        public string Pas => PasField.Text;

        public string GetSelectedRole() =>
            RoleBox.SelectedItem as string;

        public void SetRoleList(List<string> ls)
        {
            foreach (var item in ls)
                RoleBox.Items.Add(item);
        }
    }
}
