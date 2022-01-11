using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OpenSubtitles.Api;
using OpenSubtitles.Model;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace VidyaPlayer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubtitleDetails : ContentPage
    {
        private Subtitle _subtitle;

        public SubtitleDetails(Subtitle subtitle)
        {
            InitializeComponent();

            _subtitle = subtitle;
            Title.Text = subtitle.Attributes.Release;
            Files.ItemsSource = subtitle.Attributes.Files.Select(x => x.FileName);

            Files.ItemSelected += async (sender, args) =>
            {
                DependencyService.Get<IMessage>().ShortAlert("Started download");
                
                var api = new DownloadApi();
                var file = _subtitle.Attributes.Files[args.SelectedItemIndex];
                var response = await api.DownloadAsync("application/json",
                    new InlineObject1((int) file.FileId));
                
                using (var client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.33 Safari/537.36");
                    client.DownloadFile(response.Link, DependencyService.Get<IFilesystem>().GetHome() + "/Download" + "/" + file.FileName);
                }

                DependencyService.Get<IMessage>().ShortAlert("Finished downloading");
            };
        }
    }
}