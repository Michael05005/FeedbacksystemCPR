using System.Diagnostics;

namespace PA_CPR_UI;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();


	}

    private async void OnCPRButton1Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PrepareSmartphonePage));
    }
}

