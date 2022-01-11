using System;
using System.Collections.Generic;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
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
                    Text = "Download lyrics",
                    Order = ToolbarItemOrder.Secondary
                }
            };

            Items[0].Clicked += async (sender, args) =>
            {
                var element = (Element) sender;
                while (!(element.Parent is Page))
                    element = element.Parent;

                var senderPage = (Page) element.Parent;
                string result = await senderPage.DisplayPromptAsync("Search subtitles", "Enter movie title");
                
                await senderPage.Navigation.PushAsync(new SubtitleList(result));
            };

            Items[1].Clicked += (sender, args) =>
            {

            };
        }
    }
}