using System;
using System.Collections.Generic;
using System.Linq;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using VidyaPlayer.Models;
using VidyaPlayer.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace VidyaPlayer
{
    public static class ToolbarItems
    {
        public static List<ToolbarItem> Items { get; private set; }

        static ToolbarItems()
        {
            Items = new List<ToolbarItem>()
            {
                new ToolbarItem()
                {
                    Text = "Download subtitles",
                    Order = ToolbarItemOrder.Secondary
                },
                new ToolbarItem()
                {
                    Text = "Choose user",
                    Order = ToolbarItemOrder.Secondary
                },
                new ToolbarItem()
                {
                    Text = "Statistics",
                    Order = ToolbarItemOrder.Secondary
                }
            };

            Items[0].Clicked += async (sender, args) =>
            {
                var senderPage = GetParentPage(sender);
                if (senderPage == null)
                    return;

                string result = await senderPage.DisplayPromptAsync("Search subtitles", "Enter movie title");

                await senderPage.Navigation.PushAsync(new SubtitleList(result));
            };

            Items[1].Clicked += async (sender, args) =>
            {
                var senderPage = GetParentPage(sender);
                
                var db = await Database.Instance;
                var users = await db.GetAllUsers();
                var userNames = users.Select(x => x.Username).ToList();
                userNames.Add("Create new");
                string result = await senderPage.DisplayActionSheet("Select your account", null, null,
                    userNames.ToArray());

                if (result == "Create new")
                {
                    string newUsername = await senderPage.DisplayPromptAsync("New user", "Input new username");
                    await db.InsertUser(new User() {Username = newUsername});
                    result = newUsername;
                }

                App.CurrentUser = await db.GetUserByUsername(result);
            };

            Items[2].Clicked += async (sender, args) =>
            {
                var senderPage = GetParentPage(sender);

                await senderPage.Navigation.PushAsync(new StatisticsView());
            };
        }

        private static Page GetParentPage(object sender)
        {
            var element = (Element) sender;
            if (sender is Page)
                return (Page) sender;

            while (!(element.Parent is Page) && element.Parent != null)
                element = element.Parent;

            return element.Parent as Page;
        }
    }
}