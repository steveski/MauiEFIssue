using iOSDeploymentIssue.Database;

namespace iOSDeploymentIssue.ViewModels;
public class MainPageViewModel : BaseViewModel
{
    private readonly EntityDbContext _db;

    public MainPageViewModel(EntityDbContext db)
    {
        _db = db;
    }



}
