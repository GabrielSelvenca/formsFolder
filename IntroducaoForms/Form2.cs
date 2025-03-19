using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroducaoForms
{
    public partial class RegisterForm: Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "" || TxtPassword.Text == "" || TxtName.Text == "" || TxtColor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            GlobalData.UserList.Add(new User(TxtEmail.Text, TxtPassword.Text, TxtName.Text, TxtColor.Text, DateAge.Value));

            MessageBox.Show("Dados cadastrados!");
        }
    }
}
