using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VidyaPlayer.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace VidyaPlayer.Views
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
            }
            catch (Exception e)
            {
                Path.Text = "You must grant file permissions to read data";
                Log.Warning("MainPage", e.Message);
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ToolbarItems.Clear();
            foreach (var item in VidyaPlayer.ToolbarItems.Items)
            {
                this.ToolbarItems.Add(item);
            }
            
            if (App.CurrentUser == null)
            {
                var db = await Database.Instance;
                var users = await db.GetAllUsers();
                var userNames = users.Select(x => x.Username).ToList();
                userNames.Add("Create new");
                string result = await DisplayActionSheet("Select your account", null, null,
                    userNames.ToArray());

                if (result == "Create new")
                {
                    string newUsername = await DisplayPromptAsync("New user", "Input new username");
                    await db.InsertUser(new User() {Username = newUsername});
                    result = newUsername;
                }

                App.CurrentUser = await db.GetUserByUsername(result);
            }
        }
    }
}