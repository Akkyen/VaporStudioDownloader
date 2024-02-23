using CommunityToolkit.Mvvm.ComponentModel;

namespace VaporStudioDownloader.Model;

public class AppConfig : ObservableObject
{
    private string _pathToSteamCmd;

    public string PathToSteamCmd
    {
        get => _pathToSteamCmd;
        set { SetProperty(ref _pathToSteamCmd, value); }
    }
}