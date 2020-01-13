using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamUIDemo.Animations
{
    public static class ViewAnimations
    {
        public static async Task FadeAnimY(View view)
        {


            await Task.WhenAll
               (
                    view.FadeTo(1, 200),
                    view.TranslateTo(0, 0, 200)
               );
        }
    }

}
