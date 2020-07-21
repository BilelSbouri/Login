using Login.Model;
using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async private void Registerbutton_Clicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = username.Text,
                Password = passwordField.Text
            };
            await App.Database.SaveUserAsync(user);
            CrossToastPopUp.Current.ShowToastMessage("User added successfully");
            username.Text = string.Empty;
            passwordField.Text = string.Empty;

        }
    }
}