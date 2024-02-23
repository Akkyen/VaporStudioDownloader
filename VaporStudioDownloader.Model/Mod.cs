using CommunityToolkit.Mvvm.ComponentModel;

namespace VaporStudioDownloader.Model
{
    public class Mod : ObservableObject
    {
        private string _modId;
        private string _modName;
        private string _modVersion;

        private DateTime _lastUpdatedUtc;

        public string ModId
        {
            get => _modId;
            set { SetProperty(ref _modId, value); }
        }

        public string ModName
        {
            get => _modName;
            set { SetProperty(ref _modName, value); }
        }

        public string ModVersion
        {
            get => _modVersion;
            set { SetProperty(ref _modVersion, value); }
        }

        public DateTime LastUpdatedUtc
        {
            get => _lastUpdatedUtc;
            set { SetProperty(ref _lastUpdatedUtc, value); }
        }
    }
}
