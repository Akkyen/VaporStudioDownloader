using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using VaporStudioDownloader.Model;

namespace VaporStudioDownloader.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<Profile> _profiles;

    private Profile _selectedProfile;

    public ObservableCollection<Profile> Profiles
    {
        get => _profiles;
        set { SetProperty(ref _profiles, value); }
    }

    public Profile SelectedProfile
    {
        get => _selectedProfile;
        set { SetProperty(ref _selectedProfile, value); }
    }
}