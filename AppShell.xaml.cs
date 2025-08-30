namespace PA_CPR_UI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(PrepareSmartphonePage), typeof(PrepareSmartphonePage));
        Routing.RegisterRoute(nameof(ZeroPaddingAndInstructionsPage), typeof(ZeroPaddingAndInstructionsPage));
        Routing.RegisterRoute(nameof(CPRPage), typeof(CPRPage));
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}
