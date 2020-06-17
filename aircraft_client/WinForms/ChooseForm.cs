using aircraft_client.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aircraft_client.WinForms
{
    public partial class ChooseForm : BaseDialogForm, IChooseView
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        public void SetAvailableList(List<string> ls)
        {
            foreach (var item in ls)
                ChooseField.Items.Add(item);
        }

        public string GetChoosenItem() =>
            ChooseField.SelectedItem as string;

        public void SetLabel(string name)
        {
            label1.Text=name;
        }
    }
}
