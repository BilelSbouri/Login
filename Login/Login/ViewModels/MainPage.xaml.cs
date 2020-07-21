using Login.Model;
using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public bool res;
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);
            Admin.Source = ImageSource.FromResource("Login.Assets.Images.Adminlogo.png", assembly);
        }

      async private void Loginbutton_Clicked(object sender, EventArgs e)
        {
          
                res = App.Database.GetUserByNameAsync(AdminName.Text, passwordField.Text);
            if(res == true)
            {
                await Navigation.PushAsync(new HomePage());
                CrossToastPopUp.Current.ShowToastMessage("Logged in successfully");
            }
            else
            {
                CrossToastPopUp.Current.ShowToastMessage("Wrong password or username");
            }                  
        }
      async  private void Regitserbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
