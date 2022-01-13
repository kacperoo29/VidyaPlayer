using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaPlayer.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VidyaPlayer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticsView : ContentPage
    {
        private class WatchCount
        {
            public string Name { get; set; }
            public string Count { get; set; }
            
            public WatchCount(string name, int count)
            {
                Name = name;
                Count = count.ToString();
            }
        }

        private ObservableCollection<WatchCount> _counts;
        
        public StatisticsView()
        {
            InitializeComponent();

            _counts = new ObservableCollection<WatchCount>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var db = await Database.Instance;
            var user = await db.GetUserWithChildren(App.CurrentUser);

            foreach (var movie in user.UserMovies)
            {
                var um = await db.GetUserMoviesWithChildren(movie);
                _counts.Add(new WatchCount(um.Movie.Filename, um.TimesWatched));
            }

            WatchList.ItemsSource = _counts;
        }
    }
}