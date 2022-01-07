using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VidyaPlayer
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
            
            Update(path);
            Files.ItemTapped += (sender, args) =>
            {
                var selectedIndex = args.ItemIndex;
                if (_directories.Count > 0 && selectedIndex >= 0 && selectedIndex < _directories.Count)
                {
                    Navigation.PushAsync(new FsView(_directories[selectedIndex]));
                }
                else
                {
                    // TODO: Open file if supported, maybe even list only supported files
                    var player = new VideoPlayer(_files[selectedIndex - _directories.Count()]);
                    Navigation.PushAsync(player);
                }
            };
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