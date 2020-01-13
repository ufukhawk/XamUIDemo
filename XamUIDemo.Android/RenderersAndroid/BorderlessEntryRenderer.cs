using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamLoginUIDemo.Droid.RenderersAndroid;
using XamUIDemo.Renderers;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessBorderlessEntryRenderer))]
namespace XamLoginUIDemo.Droid.RenderersAndroid
{
    public class BorderlessBorderlessEntryRenderer : EntryRenderer
    {
        public BorderlessBorderlessEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}