using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamUIDemo.Animations;

namespace XamUIDemo.LoginPages
{
    public partial class LoginPage2 : ContentPage
    {
        public LoginPage2()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Task.Run(async () =>
            {
                await ViewAnimations.FadeAnimY(Logo);
                await ViewAnimations.FadeAnimY(MainStack);

            });
        }
        protected void Back(object s, EventArgs e)
        {
            Navigation.PopAsync();
        }
        protected void Login(object s, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage10());
        }
    }
}
