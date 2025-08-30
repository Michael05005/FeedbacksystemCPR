namespace PA_CPR_UI;

public partial class ZeroPaddingAndInstructionsPage : ContentPage
{
	public ZeroPaddingAndInstructionsPage()
	{
		InitializeComponent();

        // Setting the ScrollView to the bottom
        this.Loaded += async (s, e) =>
        {
            await Task.Delay(5);
            await InstructionScrollView.ScrollToAsync(BackButton, ScrollToPosition.End, true);
        };
    }




    private async void OnCPRButton3Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/CPRPage");
    }
    private async void OnZeroPaddingAndInstructionPageBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/PrepareSmartphonePage");
    }

}