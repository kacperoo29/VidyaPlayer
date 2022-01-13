using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibVLCSharp.Shared;
using VidyaPlayer.Annotations;
using Xamarin.Forms;

namespace VidyaPlayer.ViewModels
{
    public class VideoPlayerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private LibVLC _libVlc;
        
        public LibVLC LibVlc
        {
            get => _libVlc;
            private set => Set(nameof(LibVlc), ref _libVlc, value);
        }
        
        private MediaPlayer _mediaPlayer;
        
        public MediaPlayer MediaPlayer
        {
            get => _mediaPlayer;
            private set => Set(nameof(MediaPlayer), ref _mediaPlayer, value);
        }

        public VideoPlayerViewModel()
        {
            
        }
        
        public void OnAppearing(string mediaSrc, string subtitleFile)
        {
            Core.Initialize();

            LibVlc = new LibVLC(enableDebugLogs: true);
            var media = new Media(LibVlc, new Uri(mediaSrc));

            MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            if (subtitleFile != null)
                MediaPlayer.AddSlave(MediaSlaveType.Subtitle, new Uri(subtitleFile).ToString(), true);
            
            media.Dispose();
            MediaPlayer.Play();
            
            DependencyService.Get<IStatusBar>().HideStatusBar();
        }

        internal void OnDisappearing()
        {
            MediaPlayer.Stop();
            LibVlc.Dispose();
            
            DependencyService.Get<IStatusBar>().ShowStatusBar();
        }

        private void Set<T>(string propertyName, ref T field, T value)
        {
            if (field == null && value != null || field != null && !field.Equals(value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}