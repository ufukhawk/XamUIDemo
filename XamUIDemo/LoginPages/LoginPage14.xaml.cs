using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamUIDemo.Animations;

namespace XamUIDemo.LoginPages
{
    public partial class LoginPage14 : ContentPage
    {
        public LoginPage14()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Task.Run(async () =>
            {
                await ViewAnimations.FadeAnimY(Logo);
                await ViewAnimations.FadeAnimY(EmailPancake);
                await ViewAnimations.FadeAnimY(PassPancake);
                await ViewAnimations.FadeAnimY(LoginButton);

            });
        }
        protected void Back(object s, EventArgs e)
        {
            Navigation.PopAsync();
        }
        protected void Login(object s, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
