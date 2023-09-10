using SitePlugin;

namespace KickSitePlugin
{
    internal class KickConnected : MessageBase2, IKickConnected
    {
        public override SiteType SiteType { get; } = SiteType.Kick;
        public KickMessageType KickMessageType { get; } = KickMessageType.Connected;
        public string Text { get; }

        public KickConnected(string raw) : base(raw)
        {
            Text = "接続しました";
        }
    }
}
