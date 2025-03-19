using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IntroducaoForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonJoin_MouseClick(object sender, MouseEventArgs e)
        {
            var searchUser = GlobalData.UserList.FirstOrDefault(x => x.Email==TxtEmail.Text && x.Password == TxtPassword.Text);

            if (searchUser == null)
            {
                MessageBox.Show("Dados inválidos!");
                return;
            }

            MessageBox.Show("Dados corretos! Bem vindo!");
        }

        private void LinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().Show();
        }
    }
}