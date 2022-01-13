using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidyaPlayer.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VidyaPlayer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPlayer : ContentPage
    {
        private string _mediaSrc;
        private string _subtitleFile;
        
        public VideoPlayer(string mediaSource, string subtitleFile = null)
        {
            InitializeComponent();
            _mediaSrc = mediaSource;
            _subtitleFile = subtitleFile;
        }
        
        void OnAppearing(object sender, System.EventArgs e)
        {
            base.OnAppearing();
            ((VideoPlayerViewModel)BindingContext).OnAppearing(_mediaSrc, _subtitleFile);
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            base.OnDisappearing();
            ((VideoPlayerViewModel)BindingContext).OnDisappearing();
        }

    }
}