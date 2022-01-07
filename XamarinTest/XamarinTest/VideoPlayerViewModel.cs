using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LibVLCSharp.Shared;
using XamarinTest.Annotations;

namespace XamarinTest
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
        
        public void OnAppearing(string mediaSrc)
        {
            Core.Initialize();

            LibVlc = new LibVLC(enableDebugLogs: true);

            var media = new Media(LibVlc, new Uri(mediaSrc));

            MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            media.Dispose();
            MediaPlayer.Play();
        }


        internal void OnDisappearing()
        {
            MediaPlayer.Stop();
            LibVlc.Dispose();
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