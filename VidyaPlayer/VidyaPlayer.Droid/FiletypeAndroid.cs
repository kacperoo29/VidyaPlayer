using Java.Net;
using VidyaPlayer.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(FiletypeAndroid))]
namespace VidyaPlayer.Droid
{
    public class FiletypeAndroid : IFiletype
    {
        public bool IsVideo(string path)
        {
            string mimeType = URLConnection.GuessContentTypeFromName(path);
            return mimeType != null && mimeType.StartsWith("video");
        }

        public bool IsAudio(string path)
        {
            
            string mimeType = URLConnection.GuessContentTypeFromName(path);
            return mimeType != null && mimeType.StartsWith("audio");
        }

        public bool IsSubtitle(string path)
        {
            string mimeType = URLConnection.GuessContentTypeFromName(path);
            return mimeType != null && mimeType.StartsWith("text");
        }
    }
}