using System;
using Xamarin.Forms;

namespace MyShop
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            //var user = new User
            //{
            //    Username = usernameEntry.Text,
            //    Password = passwordEntry.Text
            //};

            //var isValid = AreCredentialsCorrect(user);
            //if (isValid)
            //{
            //    App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MapPage(), this);
                await Navigation.PopAsync();
            //}
            //else {
            //    messageLabel.Text = "Login failed";
            //    passwordEntry.Text = string.Empty;
            //}
        }

        bool AreCredentialsCorrect(User user)
        {
            string username = Constants.Username;
            string password = Constants.Password;
            return user.Username == username && user.Password == password;
        }
    }
}
