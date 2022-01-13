using System.Collections.Generic;
using System.Linq;
using OpenSubtitles.Api;
using OpenSubtitles.Client;
using OpenSubtitles.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VidyaPlayer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubtitleList : ContentPage
    {
        private readonly string _movieTitle;
        private List<Subtitle> _subtitles;
        
        public SubtitleList(string movieTitle)
        {
            InitializeComponent();

            _movieTitle = movieTitle;
            _subtitles = new List<Subtitle>();

            SubtitleListView.ItemSelected += async (sender, args) =>
            {
                await Navigation.PushAsync(new SubtitleDetails(_subtitles[args.SelectedItemIndex]));
            };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            var api = new SubtitlesApi(Configuration.Default);
            var response = await api.SubtitlesAsync(query: _movieTitle);
            // TODO: Handle bad responses

            _subtitles = response.Data;
            SubtitleListView.ItemsSource = response.Data.Select(x => x.Attributes.Release);
            LoadingIndicator.IsVisible = false;
        }
    }
}