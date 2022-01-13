using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VidyaPlayer.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VidyaPlayer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FsView : ContentPage
    {
        private string _currentPath;
        private List<string> _files;
        private List<string> _directories;

        public FsView(string path)
        {
            InitializeComponent();

            foreach (var item in VidyaPlayer.ToolbarItems.Items)
            {
                this.ToolbarItems.Add(item);
            }

            Update(path);
            Files.ItemTapped += async (sender, args) =>
            {
                var selectedIndex = args.ItemIndex;
                if (_directories.Count > 0 && selectedIndex >= 0 && selectedIndex < _directories.Count)
                {
                    await Navigation.PushAsync(new FsView(_directories[selectedIndex]));
                }
                else
                {
                    var file = _files[selectedIndex - _directories.Count()];
                    if (DependencyService.Get<IFiletype>().IsVideo(file))
                    {
                        var result = await DisplayActionSheet("Actions", "Cancel", null, "Open", "Open with subtitles");
                        VideoPlayer player;
                        if (result == "Open")
                        {
                            player = new VideoPlayer(file);
                        }
                        else
                        {
                            var subtitleFile = await FilePicker.PickAsync();
                            player = new VideoPlayer(file, subtitleFile.FullPath);
                        }

                        var db = await Database.Instance;
                        var shortFilename = Path.GetFileName(file);
                        var movie = await db.GetMovieByFilename(shortFilename);
                        if (movie == null)
                        {
                            await db.InsertMovie(new Movie() {Filename = shortFilename});
                            movie = await db.GetMovieByFilename(shortFilename);
                        }

                        await db.WatchMovie(App.CurrentUser, movie);

                        await Navigation.PushAsync(player);
                    }
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Update(_currentPath);
        }

        private void Update(string newPath)
        {
            var fs = DependencyService.Get<IFilesystem>();
            _currentPath = newPath;
            CurrentPath.Text = _currentPath.Replace(fs.GetHome() + "/", "");

            _files = Directory.GetFiles(_currentPath).ToList();
            _directories = Directory.GetDirectories(_currentPath).ToList();

            Files.ItemsSource = _directories.Concat(_files).Select(Path.GetFileName);
        }
    }
}