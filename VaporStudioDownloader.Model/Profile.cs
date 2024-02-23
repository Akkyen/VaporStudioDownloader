using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace VaporStudioDownloader.Model;

public class Profile : ObservableObject
{
    private string _name;
    private string _description;

    private string _appId;

    private string _pathToModFolder;

    private ObservableCollection<Mod> _mods;

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public string Description
    {
        get => _description;
        set => SetProperty(ref _description, value);
    }

    public string AppId
    {
        get => _appId;
        set { SetProperty(ref _appId, value); }
    }

    public string PathToModFolder
    {
        get => _pathToModFolder;
        set { SetProperty(ref _pathToModFolder, value); }
    }

    public ObservableCollection<Mod> Mods
    {
        get => _mods;
        set => SetProperty(ref _mods, value);
    }

    protected bool Equals(Profile other)
    {
        return _name == other._name && _appId == other._appId && _pathToModFolder == other._pathToModFolder;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Profile)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_name, _appId, _pathToModFolder);
    }
}