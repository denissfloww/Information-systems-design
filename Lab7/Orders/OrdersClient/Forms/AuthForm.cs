using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using OrdersClient.Forms;
using OrdersClient.Controllers;

namespace OrdersClient
{
    public partial class AuthForm : MetroForm
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private async void btnAuth_Click(object sender, EventArgs e)
        {
            var id = await Task.Run(() => UserController.Auth(tbUserName.Text, tbPassword.Text));
            var form = new OrdersForm(id);
            form.Show();
            this.Hide();
        }

    }
}
