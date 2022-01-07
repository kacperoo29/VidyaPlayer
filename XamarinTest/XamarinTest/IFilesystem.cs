using System.Threading.Tasks;

namespace XamarinTest
{
    public interface IFilesystem
    {
        string GetHome();
        Task AwaitPermissions();
    }
}