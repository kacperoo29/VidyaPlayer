using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Android;
using Android.Content.PM;
using Android.OS;
using AndroidX.Core.App;
using Java.Lang;
using Xamarin.Forms;

[assembly: Dependency(typeof(VidyaPlayer.Droid.Filesystem))]
namespace VidyaPlayer.Droid
{
    public class Filesystem : IFilesystem
    {
        public static MainActivity MainActivity { get; set; }
        public string GetHome()
        {
            return Environment.ExternalStorageDirectory.Path;
        }

        public Task AwaitPermissions()
        {
            var task = Task.Factory.StartNew(() =>
            {
                while (ActivityCompat.CheckSelfPermission(MainActivity, Manifest.Permission.ReadExternalStorage) != Permission.Granted) 
                    Thread.Sleep(100);
            });

            return task;
        }
    }
}