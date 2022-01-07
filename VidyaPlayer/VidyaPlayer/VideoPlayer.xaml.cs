using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VidyaPlayer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPlayer : ContentPage
    {
        private string _mediaSrc;
        
        public VideoPlayer(string mediaSource)
        {
            InitializeComponent();
            //Media.Source = mediaSource;
            _mediaSrc = mediaSource;
        }
        
        void OnAppearing(object sender, System.EventArgs e)
        {
            base.OnAppearing();
            ((VideoPlayerViewModel)BindingContext).OnAppearing(_mediaSrc);
        }

        void OnDisappearing(object sender, System.EventArgs e)
        {
            base.OnDisappearing();
            ((VideoPlayerViewModel)BindingContext).OnDisappearing();
        }

    }
}