using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace VidyaPlayer
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
                CurrentPath.Text = "Home";
                this.InternalChildren.Add(new FsView(fs.GetHome()));
                foreach (var item in VidyaPlayer.ToolbarItems.Items)
                {
                    this.ToolbarItems.Add(item);
                }
            }
            catch (Exception e)
            {
                Path.Text = "You must grant file permissions to read data";
                Log.Warning("MainPage", e.Message);
            }
        }
    }
}