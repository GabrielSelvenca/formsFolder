using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroducaoForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Criando usuários fictícios para simular busca em banco de dados.

            GlobalData.UserList.Add(new User("senai134@gmail.com", "info@134", "Administração", "Vermelho", new DateTime(1999, 02, 12)));
            GlobalData.UserList.Add(new User("fiorentino@gmail.com", "123senha", "Arthur", "Amarelo", new DateTime(2006, 06, 25)));
            GlobalData.UserList.Add(new User("gabriel.selvenca@gmail.com", "senha123", "Gabriel", "Azul", new DateTime(2006, 08, 09)));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }

    public static class GlobalData
    { 
        public static List<User> UserList { get; set; } = new List<User>();

        public static User LoggedUser { get; set; }
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string FavoriteColor { get; set; }
        public DateTime Age { get; set; }


        public User(string email, string password, string name, string favoriteColor, DateTime age)
        {
            Email = email;
            Password = password;
            Name = name;
            FavoriteColor = favoriteColor;
            Age = age;
        }
    }
}
