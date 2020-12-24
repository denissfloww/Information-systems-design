using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OrdersClient.Controllers;

namespace OrdersClient.Forms
{
    public partial class FilterForm : MetroForm
    {
        private OrdersForm OrdersForm { get; set; }
        private Action<object, EventArgs> RefreshAction;

        public FilterForm(OrdersForm ordersForm, Action<object, EventArgs> refreshAction)
        {
            InitializeComponent();
            OrdersForm = ordersForm;
            RefreshAction = refreshAction;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            OrdersForm.Filter.Add(cbField.SelectedItem.ToString(),tbValue.Text);
           // RefreshAction(null, null);
            this.Close();
        }
    }
}
