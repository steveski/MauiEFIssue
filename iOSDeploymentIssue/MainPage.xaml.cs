using iOSDeploymentIssue.Database;

namespace iOSDeploymentIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage()
    {
        InitializeComponent();

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "logbook.db");
        var db = new EntityDbContext(dbPath);

    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

