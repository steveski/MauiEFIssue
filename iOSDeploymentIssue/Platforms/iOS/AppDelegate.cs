namespace iOSDeploymentIssue;

using Foundation;
using SQLitePCL;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp()
    {
        

        return MauiProgram.CreateMauiApp();
    }
}
