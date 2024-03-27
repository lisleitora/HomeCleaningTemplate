namespace HomeCleaningTemplate.Pages;

public partial class TutorialPage : ContentPage
{
	public TutorialPage()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(200);

        pgDownThing.TranslationY = pgDownThing.Height;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushAsync(new ProfilePage());

    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Helpers.Shrink(pgStart, true);
        await Helpers.BoingAppearUp(pgDownThing, true);
    }
    private void Back(object sender, EventArgs e)
    {
        pgDownThing.TranslationY = pgDownThing.Height;

    }
}