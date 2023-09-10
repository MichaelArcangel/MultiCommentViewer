using System.ComponentModel;
using System.Windows.Media;

namespace KickSitePlugin
{
    interface IKickSiteOptions : INotifyPropertyChanged
    {
        bool NeedAutoSubNickname { get; }
        string NeedAutoSubNicknameStr { get; }
        Color NoticeBackColor { get; }
        Color NoticeForeColor { get; }
    }
}
