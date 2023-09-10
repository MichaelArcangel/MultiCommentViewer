using SitePlugin;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KickSitePlugin
{
    internal class KickComment : MessageBase2, IKickComment
    {
        public override SiteType SiteType { get; } = SiteType.Kick;
        public KickMessageType KickMessageType { get; } = KickMessageType.Comment;
        public string Id { get; set; }
        public string UserId { get; set; }
        public string PostTime { get; set; }
        public IMessageImage UserIcon { get; set; }
        public bool IsDisplayNameSame { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public IEnumerable<IMessagePart> CommentItems { get; set; }

        public KickComment(string raw) : base(raw)
        {

        }
    }
}
