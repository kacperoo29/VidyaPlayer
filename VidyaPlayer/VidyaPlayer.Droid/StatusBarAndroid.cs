using Android.App;
using Android.Views;
using VidyaPlayer;
using VidyaPlayer.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(StatusBarAndroid))]
namespace VidyaPlayer.Droid
{
    public class StatusBarAndroid : IStatusBar
    {
        public StatusBarAndroid()
        {
        }

        WindowManagerFlags _originalFlags;

        #region IStatusBar implementation

        public void HideStatusBar()
        {
            var activity = (Activity) Forms.Context;
            var attrs = activity.Window.Attributes;
            _originalFlags = attrs.Flags;
            attrs.Flags |= Android.Views.WindowManagerFlags.Fullscreen;
            activity.Window.Attributes = attrs;
        }

        public void ShowStatusBar()
        {
            var activity = (Activity) Forms.Context;
            var attrs = activity.Window.Attributes;
            attrs.Flags = _originalFlags;
            activity.Window.Attributes = attrs;
        }

        #endregion
    }
}
