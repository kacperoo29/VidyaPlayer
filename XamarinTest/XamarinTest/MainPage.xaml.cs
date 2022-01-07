using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace XamarinTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            var fs = DependencyService.Get<IFilesystem>();
            try
            {
                fs.AwaitPermissions().Wait();
                this.InternalChildren.Add(new FsView(fs.GetHome()));
            }
            catch (Exception e)
            {
                Path.Text = "You must grant file permissions to read data";
                Log.Warning("MainPage", e.Message);
            }
        }
    }
}