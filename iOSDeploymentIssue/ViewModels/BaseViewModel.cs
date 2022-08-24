namespace iOSDeploymentIssue.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {

    }

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    private string _title;

}
