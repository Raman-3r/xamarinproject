using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //    this.BackgroundColor = Color.FromHex("2ccbff");
            //    var userlabel = new Label { Text = "username", TextColor = Color.Black };
            //    var userentry = new Entry { Placeholder = "username" };
            //    var passlabel = new Label { Text = "password", TextColor = Color.Black };
            //    var passentry = new Entry { Placeholder = "password",IsPassword=true };

            //    var loginbutton = new Button { Text = "Login", BackgroundColor = Color.White, TextColor = Color.FromHex("2ccbff") };
            //    var reslabel = new Label { Text = "Not A member? sign up now..", TextColor = Color.DarkGray };
            //    loginbutton.Clicked += LoginEvent;
            //    this.Content = new StackLayout
            //    {
            //        Padding = new Thickness(20),
            //        Margin = new Thickness(0, 70, 0, 0),
            //        Children =
            //        {
            //            userlabel,
            //            userentry,
            //            passlabel,
            //            passentry,
            //            loginbutton,
            //            reslabel
            //        }
            //    };
            //}

            //private void LoginEvent(object sender, EventArgs e)
            //{
            //    DisplayAlert("Login", "Login SuccesFully", "Ok");
            //}
        }

            private void LoginBtn(object sender, EventArgs e)
            {
                DisplayAlert("Login", "Login SuccesFully", "Ok");
                Navigation.PushAsync(new HomePage(usernameentry.Text));

            }
        
    }
}