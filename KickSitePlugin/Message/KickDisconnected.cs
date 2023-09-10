using SitePlugin;
using System.Collections.Generic;

namespace KickSitePlugin
{
    internal class KickDisconnected : MessageBase2, IKickDisconnected
    {
        public override SiteType SiteType { get; } = SiteType.Kick;
        public KickMessageType KickMessageType { get; } = KickMessageType.Disconnected;
        public string Text { get; }

        public KickDisconnected(string raw) : base(raw)
        {
            Text = "切断しました";
        }
    }
}
