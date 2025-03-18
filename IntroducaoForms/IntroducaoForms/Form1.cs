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
        
        List<User> usersList = new List<User>();
        public LoginForm()
        {
            InitializeComponent();

            // Criando usuários fictícios para simular busca em banco de dados.

            usersList.Add(new User("senai134@gmail.com", "info@134"));
            usersList.Add(new User("gabriel.selvenca@gmail.com", "senha123"));
            usersList.Add(new User("fiorentino@gmail.com", "123senha"));
        }

        private void ButtonJoin_MouseClick(object sender, MouseEventArgs e)
        {
            var searchUser = usersList.FirstOrDefault(x => x.Email==TxtEmail.Text && x.Password == TxtPassword.Text);

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

// Criando o objeto Usuário para simular um banco de dados.
public class User
{
    public string Email { get; set; }
    public string Password { get; set; }

    public User(string email, string password)
    {
        Email = email;
        Password = password;
    }
}