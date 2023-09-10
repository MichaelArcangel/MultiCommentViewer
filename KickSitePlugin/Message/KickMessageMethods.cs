using SitePlugin;
using System.Threading.Tasks;

namespace KickSitePlugin
{
    internal class KickMessageMethods : IMessageMethods
    {
        public Task AfterCommentAdded()
        {
            return Task.CompletedTask;
        }
    }
}
