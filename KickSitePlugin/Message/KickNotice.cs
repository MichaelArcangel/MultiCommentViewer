using SitePlugin;

namespace KickSitePlugin
{
    internal class KickNotice : MessageBase2, IKickNotice
    {
        public override SiteType SiteType { get; } = SiteType.Kick;
        public KickMessageType KickMessageType { get; } = KickMessageType.Notice;
        public string Message { get; set; }

        public KickNotice(string raw) : base(raw)
        {
        }
    }
}
