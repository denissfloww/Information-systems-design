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

            AcceptButton = btnAuth;
        }

        private async void btnAuth_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbUserName.Text))
            {
                MetroMessageBox.Show(this, "Введите лоигн и пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            UseWaitCursor = true;
            metroProgressSpinner1.Visible = true;
            tbPassword.Enabled = tbUserName.Enabled = btnAuth.Enabled = false;
            var userId = await Task.Run(() => UserController.Auth(tbUserName.Text, tbPassword.Text));
            tbPassword.Enabled = tbUserName.Enabled = btnAuth.Enabled = true;
            metroProgressSpinner1.Visible = false;
            UseWaitCursor = false;

            if (userId == 0)
            {
                MetroMessageBox.Show(this, "Неверный лоигн или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            this.Hide();
            var ordersForm = new OrdersForm(userId);
            ordersForm.FormClosed += (s, args) => this.Close();
            ordersForm.Show();
        }
    }
}
