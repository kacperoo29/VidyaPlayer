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
                // TODO: Ask user for title or imdb id and check api for subtitles
                var api = new SubtitlesApi(Configuration.Default);
                var response = await api.SubtitlesAsync(query: "Breaking");
                DependencyService.Get<IMessage>().ShortAlert(response.Data.Count.ToString()); 
                
                foreach (var item in response.Data)
                {
                    Log.Warning("VidyaPlayer", item.Attributes.Language);
                }
            };

            Items[1].Clicked += (sender, args) =>
            {

            };
        }
    }
}