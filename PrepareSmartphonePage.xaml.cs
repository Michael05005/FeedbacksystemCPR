namespace PA_CPR_UI;

public partial class PrepareSmartphonePage : ContentPage
{
	public PrepareSmartphonePage()
	{
		InitializeComponent();
	}

    private async void OnCPRButton2Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/ZeroPaddingAndInstructionsPage");

    }

    private async void OnPrepareSmartphonePageBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }


}