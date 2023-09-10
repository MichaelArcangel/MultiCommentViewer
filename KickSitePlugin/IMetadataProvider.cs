using System;
using System.Threading.Tasks;

namespace KickSitePlugin
{
    interface IMetadataProvider
    {
        event EventHandler<Stream> MetadataUpdated;

        void Disconnect();
        Task ReceiveAsync();
    }
}