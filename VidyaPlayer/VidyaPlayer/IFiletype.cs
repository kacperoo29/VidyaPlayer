namespace VidyaPlayer
{
    public interface IFiletype
    {
        bool IsVideo(string path);
        bool IsAudio(string path);
        bool IsSubtitle(string path);
    }
}