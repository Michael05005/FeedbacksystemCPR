namespace PA_CPR_UI;

public partial class CPRPage : ContentPage
{
	public CPRPage()
	{
		InitializeComponent();
	}

    private async void OnCPRPageBackButtonClicked(object sender, EventArgs e)
    {

        //pressharder.IsVisible = false;
        //frequency_ok.IsVisible = false;

        await Shell.Current.GoToAsync("/ZeroPaddingAndInstructionsPage");

    }






}