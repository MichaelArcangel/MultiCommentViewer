using System;
using System.ComponentModel;
using System.Windows.Media;

namespace KickSitePlugin
{
    class KickSiteOptionsViewModel : INotifyPropertyChanged
    {
        public bool NeedAutoSubNickname
        {
            get => changed.NeedAutoSubNickname;
            set => changed.NeedAutoSubNickname = value;
        }
        public string NeedAutoSubNicknameStr
        {
            get => changed.NeedAutoSubNicknameStr;
            set => changed.NeedAutoSubNicknameStr = value;
        }
        public Color NoticeBackColor
        {
            get { return ChangedOptions.NoticeBackColor; }
            set { ChangedOptions.NoticeBackColor = value; }
        }
        public Color NoticeForeColor
        {
            get { return ChangedOptions.NoticeForeColor; }
            set { ChangedOptions.NoticeForeColor = value; }
        }
        private readonly KickSiteOptions _origin;
        private readonly KickSiteOptions changed;
        internal KickSiteOptions OriginOptions { get { return _origin; } }
        internal KickSiteOptions ChangedOptions { get { return changed; } }

        internal KickSiteOptionsViewModel(KickSiteOptions siteOptions)
        {
            _origin = siteOptions;
            changed = siteOptions.Clone();
        }

        #region INotifyPropertyChanged
        [NonSerialized]
        private System.ComponentModel.PropertyChangedEventHandler _propertyChanged;
        /// <summary>
        /// 
        /// </summary>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged
        {
            add { _propertyChanged += value; }
            remove { _propertyChanged -= value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            _propertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
