using System.Threading.Tasks;

namespace VidyaPlayer
{
    public interface IFilesystem
    {
        string GetHome();
        Task AwaitPermissions();
    }
}