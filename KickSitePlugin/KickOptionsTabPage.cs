using SitePlugin;
namespace KickSitePlugin
{
    public class KickOptionsTabPage : IOptionsTabPage
    {
        public string HeaderText { get; }

        public System.Windows.Controls.UserControl TabPagePanel => _panel;

        public void Apply()
        {
            var optionsVm = _panel.GetViewModel();
            optionsVm.OriginOptions.Set(optionsVm.ChangedOptions);
        }

        public void Cancel()
        {
        }
        private readonly TabPagePanel _panel;
        public KickOptionsTabPage(string displayName, TabPagePanel panel)
        {
            HeaderText = displayName;
            _panel = panel;
        }
    }
}
