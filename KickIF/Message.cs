using SitePlugin;
using System.Collections.Generic;

namespace KickSitePlugin
{
    public enum KickMessageType
    {
        Unknown,
        Comment,
        //Item,
        Connected,
        Disconnected,
        Notice,
    }


    public interface IKickMessage : ISiteMessage
    {
        KickMessageType KickMessageType { get; }
    }
    public interface IKickConnected : IKickMessage
    {
        string Text { get; }
    }
    public interface IKickDisconnected : IKickMessage
    {
        string Text { get; }
    }
    public interface IKickComment : IKickMessage
    {
        string Id { get; }
        /// <summary>
        /// NameItemsとDisplayNameが同値か
        /// </summary>
        bool IsDisplayNameSame { get; }
        string DisplayName { get; }
        string UserName { get; }
        IEnumerable<IMessagePart> CommentItems { get; }
        string PostTime { get; }
        IMessageImage UserIcon { get; }
    }
    public interface IKickNotice : IKickMessage
    {
        string Message { get; }
    }
    //public interface IKickItem : IKickMessage
    //{
    //    string ItemName { get; }
    //    int ItemCount { get; }
    //    //string Comment { get; }
    //    long Id { get; }
    //    //string UserName { get; }
    //    string UserPath { get; }
    //    long UserId { get; }
    //    string AccountName { get; }
    //    long PostedAt { get; }
    //    string UserIconUrl { get; }
    //}
}