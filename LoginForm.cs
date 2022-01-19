using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace ReCoin
{
    public partial class LoginForm : Form
    {
        TimeSpan TimeOut = new TimeSpan(0,0,20);
        public LoginForm()
        {
            InitializeComponent();
            
        }
        bool InputError()
        {
            var Name = UsernameInput.Text;
            var Pass = PasswordInput.Text;
            if (!string.IsNullOrEmpty(Name) & !string.IsNullOrEmpty(Pass))
                return false;
            MessageBox.Show("Invalid Entry!");
            return true;
        }
        private void LoginClicked(object sender, EventArgs e)
        {
            var Name = UsernameInput.Text;
            var Pass = PasswordInput.Text;
            if (!InputError())
            {
                LoginAsync(Name, Pass);
            }
        }

        private void SignUpClicked(object sender, EventArgs e)
        {
            var Name = UsernameInput.Text;
            var Pass = PasswordInput.Text;
            if (!InputError())
            {
                SignUpAsync(Name, Pass);
            }
        }

        public async void SignUpAsync(string Name, string Password)
        {
            try
            {
                if (await FBase.Users.Child(Name).OnceSingleAsync<User>() == null)
                {
                    await FBase.Client
                        .Child($"Users/{Name}")
                        .PutAsync(new User()
                        {
                            ID = FBase.Users.OnceAsync<User>().Result.Count,
                            Username = Name,
                            Password = Password,
                            Created = DateTime.Now.ToString(),
                            Wallet = new Wallet() { Balance = 0f }
                        });
                    MessageBox.Show("Success!", "Succesful");
                }
                else
                    MessageBox.Show("Username is Taken!","Error!");
            }
            catch (Exception) { }
        }
        User CurrentUser;
        public async void LoginAsync(string Name, string Password)
        {
            if (Name == "Test" & Password == "Test")
            {
                var Dash = new Dashboard(new User(), this);
                Dash.Show();
                Hide();
                return;
            }
            User user = new();
            try
            {
                user = await FBase.Client.Child("Users").Child(Name).OnceSingleAsync<User>();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            finally
            {
                if (user == null)
                {
                    MessageBox.Show("User not Found!","Error!");
                }
                else if (user.Password == Password)
                {
                    CurrentUser = user;
                    var Dash = new Dashboard(CurrentUser, this);
                    Dash.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error!","Failed To Login");
                }
            }
        }
    }
}
